using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame_Script_MainMenu : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject playerNamePanel;
    [SerializeField] SavePlayerNameScript savePlayerNameScript;
    
    [SerializeField] AudioSource soundManagerAudioSource;

    [SerializeField] Animator messageAnimator;
    [SerializeField] bool firstMessage =true;

    [SerializeField] LoadManager loadManager;

    public void StartButton()
    { 
        playerNamePanel.SetActive(true);
    }

    public void StartGame()
    {
        savePlayerNameScript.StorePlayerName();

        loadManager.loadGame = false;

        PlayerPrefs.SetInt("loadManager.loadGame", loadManager.loadGame ? 1 : 0);

        loadManager.loadGame = PlayerPrefs.GetInt("loadManager.loadGame") == 0 ? true : false;

        if (savePlayerNameScript.playerNameToStorage.Length <10)
        {
            soundManagerAudioSource.enabled = false;
            SceneManager.LoadScene("GameScene");
        }

        else
        {
            if (!messageAnimator.GetBool("canPlayAnim") && !messageAnimator.GetBool("canPlayAnim")&& firstMessage)
            {
                messageAnimator.SetBool("canPlayAnim", true);
                firstMessage = false;
                UnityEngine.Debug.Log("First");
            }

            else if (messageAnimator.GetBool("canPlayAnim"))
            {
                messageAnimator.SetBool("canPlayAnim", false);
                messageAnimator.SetBool("canPlayAnim2", true);

            }

            else if (messageAnimator.GetBool("canPlayAnim2"))
            {
                messageAnimator.SetBool("canPlayAnim2", false);
                messageAnimator.SetBool("canPlayAnim", true);

            }
        }
    }

    public void LoadGame()
    {
        soundManagerAudioSource.enabled = false;
        SceneManager.LoadScene("GameScene");
        loadManager.loadGame = true;
        PlayerPrefs.SetInt("loadManager.loadGame", loadManager.loadGame ? 1 : 0);
    }

    public void StartGameAnimPointerEnter()
    {
        animator.SetBool("canPlayAnim", true);
    }

    public void StartGameAnimPointerExit()
    {
        animator.SetBool("canPlayAnim", false);
    }
}
