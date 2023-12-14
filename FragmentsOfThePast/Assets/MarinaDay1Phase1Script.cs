using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MarinaDay1Phase1Script : MonoBehaviour
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

    //Dialogue Text Panel
    [SerializeField] GameObject dialogueTextPanel;

    //Dialogue Text (Contenido del dialogo)
    [SerializeField] TextMeshProUGUI dialogueText;

    //Sound 0
    [SerializeField] PlaySound playSound;

    //Sound 1
    [SerializeField] PlaySound playSound1;

    //Texto para
    [SerializeField] string texToToWrite;

    //Spirit Name Text
    [SerializeField] TextMeshProUGUI spiritNameText;

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

    //Background del text panel
    [SerializeField] Image textPanelImage;

    //Sprite de Normal Text Panel
    [SerializeField] Sprite TextPanelNormalSprite;

    //Spirit Image
    public Image bigSpiritImage;

    //Luis Emotions
    public Sprite marinaSurprise;
    public Sprite marinaSad;
    public Sprite marinaAngry;
    public Sprite marinaShy;
    public Sprite marinaHappy;

    //Sound 2
    [SerializeField] PlaySound playSound2;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canStartDialogue == false && playerIsAnswering == false)
            {
                dialogueTextPanel.SetActive(true);
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

            case 7:
                DialogueLine7();
                break;

            case 8:
                DialogueLine8();
                break;

            case 9:
                DialogueLine9();
                break;

            case 10:
                DialogueLine10();
                break;

            case 11:
                DialogueLine11();
                break;

            case 12:
                DialogueLine12();
                break;

            case 13:
                DialogueLine13();
                break;

            case 14:
                DialogueLine14();
                break;

            case 15:
                DialogueLine15();
                break;

            case 16:
                DialogueLine16();
                break;
        }
    }

    void LineJump()
    {
        Debug.Log("Jump");
        switch (dialogueLine)
        {
            default:
                break;

        }
    }

    private void DialogueLine0()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine1()
    {
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "You are Marina, if I recall correctly.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        hasEndedTyping = false;
        playSound2.playEffect();
        spiritNameText.text = "Marina";
        texToToWrite = "Oh, you do recall! You've got a good memory, huh?";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine3()
    {
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        texToToWrite = "Well, not that I have much to remember lately, but that's what you're here for, right?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Yeah! Here to help!";
        button2AnswerText.text = "(Flirty) Are you always this bubbly, or is it just for me?";
        button3AnswerText.text = "(Serious) Let's get down to business, Marina.";
        playerIsAnswering = true;
    }

    public void DialogueLine4Answer1()
    {
        if (dialogueLine == 4)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine4Answer2()
    {
        if (dialogueLine == 4)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 26;
            playSound1.playEffect();
        }
    }

    public void DialogueLine4Answer3()
    {
        if (dialogueLine == 4)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 39;
            playSound1.playEffect();
        }
    }

    private void DialogueLine5()
    {
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        texToToWrite = "Yay! I'm thrilled to have a guide like you!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine6()
    {
        hasEndedTyping = false;
        texToToWrite = "It's like having a personal memory detective.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine7()
    {
        hasEndedTyping = false;
        texToToWrite = "We'll make a great team, and I promise, I've got the best jokes to keep us entertained along the way.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine8()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Serious) Oh no, please spare me from the dad-jokes, Marina. I'm allergic to puns.";
        button2AnswerText.text = "(Friendly) You could say I am kind of a detective...";
        button3AnswerText.text = "(Amused) What kind of jokes?";
        playerIsAnswering = true;
    }


    public void DialogueLine8Answer1()
    {
        if (dialogueLine == 8)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine8Answer2()
    {
        if (dialogueLine == 8)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 12;
            playSound1.playEffect();
        }
    }

    public void DialogueLine8Answer3()
    {
        if (dialogueLine == 8)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 15;
            playSound1.playEffect();
        }
    }

    private void DialogueLine9()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "We'll make a great team, and I promise, I've got the best jokes to keep us entertained along the way.";
        bigSpiritImage.sprite = marinaAngry;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine10()
    {
        hasEndedTyping = false;
        texToToWrite = "But don't worry, I won't pester you with my bad jokes.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine11()
    {
        hasEndedTyping = false;
        texToToWrite = "Or maybe I will...?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine12()
    {
        hasEndedTyping = false;
        texToToWrite = "You will be the cool mysterious detective...";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine13()
    {
        hasEndedTyping = false;
        texToToWrite = "And I will be the pretty but intelligent girl protagonist!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine14()
    {
        hasEndedTyping = false;
        texToToWrite = "I always wanted to be the protagonist of a \"Novela\"!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine15()
    {
        hasEndedTyping = false;
        texToToWrite = "Oh, you know, the kind that makes you groan and laugh at the same time! Dad jokes, puns...";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine16()
    {
        hasEndedTyping = false;
        texToToWrite = "    Gotta keep the spirits up, no pun intended...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }




}
