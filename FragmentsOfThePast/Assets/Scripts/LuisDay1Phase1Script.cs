using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LuisDay1Phase1Script : MonoBehaviour
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

    //Sprite de Luis Text Panel
    [SerializeField] Sprite TextPanelLuisSprite;

    //Spirit Image
    public Image bigSpiritImage;

    //Luis Emotions
    public Sprite luisSuprise;
    public Sprite luisSad;
    public Sprite luisAngry;
    public Sprite luisShy;
    public Sprite luisHappy;

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

            case 51:
                DialogueLine51();
                break;

            case 52:
                DialogueLine52();
                break;

            case 53:
                DialogueLine53();
                break;

            case 54:
                DialogueLine54();
                break;

            case 55:
                DialogueLine55();
                break;

            case 56:
                DialogueLine56();
                break;

            case 57:
                DialogueLine57();
                break;

            case 58:
                DialogueLine58();
                break;

            case 59:
                DialogueLine59();
                break;

            case 60:
                DialogueLine60();
                break;

            case 61:
                DialogueLine61();
                break;

            case 62:
                DialogueLine62();
                break;

            case 63:
                DialogueLine63();
                break;

            case 64:
                DialogueLine64();
                break;

            case 65:
                DialogueLine65();
                break;

            case 66:
                DialogueLine66();
                break;

            case 67:
                DialogueLine67();
                break;

            case 68:
                DialogueLine68();
                break;

            case 69:
                DialogueLine69();
                break;

            case 70:
                DialogueLine70();
                break;

            case 71:
                DialogueLine71();
                break;

            case 72:
                DialogueLine72();
                break;

            case 73:
                DialogueLine73();
                break;

            case 74:
                DialogueLine74();
                break;

            case 75:
                DialogueLine75();
                break;

            case 76:
                DialogueLine76();
                break;

            case 77:
                DialogueLine77();
                break;

            case 78:
                DialogueLine78();
                break;

            case 79:
                DialogueLine79();
                break;

            case 80:
                DialogueLine80();
                break;

            case 81:
                DialogueLine81();
                break;

            case 82:
                DialogueLine82();
                break;

            case 83:
                DialogueLine83();
                break;

            case 84:
                DialogueLine84();
                break;

            case 85:
                DialogueLine85();
                break;

            case 86:
                DialogueLine86();
                break;

            case 87:
                DialogueLine87();
                break;

            case 88:
                DialogueLine88();
                break;

            case 89:
                DialogueLine89();
                break;

            case 90:
                DialogueLine90();
                break;

            case 91:
                DialogueLine91();
                break;

            case 92:
                DialogueLine92();
                break;

            case 93:
                DialogueLine93();
                break;

            case 94:
                DialogueLine94();
                break;

            case 95:
                DialogueLine95();
                break;

            case 96:
                DialogueLine96();
                break;

            case 97:
                DialogueLine97();
                break;

            case 98:
                DialogueLine98();
                break;

            case 99:
                DialogueLine99();
                break;

            case 100:
                DialogueLine100();
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

            case 13: 
                dialogueLine = 51;
                break;

            case 16:
                dialogueLine = 51;
                break;

            case 18:
                dialogueLine = 51;
                break;

            case 25:
                dialogueLine = 51;
                break;

            case 32:
                dialogueLine = 51;
                break;

            case 35:
                dialogueLine = 51;
                break;

            case 38:
                dialogueLine = 51;
                break;

            case 45:
                dialogueLine = 51;
                break;

            case 48:
                dialogueLine = 51;
                break;

            case 51:
                dialogueLine = 51;
                break;

            case 63:
                dialogueLine = 67;
                break;

            case 65:
                dialogueLine = 69;
                break;

            case 67:
                dialogueLine = 72;
                break;

            case 69:
                dialogueLine = 75;
                break;

            case 72:
                dialogueLine = 75;
                break;

            case 75:
                dialogueLine = 75;
                break;

            case 78:
                dialogueLine = 82;
                break;

            case 80:
                dialogueLine = 85;
                break;

            case 82:
                dialogueLine = 88;
                break;

            case 85:
                dialogueLine = 92;
                break;

            case 88:
                dialogueLine = 92;
                break;

            case 92:
                dialogueLine = 92;
                break;

            case 107:
                dialogueLine = 109;
                break;

            case 116:
                dialogueLine = 130;
                break;

            case 119:
                dialogueLine = 130;
                break;

            case 122:
                dialogueLine = 130;
                break;

            case 125:
                dialogueLine = 130;
                break;

            case 128:
                dialogueLine = 130;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "Luis, right? Can you tell me a bit about yourself?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisSuprise;
        texToToWrite = "Well, hello there, living friend! Or should I say, the mysterious spirit guide who's caught my attention...?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine3()
    {
        hasEndedTyping = false;
        texToToWrite = "Luis at your service. If I had known the afterlife came with a charming host, I might have kicked the bucket sooner.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "How's the afterlife treating you, sweetheart?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine5()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Flirty) Afterlife is a lot better now that you're here.";
        button2AnswerText.text = "(Witty) How's it treating you?";
        button3AnswerText.text = "(Friendly) As good as possible! And how do you feel?";
        playerIsAnswering = true;
    }

    public void DialogueLine5Answer1()
    {
        if (dialogueLine == 5)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine5Answer2()
    {
        if (dialogueLine == 5)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 18;
            playSound1.playEffect();
        }
    }

    public void DialogueLine5Answer3()
    {
        if (dialogueLine == 5)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 38;
            playSound1.playEffect();
        }
    }

    private void DialogueLine6()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        texToToWrite = "Sweet talk already? I like it! Keep it coming, and maybe we'll make the afterlife even more interesting.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine7()
    {
        hasEndedTyping = false;
        texToToWrite = "By interesting, I mean actually having some purpose...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine8()
    {

        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "Afterlife is pretty damn boring, parties around here are...Pretty dead. Get it?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine9()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Flirty) Maybe when this is all finished, we could make our own party.";
        button2AnswerText.text = "(Friendly) Oh, I would have thought it would be otherwise?";
        button3AnswerText.text = "(Unamused) That pun was so bad!";
        playerIsAnswering = true;
    }

    public void DialogueLine9Answer1()
    {
        if (dialogueLine == 9)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine9Answer2()
    {
        if (dialogueLine == 9)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 13;
            playSound1.playEffect();
        }
    }

    public void DialogueLine9Answer3()
    {
        if (dialogueLine == 9)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 16;
            playSound1.playEffect();
        }
    }

    private void DialogueLine10()
    {
        hasEndedTyping = false;
        texToToWrite = "Well, aren't you a breath of fresh air in this afterlife mystery? No time to waste, huh?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine11()
    {
        hasEndedTyping = false;
        texToToWrite = "I like that. When this whole memory-retrieving gig is wrapped up, I'm all in for making the afterlife parties more interesting...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine12()
    {
        hasEndedTyping = false;
        texToToWrite = "Especially with someone as intriguing as you. Count on it, mystery guide.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine13()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "You'd think, right? But no, it's all so predictable. Same old spirits, same old stories...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine14()
    {
        bigSpiritImage.sprite = luisSad;
        hasEndedTyping = false;
        texToToWrite = "Parties in the afaterlife are like a deck of cards without any aces.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine15()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "That's until you showed up, mystery guide. Now, maybe, just maybe, we can add a joker to this deck and shake things up a bit.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine16()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "Ah, come on! You've got to admit, even in the afterlife, a good pun can bring some life to the party.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine17()
    {
        hasEndedTyping = false;
        texToToWrite = "Well, metaphorical life, at least. What's the fun in a party without a few groans and eye rolls, right?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine18()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "Oh, you've got a wit to match mine, I see.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine19()
    {
        hasEndedTyping = false;
        texToToWrite = "Death's treating me like a mystery, but with you around, it's at least a fresh mystery...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine20()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "\"Chisme\" is limited in the afterlife, you are a free source of it!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine21()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Come on, I am not that interesting!";
        button2AnswerText.text = "(Witty) Well, Luis, if 'Chisme' is what you want, my life has plenty of that...";
        button3AnswerText.text = "(Angry) Look, I don't want to be no one's \"Chisme\"";
        playerIsAnswering = true;
    }

    public void DialogueLine21Answer1()
    {
        if (dialogueLine == 21)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine21Answer2()
    {
        if (dialogueLine == 21)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 25;
            playSound1.playEffect();
        }
    }

    public void DialogueLine21Answer3()
    {
        if (dialogueLine == 21)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 35;
            playSound1.playEffect();
        }
    }

    private void DialogueLine22()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "Oh," + gameManager_Script.playerName+ ", don't sell yourself short.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine23()
    {
        hasEndedTyping = false;
        texToToWrite = "I've got a feeling there's more to you than meets the eye.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine24()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "You got something special... Apart from the whole \"I am alive in the dead realm and summoned by God to fix all this mess\"...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine25()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "Plenty of 'Chisme,' you say? Now, you've piqued my interest.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine26()
    {
        hasEndedTyping = false;
        texToToWrite = "Spill the tea, my friend!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine27()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "What's the juiciest story you've got?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine28()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "(Tell him your most juicy story)";
        button2AnswerText.text = "(Stay silent and shrug, you are not telling anything)";
        playerIsAnswering = true;
    }

    public void DialogueLine28Answer1()
    {
        if (dialogueLine == 28)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine28Answer2()
    {
        if (dialogueLine == 28)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 32;
            playSound1.playEffect();
        }
    }



    private void DialogueLine29()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "Now, that's what I'm talking about!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine30()
    {
        hasEndedTyping = false;
        texToToWrite = "A story with flair and unexpected turns... " + gameManager_Script.playerName+ ", this \"Chisme\" made my day better!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine31()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "Bravo, spirit guide, you've got a talent for storytelling.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine32()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "Playing hard to get, huh? I like it.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine33()
    {
        hasEndedTyping = false;
        texToToWrite = "The silent type, the one with the mysterious smile.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine34()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "You're keeping me on my toes, " + gameManager_Script.playerName+".";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine35()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "No \"Chisme\" fan, I see.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine36()
    {
        hasEndedTyping = false;
        texToToWrite = "Fair enough, " + gameManager_Script.playerName+".";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine37()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "We'll stick to the essentials, and if you ever change your mind, I'll be here with an open ear.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine38()
    {
        bigSpiritImage.sprite = luisSad;
        hasEndedTyping = false;
        texToToWrite = "Feeling? Well, I'm feeling like I've been dealt a hand I didn't sign up for...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine39()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "But hey, that's life... or should I say, death?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine40()
    {
        hasEndedTyping = false;
        texToToWrite = "Death's a gamble, after all, might as well enjoy the ride!";
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
        button1AnswerText.text = "(Friendly) Well Luis, I am here to make it better!";
        button2AnswerText.text = "(Witty) That has to be one of the worst puns I've heard.";
        button3AnswerText.text = "(Inquire) Any reason to feel bad, apart from lost memories?";
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
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "Make it better, huh? So cute, really.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine43()
    {
        hasEndedTyping = false;
        texToToWrite = "I like your style, "+ gameManager_Script.playerName+".";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine44()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "Let's turn this hand into a winning one together!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine45()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "Worst pun? Ouch! I'll give you that one, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine46()
    {
        hasEndedTyping = false;
        texToToWrite = "But admit it, you chuckled a bit. Life... or death... can't resist a good pun. But...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine47()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "I guess I'll have to up my pun game to keep up with you.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine48()
    {
        bigSpiritImage.sprite = luisSuprise;
        hasEndedTyping = false;
        texToToWrite = "Apart from lost memories? You've got a knack for getting to the heart of things.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine49()
    {
        bigSpiritImage.sprite = luisSad;
        hasEndedTyping = false;
        texToToWrite = "Well, there's the whole being dead thing and... Let's just say I've got my reasons, but I'm not one to dwell.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine50()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "Onward to more interesting discussions, perhaps?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine51()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Well, let's get to the important part, shall we?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();    
    }

    private void DialogueLine52()
    {
        bigSpiritImage.sprite = luisSuprise;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Important part, you say? I'm all ears, " + gameManager_Script.playerName;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine53()
    {
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Lay it on me, and let's see if we can spice up this conversation even more.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine54()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Let's start by talking about any fragments of memories you might have!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine55()
    {
        hasEndedTyping = false;
        texToToWrite = "I will ask you different questions, and while I ask, you should try to really concentrate on smells, sounds, feelings that you may remember...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine56()
    {
        hasEndedTyping = false;
        texToToWrite = "This will allow me to understand you better, and that way, I will combine fragment orbs to create a memory essence orb.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine57()
    {
        bigSpiritImage.sprite = luisHappy;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Concentrate on smells, sounds, and feelings, huh?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine58()
    {
        hasEndedTyping = false;
        texToToWrite = "You sound like those ASMR Youtube videos, "+ gameManager_Script.playerName;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine59()
    {
        hasEndedTyping = false;
        texToToWrite = "But I ain't complaining! Hit me with your questions, and let's see if we can stir up some fragments in this old head of mine.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine60()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask him about Slob, Lazy, and Geek traits)";
        button2AnswerText.text = "(Ask him about Genius, Bookworm and Ambitious traits)";
        button3AnswerText.text = "(Ask him about Goofball, Creative, and Outgoing traits)";
        playerIsAnswering = true;
    }

    public void DialogueLine60Answer1()
    {
        if (dialogueLine == 60)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine ++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine60Answer2()
    {
        if (dialogueLine == 60)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 63;
            playSound1.playEffect();
        }
    }

    public void DialogueLine60Answer3()
    {
        if (dialogueLine == 60)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true; 
            dialogueLine = 65;
            playSound1.playEffect();
        }
    }

    private void DialogueLine61()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Luis, did you ever find yourself surrounded by messy spaces, having a penchant for laziness...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine62()
    {
        hasEndedTyping = false;
        texToToWrite = "And perhaps indulging in geeky interests like gaming or tech gadgets?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine63()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Did you have a penchant for knowledge and intellect, Luis?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine64()
    {
        hasEndedTyping = false;
        texToToWrite = "Were you the type to bury yourself in books, always seeking to expand your mind and achieve ambitious goals?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine65()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Luis, were you the goofball who could turn any situation into a joke, the creative mind who found joy in thinking outside the box...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine66()
    {
        hasEndedTyping = false;
        texToToWrite = "And the outgoing soul who never shied away from making new connections?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine67()
    {
        bigSpiritImage.sprite = luisSad;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Messy spaces, laziness, and geeky pursuits? Now that's a combination that doesn't quite fit the bill.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine68()
    {
        hasEndedTyping = false;
        texToToWrite = "I can't picture myself being a slob or lazy, but the geeky side? I'm not ruling it out entirely, but it feels a bit off. Maybe my memory is playing tricks on me...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine69()
    {
        bigSpiritImage.sprite = luisHappy;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Knowledge and intellect, huh?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine70()
    {
        hasEndedTyping = false;
        texToToWrite = "Well, I can't say I remember diving into books, but the idea of ambitious goals? That rings a bell.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine71()
    {
        hasEndedTyping = false;
        texToToWrite = "I must have been up to something big.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine72()
    {
        bigSpiritImage.sprite = luisSuprise;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = gameManager_Script.playerName+ ", you've hit the nail on the head!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine73()
    {
        hasEndedTyping = false;
        texToToWrite = "I might not remember the specifics, but being the one who brings laughter, thinks creatively, and never turns down a chance to connect?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine74()
    {
        hasEndedTyping = false;
        texToToWrite = "That sounds like the Luis I'd want to be.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine75()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask him about Romantic, Family, and Hot Head traits)";
        button2AnswerText.text = "(Ask him about Evil, Good, and Loner traits)";
        button3AnswerText.text = "(Ask him about Childish, Snob, and Perfectionist traits)";
        playerIsAnswering = true;
    }

    public void DialogueLine75Answer1()
    {
        if (dialogueLine == 75)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine75Answer2()
    {
        if (dialogueLine == 75)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 78;
            playSound1.playEffect();
        }
    }

    public void DialogueLine75Answer3()
    {
        if (dialogueLine == 75)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 80;
            playSound1.playEffect();
        }
    }

    private void DialogueLine76()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Luis, in matters of the heart and family, were you a passionate romantic, deeply connected to your family...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine77()
    {
        hasEndedTyping = false;
        texToToWrite = "... But also prone to bursts of fiery temper?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine78()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Luis, did you find yourself torn between darker inclinations and a desire to do good?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine79()
    {
        hasEndedTyping = false;
        texToToWrite = "Were you the kind of person who valued your independence and tended to be a bit of a loner?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine80()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Luis, when it came to your approach to life, were you a mix of childlike wonder, a touch of snobbery...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine81()
    {
        hasEndedTyping = false;
        texToToWrite = "And a drive for perfection in everything you pursued?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine82()
    {
        bigSpiritImage.sprite = luisSad;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Now, that's a combination. I can feel the tug at my emotions.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine83()
    {
        hasEndedTyping = false;
        texToToWrite = "Family... That is very locked away, my head hurts when trying to remember them";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine84()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "Passionate and with a fiery temper? The romance... I feel something in me, and I don't know if it is good or bad, but I feel it, spirit guide!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
        
    private void DialogueLine85()
    {
        bigSpiritImage.sprite = luisSad;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Darker inclinations, a desire for good, and valuing independence?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine86()
    {
        bigSpiritImage.sprite = luisHappy;
        hasEndedTyping = false;
        texToToWrite = "That's a tough one. I'm not sure," + gameManager_Script.playerName+ " , but the loner aspect hits home. I guess I liked my space!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine87()
    {
        hasEndedTyping = false;
        texToToWrite =  "About good and bad... Honestly? I don't remember, but the Luis I am now does not care about good or bad as long as it is fun!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine88()
    {
        bigSpiritImage.sprite = luisHappy;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Childlike wonder, a touch of snobbery, and a drive for perfection?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine89()
    {
        hasEndedTyping = false;
        texToToWrite = "That's a mix, alright. It's like trying to blend colors on a canvas. I'm not sure how it all fits together, but it's intriguing.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine90()
    {
        hasEndedTyping = false;
        texToToWrite = "I do feel something about perfectionism... I did like things going my way, I still do...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine91()
    {
        hasEndedTyping = false;
        texToToWrite = "But I tend to be open for debate if one of my actions is not perfect!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine92()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Alright! That is enough; I cannot absorb more essence!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine93()
    {
        hasEndedTyping = false;
        texToToWrite ="This may not seem like much, but it will help a lot for today! I'll see what fragments I can piece together to get your past memories, at least, partial ones!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine94()
    {
        bigSpiritImage.sprite = luisHappy;
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Partial memories, huh? Mystery guide, you're like a puzzle solver in this sea of amnesia.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine95()
    {
        hasEndedTyping = false;
        texToToWrite = "I'm looking forward to what you uncover.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine96()
    {
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I really hope I can fix all of this mess before Dia de Muertos...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine97()
    {
        hasEndedTyping = false;
        texToToWrite = "Otherwise, it looks bad for me, not going to lie.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine98()
    {
        spiritNameText.text = "Luis";
        hasEndedTyping = false;
        texToToWrite = "Before Dia de los Muertos, huh? Well, mystery guide, no pressure, but I'm kind of looking forward to seeing what you come up with.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine99()
    {
        hasEndedTyping = false;
        texToToWrite = "Not because I'm desperate for those memories, but, you know, spending time with you has its own kind of appeal.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine100()
    {

        hasEndedTyping = false;
        texToToWrite = "Well, " + gameManager_Script.playerName+ ", I'll be around Calle de las Almas, ready for the grand reveal. Until then, keep the intrigue alive!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playerIsAnswering = false;
    }
}






