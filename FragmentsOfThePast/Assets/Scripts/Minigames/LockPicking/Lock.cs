using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum DificultyModes: int { EASY = 25, NORMAL = 15, HARD = 8}
public class Lock : MonoBehaviour
{
    [SerializeField] private GameObject lockPosition;
    [SerializeField] private GameObject layerBase;
    [SerializeField] private GameObject targetZoneBase;
    [SerializeField] private GameObject lockPickBase;

    int numOfLayers = 3;
    float layerSize = 0.7f;
    DificultyModes[] layerDifficulty;
    DificultyModes[] difficultyTypes = { DificultyModes.EASY, DificultyModes.NORMAL, DificultyModes.HARD};



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
            Debug.Log(layerDifficulty[i].ToString());
        }
    }
    
    private void CreateLayers()
    {
        for (int i = numOfLayers-1; i >= 0; i--)
        {
            var layer = Instantiate(layerBase, lockPosition.transform.position, Quaternion.identity, lockPosition.transform);
            var layerTarget = Instantiate(targetZoneBase, lockPosition.transform.position, Quaternion.identity, lockPosition.transform);

            layer.transform.localScale = new Vector3(2 + layerSize * i, 2 + layerSize * i, 0.0f);

            // Randomize Rotation
            layerTarget.transform.localScale = new Vector3(2 + layerSize * i, 2 + layerSize * i, 0.0f);
            layerTarget.GetComponent<Image>().fillAmount = (float)layerDifficulty[i] / 100.0f;
        }
    }

    private void CreateLockPicks()
    {
        for (int i = 0; i < numOfLockPicks; i++)
        {
            var lockPick = Instantiate(lockPickBase, lockPosition.transform.position, Quaternion.identity, lockPosition.transform);
        }
    }
}
