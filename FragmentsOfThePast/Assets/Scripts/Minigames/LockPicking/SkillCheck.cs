using System.Collections;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UI;

public enum DifficultySkillCheckModes: int { EASY = 20, NORMAL = 16, HARD = 8 }

public class SkillCheck : MonoBehaviour
{
    [SerializeField] private GameObject skillCheckPosition;
    [SerializeField] private GameObject skillCheckBase;
    [SerializeField] private GameObject skillCheckTargetBase;
    [SerializeField] private GameObject skillCheckBarBase;

    DifficultySkillCheckModes skillCheckDifficulty;
    DifficultySkillCheckModes[] difficultyTypes = { DifficultySkillCheckModes.EASY, DifficultySkillCheckModes.NORMAL, DifficultySkillCheckModes.HARD };

    int numOfSkillChecks = 1;

    float minAngle = 20.0f;
    float maxAngle = 70.0f;

    void Start()
    {
        //SetDifficultySkillCheck();
        //CreateSkillCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateSkillCheck()
    {
        SetDifficultySkillCheck();

        var layer = Instantiate(skillCheckBase, skillCheckPosition.transform.position, Quaternion.identity, skillCheckPosition.transform);
        layer.transform.name = "SkillCheck";


        var layerTarget = Instantiate(skillCheckTargetBase, skillCheckPosition.transform.position, Quaternion.identity, skillCheckPosition.transform);
        layerTarget.transform.rotation = Quaternion.Euler(0, 0, Random.Range(minAngle, maxAngle));
        layerTarget.GetComponent<Image>().fillAmount = (float)skillCheckDifficulty / 100.0f;
        layerTarget.transform.name = "SkillCheckTarget";

        Vector2 colliderOffset = layerTarget.GetComponent<RectTransform>().sizeDelta / 2;

        float angle = (float)skillCheckDifficulty / 100.0f * 90.0f / 0.25f * Mathf.Deg2Rad;

        List<Vector2> colliderPoints = new List<Vector2> { new Vector2(0.0f, 200.0f), new Vector2(colliderOffset.x * Mathf.Sin(-angle), colliderOffset.y * Mathf.Cos(angle)) };
        layerTarget.GetComponent<EdgeCollider2D>().SetPoints(colliderPoints);

        var checkBar = Instantiate(skillCheckBarBase, skillCheckPosition.transform.position, Quaternion.identity, skillCheckPosition.transform);
        checkBar.name = "SkillCheckBar";
    }

    private void SetDifficultySkillCheck()
    {
        skillCheckDifficulty = difficultyTypes[Random.Range(0, 3)];
    }
}
