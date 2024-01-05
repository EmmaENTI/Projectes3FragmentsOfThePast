using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;
using UnityEngine.Windows;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    public bool introFinished;
    public bool prologueFinished;


    //public InputField Content;

    public void Save()
    {
        QuickSaveWriter.Create("SavePoints")
                       .Write<bool>("SavePoint1", introFinished)
                       .Write<bool>("SavePoint2", prologueFinished)
                       .Commit();
     
        //Content.text = QuickSaveRaw.LoadString("Inputs.json");

        Debug.Log("SAVED");
    }

    public void Load()
    {
        QuickSaveReader.Create("SavePoints")
                       .Read<bool>("SavePoint1", (r) => { introFinished = r; })
                       .Read<bool>("SavePoint2", (r) => { prologueFinished = r; });

        Debug.Log("LOADED");
    }
}
