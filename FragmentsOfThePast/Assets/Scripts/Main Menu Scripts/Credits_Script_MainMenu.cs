using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits_Script_MainMenu : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject mainMenuPanel;
    [SerializeField] GameObject creditsPanel;

    public void OpenCredits()
    {
       // mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void CreditsAnimPointerEnter()
    {
        animator.SetBool("canPlayAnim", true);
    }

    public void CreditsMenuAnimPointerExit()
    {
        animator.SetBool("canPlayAnim", false);
    }
}
