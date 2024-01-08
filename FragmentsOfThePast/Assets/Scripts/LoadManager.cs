using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;
using UnityEngine.Windows;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    // Prologue
    public bool introFinished;
    public bool prologueFinished;

    //Day 1
    public bool luisDay1;
    public bool marinaDay1;
    public bool brunoDay1;
    public bool carmenDay1;

    public bool loadGame;
    [SerializeField] Animator animator;


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

    public void LoadGameAnimPointerEnter()
    {
        animator.SetBool("canPlayAnim", true);
    }

    public void LoadGameAnimPointerExit()
    {
        animator.SetBool("canPlayAnim", false);
    }
}
