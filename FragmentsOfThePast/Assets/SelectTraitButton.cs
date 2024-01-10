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
    //Marina script
    [SerializeField] MarinaActiveCinematicText marinaActiveCinematic;
    [SerializeField] MarinaChildishCinematicText marinaChidlishCinematic;
    [SerializeField] MarinaGoodCinematicText marinaGoodCinematic;
    [SerializeField] MarinaRomanticCinematicText marinaRomanticCinematic;

    //Bruno script
    [SerializeField] BrunoBookwormCinematicText brunoBookwormCinematic;
    [SerializeField] BrunoLoyalCinematicText brunoLoyalCinematic;
    [SerializeField] BrunoGeniusCinematicText brunoGeniusCinematic;
    [SerializeField] BrunoGeekCinematicText brunoGeekCinematic;

    //Carmen script
    [SerializeField] CarmenAssertiveCinematicText carmenAssertiveCinematic;
    [SerializeField] CarmenEntrepreneurCinematicText carmenEntrepreneurCinematic;
    [SerializeField] CarmenIndependentCinematicText carmenIndependentCinematic;
    [SerializeField] CarmenMaterialisticCinematicText carmenMaterialisticCinematic;

    //Luis script
    [SerializeField] LuisAmbitiousCinematicText luisAmbitiousCinematic;
    [SerializeField] LuisPerfectionistCinematicText luisPerfectionistCinematic;
    [SerializeField] LuisLonerCinematicText luisLonerCinematic;
    [SerializeField] LuisRomanticCinematicText luisRomanticCinematic;

    [SerializeField] private GameObject cinematicPanel;
    //Marina panel
    [SerializeField] private GameObject marinaActivePanel;
    [SerializeField] private GameObject marinaChildishPanel;
    [SerializeField] private GameObject marinaGoodPanel;
    [SerializeField] private GameObject marinaRomanitcPanel;

    //Bruno panel
    [SerializeField] private GameObject brunoLoyalPanel;
    [SerializeField] private GameObject brunoGeniusPanel;
    [SerializeField] private GameObject brunoBookwormPanel;
    [SerializeField] private GameObject brunoGeekPanel;

    //Carmen panel
    [SerializeField] private GameObject carmenAssertivePanel;
    [SerializeField] private GameObject carmenEntrepreneurPanel;
    [SerializeField] private GameObject carmenIndependentPanel;
    [SerializeField] private GameObject carmenMaterialisticPanel;

    //Luis panel
    [SerializeField] private GameObject luisAmbitousPanel;
    [SerializeField] private GameObject luisPerfectionistPanel;
    [SerializeField] private GameObject luisLonerPanel;
    [SerializeField] private GameObject luisRomanticPanel;

    [SerializeField] private GameManager_Script gameManager_Script;


    private void Update()
    {
        if(gameManager_Script.canStartDay2)
        {
            if(loadManager.luisDay1 && 
                loadManager.carmenDay1 &&
                loadManager.brunoDay1 &&
                loadManager.marinaDay1)
            {
                gameManager_Script.canStartDay2 = false;
                marinaCharacterSprite.SetActive(true);
                luisCharacterSprite.SetActive(true);
                carmenCharacterSprite.SetActive(true);
                brunoCharacterSprite.SetActive(true);
            }
        }
    }

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
                cinematicPanel.SetActive(true);
                luisAmbitousPanel.SetActive(true);
                luisAmbitiousCinematic.canStartDialogue = false;
                luisAmbitiousCinematic.canTalk = true;

            }
        }

        if (buttonContentText.text == "Perfectionist")
        {
            dialoguesInfoManager.canStartLuisPerfectionistDialogue = true;
            if (dialoguesInfoManager.luisDay1Phase1Finished == false)
            {
                dialoguesInfoManager.luisDay1Phase1Finished = true;
                luisCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                luisPerfectionistPanel.SetActive(true);
                luisPerfectionistCinematic.canStartDialogue = false;
                luisPerfectionistCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Lure")
        {
            dialoguesInfoManager.canStartLuisLureDialogue = true;
            if (dialoguesInfoManager.luisDay1Phase1Finished == false)
            {
                dialoguesInfoManager.luisDay1Phase1Finished = true;
                luisCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                luisRomanticPanel.SetActive(true);
                luisRomanticCinematic.canStartDialogue = false;
                luisRomanticCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Loner")
        {
            dialoguesInfoManager.canStartLuisLonerDialogue = true;
            if (dialoguesInfoManager.luisDay1Phase1Finished == false)
            {
                dialoguesInfoManager.luisDay1Phase1Finished = true;
                luisCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                luisLonerPanel.SetActive(true);
                luisLonerCinematic.canStartDialogue = false;
                luisLonerCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Assertive")
        {
            dialoguesInfoManager.canStartCarmenAssertiveDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                carmenAssertivePanel.SetActive(true);
                carmenAssertiveCinematic.canStartDialogue = false;
                carmenAssertiveCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Materialistic")
        {
            dialoguesInfoManager.canStartCarmenMaterialisticDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                carmenMaterialisticPanel.SetActive(true);
                carmenMaterialisticCinematic.canStartDialogue = false;
                carmenMaterialisticCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Independent")
        {
            dialoguesInfoManager.canStartCarmenMaterialisticDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                carmenIndependentPanel.SetActive(true);
                carmenIndependentCinematic.canStartDialogue = false;
                carmenIndependentCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Entrepreneur")
        {
            dialoguesInfoManager.canStartCarmenEntrepreneurDialogue = true;
            if (dialoguesInfoManager.carmenDay1Phase1Finished == false)
            {
                dialoguesInfoManager.carmenDay1Phase1Finished = true;
                carmenCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                carmenEntrepreneurPanel.SetActive(true);
                carmenEntrepreneurCinematic.canStartDialogue = false;
                carmenEntrepreneurCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Bookworm")
        {
            dialoguesInfoManager.canStartBrunoBookwormDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                brunoBookwormPanel.SetActive(true);
                brunoBookwormCinematic.canStartDialogue = false;
                brunoBookwormCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Geek")
        {
            dialoguesInfoManager.canStartBrunoGeekDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                brunoGeekPanel.SetActive(true);
                brunoGeekCinematic.canStartDialogue = false;
                brunoGeekCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Genius")
        {
            dialoguesInfoManager.canStartBrunoGeniusDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                brunoGeniusPanel.SetActive(true);
                brunoGeniusCinematic.canStartDialogue = false;
                brunoGeniusCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Loyal")
        {
            dialoguesInfoManager.canStartBrunoLoyalDialogue = true;
            if (dialoguesInfoManager.brunoDay1Phase1Finished == false)
            {
                dialoguesInfoManager.brunoDay1Phase1Finished = true;
                brunoCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                brunoLoyalPanel.SetActive(true);
                brunoLoyalCinematic.canStartDialogue = false;
                brunoLoyalCinematic.canTalk = true;
            }
        }

        if(buttonContentText.text == "Childish")
        {
            dialoguesInfoManager.canStartMarinaChildishDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                marinaChildishPanel.SetActive(true);
                marinaChidlishCinematic.canStartDialogue = false;
                marinaChidlishCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Active")
        {
            dialoguesInfoManager.canStartMarinaActiveDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                marinaActivePanel.SetActive(true);
                marinaActiveCinematic.canStartDialogue = false;
                marinaActiveCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Romantic")
        {
            dialoguesInfoManager.canStartMarinaRomanticDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                marinaRomanitcPanel.SetActive(true);
                marinaRomanticCinematic.canStartDialogue = false;
                marinaRomanticCinematic.canTalk = true;
            }
        }

        if (buttonContentText.text == "Good")
        {
            dialoguesInfoManager.canStartMarinaGoodDialogue = true;
            if (dialoguesInfoManager.marinaDay1Phase1Finished == false)
            {
                dialoguesInfoManager.marinaDay1Phase1Finished = true;
                marinaCharacterSprite.SetActive(false);
                cinematicPanel.SetActive(true);
                marinaGoodPanel.SetActive(true);
                marinaGoodCinematic.canStartDialogue = false;
                marinaGoodCinematic.canTalk = true;
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
