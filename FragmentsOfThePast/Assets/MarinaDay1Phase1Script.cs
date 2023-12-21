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

            case 17:
                DialogueLine17();
                break;

            case 18:
                DialogueLine18();
                break;

            case 19:
                DialogueLine19();
                break;

            case 20:
                DialogueLine20();
                break;

            case 21:
                DialogueLine21();
                break;

            case 22:
                DialogueLine22();
                break;

            case 23:
                DialogueLine23();
                break;

            case 24:
                DialogueLine24();
                break;

            case 25:
                DialogueLine25();
                break;

            case 26:
                DialogueLine26();
                break;

            case 27:
                DialogueLine27();
                break;

            case 28:
                DialogueLine28();
                break;

            case 29:
                DialogueLine29();
                break;

            case 30:
                DialogueLine30();
                break;

            case 31:
                DialogueLine31();
                break;

            case 32:
                DialogueLine32();
                break;

            case 33:
                DialogueLine33();
                break;

            case 34:
                DialogueLine34();
                break;

            case 35:
                DialogueLine35();
                break;

            case 36:
                DialogueLine36();
                break;

            case 37:
                DialogueLine37();
                break;

            case 38:
                DialogueLine38();
                break;

            case 39:
                DialogueLine39();
                break;

            case 40:
                DialogueLine40();
                break;

            case 41:
                DialogueLine41();
                break;

            case 42:
                DialogueLine42();
                break;

            case 43:
                DialogueLine43();
                break;

            case 44:
                DialogueLine44();
                break;

            case 45:
                DialogueLine45();
                break;

            case 46:
                DialogueLine46();
                break;

            case 47:
                DialogueLine47();
                break;

            case 48:
                DialogueLine48();
                break;

            case 49:
                DialogueLine49();
                break;

            case 50:
                DialogueLine50();
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
        spiritNameText.text = gameManager_Script.playerName;
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
        bigSpiritImage.sprite = marinaHappy;
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
        texToToWrite = "Oh, come on! Dad jokes are a classic!";
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
        texToToWrite = "Gotta keep the spirits up, no pun intended...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine17()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "(Amused) Give me your best one!";
        button2AnswerText.text = "(Friendly) Seeing the quality of that one, I prefer not hearing more.";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine17Answer1()
    {
        if (dialogueLine == 17)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine17Answer2()
    {
        if (dialogueLine == 17)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 23;
            playSound1.playEffect();
        }
    }

    private void DialogueLine18()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Get ready, this one could even be traumatizing.";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }


    private void DialogueLine19()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Why don't oysters donate to charity?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine20()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "...";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine21()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Because they're shellfish!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine22()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I know, that one was a hard pill to swallow...";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine23()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Aw, thanks!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine24()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Your vibes are pretty good too, " + gameManager_Script.playerName;
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine25()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I'm just here to spread joy, you know?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine26()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, aren't you a smooth talker!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine27()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, um, maybe a bit of both?";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine28()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I can be bubbly for everyone, but for you, mystery guide, I can turn it up a notch.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine29()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Flirty) Lucky me, getting the bubbly version.";
        button2AnswerText.text = "(Friendly) Your positivity is contagious!";
        button3AnswerText.text = "(Amused) Shyness looks good on you!";
        playerIsAnswering = true;
    }

    public void DialogueLine29Answer1()
    {
        if (dialogueLine == 29)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine29Answer2()
    {
        if (dialogueLine == 29)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 33;
            playSound1.playEffect();
        }
    }

    public void DialogueLine29Answer3()
    {
        if (dialogueLine == 29)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 36;
            playSound1.playEffect();
        }
    }

    private void DialogueLine30()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Aww, thanks!";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine31()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "You're making me feel all fluttery inside, " + gameManager_Script.playerName;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine32()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "If my jokes don't make you smile, my blushing probably will!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine33()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Aww, thanks!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }


    private void DialogueLine34()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Your vibes are pretty good too, " + gameManager_Script.playerName;
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine35()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I'm just here to spread joy, you know?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine36()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Cute? Really?";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine37()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, if being a bit shy gets me some attention, I guess it's not so bad.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine38()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Thanks for the cute compliments, " + gameManager_Script.playerName;
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine39()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Serious business? Oh, you're no fun!";
        bigSpiritImage.sprite = marinaSad;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine40()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "But sure, let's get down to it. What do you want to know? I'm ready for the serious talk, " +gameManager_Script.playerName;
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine41()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Serious) Well, first I need to know a little about you...";
        button2AnswerText.text = "(Friendly) Being serious does not mean not fun!";
        button3AnswerText.text = "(Amused) Woah, you actually were serious for a second!";
        playerIsAnswering = true;
    }

    public void DialogueLine41Answer1()
    {
        if (dialogueLine == 41)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine41Answer2()
    {
        if (dialogueLine == 41)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 45;
            playSound1.playEffect();
        }
    }

    public void DialogueLine41Answer3()
    {
        if (dialogueLine == 41)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 48;
            playSound1.playEffect();
        }
    }

    private void DialogueLine42()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, about me? Well, let me think...";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine43()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Let me tell you, I might not remember much, but I know one thing for sure—I love laughing, having a good time, and....";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine44()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, the sea! There's something magical about the waves, don't you think?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine45()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "You're right! Serious can be fun too!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine46()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "It's just... well, serious situations make me a bit tense sometimes.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine47()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Maybe I am just too childish sometimes!";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine48()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Gotcha, didn't I?";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound1.playEffect();
    }

    private void DialogueLine49()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "But, you know, I can be serious when I need to... like, when it involves getting back my memories and stuff!";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine50()
    {
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I am excited to see how you work your magic stuff, " + gameManager_Script.playerName;
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
}
