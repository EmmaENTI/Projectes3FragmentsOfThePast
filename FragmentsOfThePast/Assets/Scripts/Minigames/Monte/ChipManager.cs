using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChipManager : MonoBehaviour
{
    public GameObject chipPrefab;

    int chipCount = 3;

    public bool isLeftChoice = false;
    public bool isRightChoice = false;

    int doubtFailedMultiplier = 0;

    TMP_Text chipCounterText;

    private void Start()
    {
    }

    public void LoseChips()
    {
        chipCount -= 1 + (chipCount/2 * doubtFailedMultiplier);
        doubtFailedMultiplier = 0;
        DestroyChip();
    }

    public void GainChips()
    {
        chipCount += 2;
        DestroyChip();
    }

    public int GetChips()
    {
        return chipCount;
    }

    public void SetDoubtMultiplier()
    {
        doubtFailedMultiplier++;
        doubtFailedMultiplier %= 2;
    }

    public void ResetLives()
    {
        chipCount = 3;
        isLeftChoice = false;
        isRightChoice = false;
        doubtFailedMultiplier = 0;

        DestroyChip();
    }

    public void DestroyChip()
    {
        if (transform.childCount != 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    public void RecollectChip()
    {
        if (transform.childCount != 0)
        {
            Destroy(transform.GetChild(0).gameObject);
            chipCount++;
        }
    }
}
