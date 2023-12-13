using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public enum DificultyModes: int { EASY = 15, NORMAL = 8, HARD = 3}
public class Lock : MonoBehaviour
{
    [SerializeField] private GameObject lockPosition;
    [SerializeField] private GameObject layerBase;
    [SerializeField] private GameObject targetZoneBase;
    [SerializeField] private GameObject lockPickBase;

    int numOfLayers = 5;
    float layerSize = 0.7f;
    DificultyModes[] layerDifficulty;
    DificultyModes[] difficultyTypes = { DificultyModes.EASY, DificultyModes.NORMAL, DificultyModes.HARD};
    int currentLayer;

    int numOfLockPicks = 1;

    void Start()
    {
        CreateLock();
    }

    void Update()
    {
        
    }


    public void CreateLock()
    {
        SetDifficultyLayers();
        CreateLayers();
        CreateLockPicks();
    }

    private void SetDifficultyLayers()
    {
        layerDifficulty = new DificultyModes[numOfLayers]; 
        for (int i = 0; i < numOfLayers; i++)
        {
            layerDifficulty[i] = difficultyTypes[Random.Range(0,3)];
        }
    }
    
    private void CreateLayers()
    {
        currentLayer = numOfLayers-1;
        for (int i = numOfLayers-1; i >= 0; i--)
        {
            
            var layer = Instantiate(layerBase, lockPosition.transform.position, Quaternion.identity, lockPosition.transform);
            layer.transform.localScale = new Vector3(2 + layerSize * i, 2 + layerSize * i, 0.0f);
            layer.transform.name = "Layer" + i;

            if (i == 0) return;
            
            var layerTarget = Instantiate(targetZoneBase, lockPosition.transform.position, Quaternion.identity, lockPosition.transform);
            layerTarget.transform.localScale = new Vector3(2 + layerSize * i, 2 + layerSize * i, 0.0f);
            layerTarget.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0.0f, 360.0f));
            layerTarget.GetComponent<Image>().fillAmount = (float)layerDifficulty[i] / 100.0f;
            layerTarget.transform.name = "LayerTarget" + i;

            Vector2 colliderOffset = layerTarget.GetComponent<RectTransform>().sizeDelta/2;
            
            float angle = (float)layerDifficulty[i] / 100.0f * 90.0f / 0.25f * Mathf.Deg2Rad;
           
            //Debug.Log("LayerDiff: " + (float)layerDifficulty[i] + " Ar: " + angle + " Cos: " + Mathf.Cos(angle) + " Sin: " + Mathf.Sin(angle));

            List<Vector2> colliderPoints = new List<Vector2> { new Vector2(0.0f, 50.0f), new Vector2(colliderOffset.x * Mathf.Sin(angle), colliderOffset.y * Mathf.Cos(angle)) };
            layerTarget.GetComponent<EdgeCollider2D>().SetPoints(colliderPoints);
        }
    }

    private void CreateLockPicks()
    {
        for (int i = 0; i < numOfLockPicks; i++)
        {
            var lockPick = Instantiate(lockPickBase, lockPosition.transform.position, Quaternion.identity, lockPosition.transform);
            lockPick.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0.0f, 360.0f));
        }
    }

    public int GetNextLayerNum() => currentLayer;

    public void SetNextLayerNum() => currentLayer--;
}
