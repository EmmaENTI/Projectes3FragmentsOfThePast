using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SavePlayerNameScript : MonoBehaviour
{
    public string playerNameToStorage;
    public TextMeshProUGUI inputFieldText;

    public void StorePlayerName()
    {
        playerNameToStorage = inputFieldText.text;
        
        PlayerPrefs.SetString("Player Name", playerNameToStorage);
    }
}
