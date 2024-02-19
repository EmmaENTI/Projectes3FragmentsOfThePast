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
        chipCounterText = transform.parent.GetChild(6).GetComponentInChildren<TMP_Text>();
        UpdateUIChipCounter();
    }

    public void LoseChips()
    {
        chipCount -= 1 + (chipCount/2 * doubtFailedMultiplier);
        doubtFailedMultiplier = 0;

        UpdateUIChipCounter();
    }

    public void GainChips()
    {
        chipCount += 2;

        UpdateUIChipCounter();
    }

    public int GetChips()
    {
        return chipCount;
    }

    public void SetDoubtMultiplier()
    {
        doubtFailedMultiplier++;
        doubtFailedMultiplier %= 2;

        Debug.Log(doubtFailedMultiplier);
    }

    public void ResetLives()
    {
        chipCount = 3;
        isLeftChoice = false;
        isRightChoice = false;
        doubtFailedMultiplier = 0;

        UpdateUIChipCounter();

        DestroyChip();
    }

    public void DestroyChip()
    {
        if (transform.childCount != 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    public void UpdateUIChipCounter()
    {
        chipCounterText.text = chipCount.ToString();
    }
}
