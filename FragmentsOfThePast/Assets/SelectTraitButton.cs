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

    public void OptionSelected()
    {
        RestorePanels();
        if (buttonContentText.text == "Ambitious")
        {
            dialoguesInfoManager.canStartLuisAmbitiousDialogue = true;
        }

        if (buttonContentText.text == "Perfectionist")
        {
            dialoguesInfoManager.canStartLuisPerfectionistDialogue = true;
        }

        if (buttonContentText.text == "Lure")
        {
            dialoguesInfoManager.canStartLuisLureDialogue = true;
        }

        if (buttonContentText.text == "Loner")
        {
            dialoguesInfoManager.canStartLuisLonerDialogue = true;
        }

        if (buttonContentText.text == "Assertive")
        {
            dialoguesInfoManager.canStartCarmenAssertiveDialogue = true;
        }

        if (buttonContentText.text == "Materialistic")
        {
            dialoguesInfoManager.canStartCarmenMaterialisticDialogue = true;
        }

        if (buttonContentText.text == "Independent")
        {
            dialoguesInfoManager.canStartCarmenMaterialisticDialogue = true;
        }

        if (buttonContentText.text == "Entrepreneur")
        {
            dialoguesInfoManager.canStartCarmenEntrepreneurDialogue = true;
        }

        if (buttonContentText.text == "Bookworm")
        {
            dialoguesInfoManager.canStartBrunoBookwormDialogue = true;
        }

        if (buttonContentText.text == "Geek")
        {
            dialoguesInfoManager.canStartBrunoGeekDialogue = true;
        }

        if (buttonContentText.text == "Genius")
        {
            dialoguesInfoManager.canStartBrunoGeniusDialogue = true;
        }

        if (buttonContentText.text == "Loyal")
        {
            dialoguesInfoManager.canStartBrunoLoyalDialogue = true;
        }

    }


    private void RestorePanels()
    {
        selectionPanel.SetActive(false);
        alchemyPanel.SetActive(false);
        lobbyPanel.SetActive(true);
    }
}
