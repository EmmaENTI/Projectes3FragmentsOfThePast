using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePlayerNameScript : MonoBehaviour
{
    public string playerNameToStorage;
    public Text inputFieldText;

    public void StorePlayerName()
    {
        playerNameToStorage = inputFieldText.text;
        
        PlayerPrefs.SetString("Player Name", playerNameToStorage);
    }
}
