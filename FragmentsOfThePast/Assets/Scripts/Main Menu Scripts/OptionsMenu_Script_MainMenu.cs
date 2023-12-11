using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OptionsMenu_Script_MainMenu : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject mainMenuPanel;
    [SerializeField] GameObject optionsPanel;
    public void OpenOptionsPanel()
    {
        // mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void OptionsMenuAnimPointerEnter()
    {
        animator.SetBool("canPlayAnim", true);
    }

    public void OptionsMenuAnimPointerExit()
    {
        animator.SetBool("canPlayAnim", false);
    }
}
