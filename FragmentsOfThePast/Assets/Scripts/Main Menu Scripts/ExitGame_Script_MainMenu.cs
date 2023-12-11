using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitGame_Script_MainMenu : MonoBehaviour
{
    [SerializeField] Animator animator;
    public void ExitGame()
    {
        Application.Quit();
    }

    public void ExitGameAnimPointerEnter()
    {
        animator.SetBool("canPlayAnim", true);
    }

    public void ExitGameAnimPointerExit()
    {
        animator.SetBool("canPlayAnim", false);
    }
}
