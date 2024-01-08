using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1SaveController : MonoBehaviour
{
    [SerializeField] private GameObject marinaCharacterSprite;
    [SerializeField] private GameObject luisCharacterSprite;
    [SerializeField] private GameObject brunoCharacterSprite;
    [SerializeField] private GameObject carmenCharacterSprite;

    [SerializeField] LoadManager loadManager;

    public DialoguesInfoManager dialoguesInfoManager;
    // Start is called before the first frame update
    void Start()
    {
        if (loadManager.marinaDay1)
        {
            dialoguesInfoManager.marinaDay1Phase1Finished = true;
            marinaCharacterSprite.SetActive(false);
        }

        if (loadManager.luisDay1)
        {
            dialoguesInfoManager.luisDay1Phase1Finished = true;
            luisCharacterSprite.SetActive(false);
        }

        if (loadManager.brunoDay1)
        {
            dialoguesInfoManager.brunoDay1Phase1Finished = true;
            brunoCharacterSprite.SetActive(false);
        }

        if (loadManager.carmenDay1)
        {
            dialoguesInfoManager.carmenDay1Phase1Finished = true;
            carmenCharacterSprite.SetActive(false);
        }
    }

}
