using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectTraitButton : MonoBehaviour
{
    public DialoguesInfoManager dialoguesInfoManager;
    [SerializeField] private TextMeshProUGUI buttonContentText;

    [SerializeField] private GameObject selectionPanel;
    [SerializeField] private GameObject alchemyPanel;
    [SerializeField] private GameObject lobbyPanel;


    [SerializeField] private GameObject marinaCharacterSprite;
    [SerializeField] private GameObject luisCharacterSprite;
    [SerializeField] private GameObject brunoCharacterSprite;
    [SerializeField] private GameObject carmenCharacterSprite;

    [SerializeField] LoadManager loadManager;
    [SerializeField] MarinaActiveCinematicText marinaActiveCinematic;

    [SerializeField] private GameObject CinematicPanel;

    public void OptionSelected()
    {
        RestorePanels();
        if (buttonContentText.text == "Ambitious")
        {
            dialoguesInfoManager.canStartLuisAmbitiousDialogue = true;
            if(dialoguesInfoManager.luisDay1Phase1Finished == false)
            {
                dialoguesInfoManager.luisDay1Phase1Finished = true;
                luisCharacterSprite.SetActive(false);
                loadManager.luisDay1 = true;
                loadManager.Save();

            }
        }

        if (buttonContentText.text == "Perfectionist")
        {
            dialoguesInfoManager.canStartLuisPerfectionistDialogue = true;
            if (dialoguesInfoManager.luisDay1Phase1Finished == false)
            {
                dialoguesInfoManager.luisDay1Phase1Finished = true;
                luisCharacterSprite.SetActive(false);
                loadManager.luisDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Lure")
        {
            dialoguesInfoManager.canStartLuisLureDialogue = true;
            if (dialoguesInfoManager.luisDay1Phase1Finished == false)
            {
                dialoguesInfoManager.luisDay1Phase1Finished = true;
                luisCharacterSprite.SetActive(false);
                loadManager.luisDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Loner")
        {
            dialoguesInfoManager.canStartLuisLonerDialogue = true;
            if (dialoguesInfoManager.luisDay1Phase1Finished == false)
            {
                dialoguesInfoManager.luisDay1Phase1Finished = true;
                luisCharacterSprite.SetActive(false);
                loadManager.luisDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Assertive")
        {
            dialoguesInfoManager.canStartCarmenAssertiveDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                loadManager.carmenDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Materialistic")
        {
            dialoguesInfoManager.canStartCarmenMaterialisticDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                loadManager.carmenDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Independent")
        {
            dialoguesInfoManager.canStartCarmenMaterialisticDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                loadManager.carmenDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Entrepreneur")
        {
            dialoguesInfoManager.canStartCarmenEntrepreneurDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                loadManager.carmenDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Bookworm")
        {
            dialoguesInfoManager.canStartBrunoBookwormDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                loadManager.brunoDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Geek")
        {
            dialoguesInfoManager.canStartBrunoGeekDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                loadManager.brunoDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Genius")
        {
            dialoguesInfoManager.canStartBrunoGeniusDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                loadManager.brunoDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Loyal")
        {
            dialoguesInfoManager.canStartBrunoLoyalDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                loadManager.brunoDay1 = true;
                loadManager.Save();
            }
        }

        if(buttonContentText.text == "Childish")
        {
            dialoguesInfoManager.canStartMarinaChildishDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                loadManager.marinaDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Active")
        {
            dialoguesInfoManager.canStartMarinaActiveDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                CinematicPanel.SetActive(true);
                marinaActiveCinematic.canStartDialogue = false;
                marinaActiveCinematic.canTalk = true;
                /*
                loadManager.marinaDay1 = true;
                loadManager.Save();*/
            }
        }

        if (buttonContentText.text == "Romantic")
        {
            dialoguesInfoManager.canStartMarinaRomanticDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                loadManager.marinaDay1 = true;
                loadManager.Save();
            }
        }

        if (buttonContentText.text == "Good")
        {
            dialoguesInfoManager.canStartMarinaGoodDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                loadManager.marinaDay1 = true;
                loadManager.Save();
            }
        }
    }


    private void RestorePanels()
    {
        selectionPanel.SetActive(false);
        alchemyPanel.SetActive(false);
        lobbyPanel.SetActive(true);
    }
}
