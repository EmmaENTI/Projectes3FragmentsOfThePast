using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MarinaRomanticCinematicText : MonoBehaviour
{
    //Game Manager
    [SerializeField] GameManager_Script gameManager_Script;

    //Bool canStartDialogue
    public bool canStartDialogue;

    //Bool canTalk
    public bool canTalk;

    //Bool playerisAnswering
    public bool playerIsAnswering;

    //Bool hasEndedTyping
    [SerializeField] bool hasEndedTyping;

    //Dialogue Line (Contador de lineas de dialogo)
    public int dialogueLine;

    [SerializeField] GameObject textContender;

    //Dialogue Text (Contenido del dialogo)
    [SerializeField] TextMeshProUGUI dialogueText;

    //Sound 0
    [SerializeField] PlaySound playSound;

    //Sound 1
    [SerializeField] PlaySound playSound1;

    //Texto para
    [SerializeField] string texToToWrite;

    //Panel amb els 3 buttons de respostes
    [SerializeField] GameObject answerButtonsPanel;

    //Segon button de resposta
    [SerializeField] GameObject middleButtonPanel;

    //Primer button de resposta
    [SerializeField] GameObject leftButtonPanel;

    //Tercer button de repossta
    [SerializeField] GameObject rightButtonPanel;

    //Text de la primera resposta
    [SerializeField] TextMeshProUGUI button1AnswerText;

    //Text de la segona resposta
    [SerializeField] TextMeshProUGUI button2AnswerText;

    //Text de la tercera repsosta
    [SerializeField] TextMeshProUGUI button3AnswerText;

    //Sprite de Normal Text Panel
    [SerializeField] Sprite TextPanelNormalSprite;

    //Sprite de Luis Text Panel
    [SerializeField] Sprite TextPanelMarinaSprite;

    //Spirit Image
    public Image bigSpiritImage;

    //Luis Emotions
    public Sprite marinaSurprise;
    public Sprite marinaSad;
    public Sprite marinaAngry;
    public Sprite marinaShy;
    public Sprite marinaHappy;

    [SerializeField] private GameObject CinematicPanel;

    [SerializeField] private GameObject selfPanel;

    //Sound 2
    [SerializeField] PlaySound playSound2;

    [SerializeField] LoadManager loadManager;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canStartDialogue == false && playerIsAnswering == false)
            {
                textContender.SetActive(true);
                if (hasEndedTyping)
                {
                    dialogueLine++;
                    LineJump();
                    canTalk = true;
                }

                if (hasEndedTyping == false)
                {
                    hasEndedTyping = true;
                }
            }
        }

        if (canTalk)
        {
            DialogueTalk();
        }
    }


    IEnumerator TypeText(string textContent)
    {
        for (int printIndex = 0; printIndex <= textContent.Length; ++printIndex)
        {
            if (printIndex == textContent.Length)
            {
                hasEndedTyping = true;
            }

            if (hasEndedTyping == true)
            {
                dialogueText.text = textContent;
            }

            if (hasEndedTyping == false)
            {
                dialogueText.text = textContent.Substring(0, printIndex);
                if (printIndex % 3 == 0 && textContent.Substring(0, printIndex) != "")
                {
                    playSound.playEffect();
                }

                yield return new WaitForSeconds(0.04f);
            }
        }
    }

    private void DialogueTalk()
    {
        switch (dialogueLine)
        {
            default:
                break;

            case 0:
                DialogueLine0();
                break;

            case 1:
                DialogueLine1();
                break;

            case 2:
                DialogueLine2();
                break;


            case 3:
                DialogueLine3();
                break;

            case 4:
                DialogueLine4();
                break;

            case 5:
                DialogueLine5();
                break;

            case 6:
                DialogueLine6();
                break;
        }
    }

    void LineJump()
    {
        switch (dialogueLine)
        {
            default:
                break;
        }
    }

    private void DialogueLine0()
    {
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine1()
    {
        hasEndedTyping = false;
        texToToWrite = "Marina loved love. She'd fall for someone fast, but sometimes, she'd fall out of love just as quickly.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        hasEndedTyping = false;
        texToToWrite = "She was searching for that fairy tale romance, where everything is perfect and magical.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine3()
    {
        hasEndedTyping = false;
        texToToWrite = "Well, that feeling is... Exciting! And also kind of dangerous.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4()
    {
        hasEndedTyping = false;
        texToToWrite = "Falling in love and then falling out of love so quickly sounds draining.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine5()
    {
        hasEndedTyping = false;
        texToToWrite = "Marina was a hopeless romantic, then!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine6()
    {
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        CinematicPanel.SetActive(false);
        selfPanel.SetActive(false);

        loadManager.marinaDay1 = true;
        loadManager.Save();
    }
}