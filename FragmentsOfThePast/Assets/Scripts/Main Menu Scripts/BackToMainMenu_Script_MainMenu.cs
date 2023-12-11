using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackToMainMenu_Script_MainMenu : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator animator2;
    [SerializeField] GameObject mainMenuPanel;
    [SerializeField] GameObject creditsPanel;
    [SerializeField] GameObject optionsPanel;

    public void BackToMainMenu()
    {
        mainMenuPanel.SetActive(true);
        creditsPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }

    public void BackToMainMenuAnimPointerEnter()
    {
        animator.SetBool("canPlayAnim", true);
        animator2.SetBool("canPlayAnim", true);
    }

    public void BackToMainMenuAnimPointerExit()
    {
        animator.SetBool("canPlayAnim", false);
        animator2.SetBool("canPlayAnim", false);
    }
}
