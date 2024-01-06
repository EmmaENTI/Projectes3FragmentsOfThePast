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
            Debug.Log("Debug");
            dialoguesInfoManager.canStartLuisAmbitiousDialogue = true;
        }
    }

    private void RestorePanels()
    {
        selectionPanel.SetActive(false);
        alchemyPanel.SetActive(false);
        lobbyPanel.SetActive(true);
    }
}
