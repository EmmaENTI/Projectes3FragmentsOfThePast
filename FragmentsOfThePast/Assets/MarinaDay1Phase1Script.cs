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

    //Sound 2
    [SerializeField] PlaySound playSound2;

    [SerializeField] private BubbleManager bubbleManager;
    [SerializeField] GameObject consultaPanel;
    [SerializeField] GameObject alchemyPanel;
    bool lockInAlchemyPanel = false;

    KnowledgeScript knowledgeScript;

    private void Start()
    {
        knowledgeScript = new KnowledgeScript();
    }

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

    void SwitchPanels(GameObject a, GameObject b)
    {
        a.SetActive(!a.activeSelf);
        b.SetActive(!b.activeSelf);
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

            case 101:
                DialogueLine101();
                break;

            case 102:
                DialogueLine102();
                break;

            case 103:
                DialogueLine103();
                break;

            case 104:
                DialogueLine104();
                break;

            case 105:
                DialogueLine105();
                break;

            case 106:
                DialogueLine106();
                break;

            case 107:
                DialogueLine107();
                break;

            case 108:
                DialogueLine108();
                break;

            case 109:
                DialogueLine109();
                break;

            case 110:
                DialogueLine110();
                break;

            case 111:
                DialogueLine111();
                break;

            case 112:
                DialogueLine112();
                break;

            case 113:
                DialogueLine113();
                break;

            case 114:
                DialogueLine114();
                break;

            case 115:
                DialogueLine115();
                break;

            case 116:
                DialogueLine116();
                break;

            case 117:
                DialogueLine117();
                break;

            case 118:
                DialogueLine118();
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
            case 12:
                dialogueLine = 51;
                break;

            case 15:
                dialogueLine = 51;
                break;

            case 23:
                dialogueLine = 51;
                break;

            case 26:
                dialogueLine = 51;
                break;

            case 33:
                dialogueLine = 51;
                break;

            case 36:
                dialogueLine = 51;
                break;

            case 39:
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

            case 65:
                dialogueLine = 70;
                break;

            case 68:
                dialogueLine = 77;
                break;

            case 70:
                dialogueLine = 83;
                break;

            case 77:
                dialogueLine = 90;
                break;

            case 83:
                dialogueLine = 90;
                break;

            case 93:
                dialogueLine = 97;
                break;

            case 95:
                dialogueLine = 102;
                break;

            case 97:
                dialogueLine = 105;
                break;

            case 102:
                dialogueLine = 109;
                break;

            case 105:
                dialogueLine = 109;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "You are Marina, if I recall correctly.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        canTalk = false;
    }

    private void DialogueLine2()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
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
        textPanelImage.sprite = TextPanelMarinaSprite;
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
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        texToToWrite = "Yay! I'm thrilled to have a guide like you!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine6()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        texToToWrite = "It's like having a personal memory detective.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine7()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
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
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, come on! Dad jokes are a classic!";
        bigSpiritImage.sprite = marinaAngry;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine10()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        texToToWrite = "But don't worry, I won't pester you with my bad jokes.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine11()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        texToToWrite = "Or maybe I will...?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine12()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        texToToWrite = "You will be the cool mysterious detective...";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine13()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        texToToWrite = "And I will be the pretty but intelligent girl protagonist!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine14()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        texToToWrite = "I always wanted to be the protagonist of a \"Novela\"!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine15()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        hasEndedTyping = false;
        texToToWrite = "Oh, you know, the kind that makes you groan and laugh at the same time! Dad jokes, puns...";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine16()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
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
        }
    }

    private void DialogueLine18()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Get ready, this one could even be traumatizing.";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine19()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Why don't oysters donate to charity?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine20()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "...";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine21()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Because they're shellfish!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();

    }

    private void DialogueLine22()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I know, that one was a hard pill to swallow...";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine23()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Aw, thanks!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine24()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Your vibes are pretty good too, " + gameManager_Script.playerName + ".";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine25()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I'm just here to spread joy, you know?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine26()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, aren't you a smooth talker!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine27()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, um, maybe a bit of both?";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine28()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
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
        }
    }

    private void DialogueLine30()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Aww, thanks!";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine31()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "You're making me feel all fluttery inside, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine32()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "If my jokes don't make you smile, my blushing probably will!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine33()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Aww, thanks!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine34()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Your vibes are pretty good too, " + gameManager_Script.playerName + ".";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine35()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I'm just here to spread joy, you know?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine36()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Cute? Really?";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine37()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, if being a bit shy gets me some attention, I guess it's not so bad.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine38()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Thanks for the cute compliments, " + gameManager_Script.playerName + ".";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine39()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Serious business? Oh, you're no fun!";
        bigSpiritImage.sprite = marinaSad;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine40()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "But sure, let's get down to it. What do you want to know? I'm ready for the serious talk, " + gameManager_Script.playerName + ".";
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
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, about me? Well, let me think...";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine43()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Let me tell you, I might not remember much, but I know one thing for sure—I love laughing, having a good time, and....";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine44()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, the sea! There's something magical about the waves, don't you think?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine45()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "You're right! Serious can be fun too!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine46()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "It's just... well, serious situations make me a bit tense sometimes.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine47()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Maybe I am just too childish sometimes!";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine48()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Gotcha, didn't I?";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine49()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "But, you know, I can be serious when I need to... like, when it involves getting back my memories and stuff!";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine50()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I am excited to see how you work your magic stuff, " + gameManager_Script.playerName + ".";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine51()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Well, let's get to the important part!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine52()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, oh, oh! You suddenly got all concentrated and stuff!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine53()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Are you going to start doing your magic now?!!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine54()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I am super excited!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine55()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "No, no, I will not start glowing and floating or sparkling...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine56()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "We will start by talking about any fragments of memories you might have!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine57()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I will ask you different questions, and while I ask, you should try to really concentrate on smells, sounds, feelings that you may remember...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine58()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "This will allow me to understand you better, and that way, I will combine fragment orbs to create a memory essence orb.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine59()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, I am super excited for a stranger to know my deepest darkest secrets!";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine60()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Just kidding, " + gameManager_Script.playerName + "Ask away, and let's uncover the \"chisme\" of Marina together.";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine61()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "But if there is anything weird out there, keep it a secret.";
        bigSpiritImage.sprite = marinaSad;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine62()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask her about Family, Outgoing, Clumsy traits)";
        button2AnswerText.text = "(Ask her about Active, Ambitious, Music Lover)";
        button3AnswerText.text = "(Ask her about GoofBall, Childish, Cheerful)";
        playerIsAnswering = true;
    }

    public void DialogueLine62Answer1()
    {
        if (dialogueLine == 62)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
        }
    }

    public void DialogueLine62Answer2()
    {
        if (dialogueLine == 62)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 65;
        }
    }

    public void DialogueLine62Answer3()
    {
        if (dialogueLine == 62)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 68;
        }
    }
    private void DialogueLine63()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Marina, let's dive into your memories a bit. What about family, Marina? Were you deeply connected with your family?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine64()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "And in terms of being outgoing and clumsy, do those traits ring a bell?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine65()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Alright, let's see...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine66()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you an active, ambitious soul who found solace and joy in the tunes of life?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine67()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Do you find that relatable?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine68()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Marina, let's delve into some aspects of your personality.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine69()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you a goofy and cheerful soul, always bringing smiles with your childish charm?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine70()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Family, oh, family! You know, it's a bit fuzzy, like trying to grab a slippery fish. I feel warmth, laughter, but there's this strange distance, like I'm watching it all from a boat...";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine71()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Interesting... Can you elaborate? On the family part.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine72()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I can feel a cozy warmth, hear echoes of laughter, but the details slip through my fingers. It's like they're there, but just out of reach.";
        bigSpiritImage.sprite = marinaShy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine73()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I sense something beautiful, but I can't quite put my finger on it. It's both frustrating and comforting, you know?";
        bigSpiritImage.sprite = marinaSad;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine74()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I understand... Well, then what about the other traits? Outgoing and clumsy, do you relate to that?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine75()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Outgoing and clumsy? Well, I do love meeting new people and spreading good vibes, but clumsy?";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine76()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = gameManager_Script.playerName + ", outgoing is a nice description but the clumsy part depends on the day!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine77()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, you betcha! I am sure I was like a whirlwind of energy, always up for an adventure, dancing through life like no one was watching!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine78()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Well, that lasts even now that you are a spirit.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine79()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I am indeed super active! I am constantly trying to keep myself busy! Carmen tends to say I am a hurricane.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
        gameManager_Script.activeBallsAmount++;
    }

    private void DialogueLine80()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "About the Ambitious part... Well, not in the traditional sense, but I aimed for the stars in my own way.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine81()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "And about music? Were you perhaps next Mozart?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine82()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "I enjoy a good tune, but you won't find me composing symphonies. I'm more of a casual listener, you know?";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine83()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, you've nailed it! Goofiness is my middle name, and I proudly carry the banner of eternal childlikeness.";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine84()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Life was too short to be serious, right? So, cheerfulness is my go-to vibe, even now that I am dead!";
        bigSpiritImage.sprite = marinaSurprise;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine85()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "But yes, the most relatable is the childish part...";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine86()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "So you consider yourself childish?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine87()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "You are very aware of your own personality Marina, it is not often that happens.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine88()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Well, I prefer \"playful\" or \"young at heart.\"";
        bigSpiritImage.sprite = marinaAngry;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
        gameManager_Script.childishBallsAmount++;
    }

    private void DialogueLine89()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "But thanks for the compliment, if it was one!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine90()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask her about Romantic, Family, and Evil traits)";
        button2AnswerText.text = "(Ask her about Good, Moody and Perfectionist traits)";
        button3AnswerText.text = "(Ask her about Lazy, Genius and Perfectionist traits)";
        playerIsAnswering = true;
    }

    public void DialogueLine90Answer1()
    {
        if (dialogueLine == 90)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
        }
    }
    public void DialogueLine90Answer2()
    {
        if (dialogueLine == 90)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 93;
        }
    }

    public void DialogueLine90Answer3()
    {
        if (dialogueLine == 90)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 95;
        }
    }

    private void DialogueLine91()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Marina, let's talk about romantic feelings, family, and, well, the possibility of any evil tendencies.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine92()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Tell me about how those words make you feel.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine93()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Marina, now think about this ones, focus your mind on my words.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine94()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Would you say you're generally a good person, not moody, and not too hung up on perfection?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine95()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Are you a bit on the lazy side, maybe a genius, or perhaps a perfectionist?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine96()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Tell me what do you think about those descriptions, do they fit?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine97()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, romantic feelings! I'm totally a hopeless romantic, you know? Hearts, flowers, and all that jazz.";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        gameManager_Script.romanticBallsAmount++;
    }

    private void DialogueLine98()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "As for family... hmm, it's a bit foggy. I can't quite remember, and it's weirdly giving me a headache...";
        bigSpiritImage.sprite = marinaSad;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine99()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Evil? Who, me? No way! I'm all about sunshine and rainbows, not evil vibes. Why would anyone think that?";
        bigSpiritImage.sprite = marinaAngry;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine100()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "It was merely a question, not an accusation, Marina.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine101()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        texToToWrite = "Oh, I know, I know! I just got a bit defensive there, didn't I? My bad!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = marinaShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine102()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaSad;
        texToToWrite = "Oh, absolutely! Good vibes all the way, you know? I consider myself the sunshine on a clear day, spreading positivity and warmth.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        gameManager_Script.goodBallsAmount++;
    }

    private void DialogueLine103()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "As for being moody... I don't think I am, I am usually pretty stable emotionally.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine104()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "I would not consider myself a perfectionist, I am more let's embrace the chaos kind of spirit! The best and most random moments come from not so perfect moments.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine105()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaSad;
        texToToWrite = "Lazy? Oh, no way! I cannot stay on a single spot for more than a minute!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine106()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaSad;
        texToToWrite = "About the genius part... Well, that's pushing it. I'm more of a creative spirit, you know? Maths and books are not my style.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine107()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "And perfectionist? Nah, life... Well, death is too short for perfection...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine108()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaShy;
        texToToWrite = "That pun did not make much sense, my bad.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine109()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Alright! That is enough; I cannot absorb more essence!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine110()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "With this, now I'll see what fragments I can piece together to get your past memories, at least, partial ones!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine111()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "Yay! I'm so excited!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine112()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "You just let me know if you need anything, okay?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine113()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Thanks, Marina!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine114()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I'll be in touch once I've gathered some fragments.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine115()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "You got it, "+ gameManager_Script.playerName + "! Take your time and don't forget to bring back some good stories.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine116()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "I am sure my life was all about juicy stories, you will have fun.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine117()
    {
        textPanelImage.sprite = TextPanelMarinaSprite;
        spiritNameText.text = "Marina";
        hasEndedTyping = false;
        bigSpiritImage.sprite = marinaHappy;
        texToToWrite = "Bye Bye!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine118()
    {
        if (!lockInAlchemyPanel)
        {
            SwitchPanels(consultaPanel, alchemyPanel);

            bubbleManager.knowledgeScript = knowledgeScript;

            bubbleManager.SetCurrentCharacter(BubbleManager.CharacterType.MARINA);


            knowledgeScript.ModifyNumberBubbles(2, gameManager_Script.ambitiousBallsAmount);
            knowledgeScript.ModifyNumberBubbles(21, gameManager_Script.lonerBallsAmount);
            knowledgeScript.ModifyNumberBubbles(23, gameManager_Script.lureBallsAmount);
            knowledgeScript.ModifyNumberBubbles(29, gameManager_Script.perfectionistBallsAmount);

            knowledgeScript.ModifyNumberBubbles(4, gameManager_Script.assertiveBallsAmount);
            knowledgeScript.ModifyNumberBubbles(10, gameManager_Script.entrepreneurBallsAmount);
            knowledgeScript.ModifyNumberBubbles(18, gameManager_Script.independentBallsAmount);
            knowledgeScript.ModifyNumberBubbles(24, gameManager_Script.materialisticBallsAmount);

            knowledgeScript.ModifyNumberBubbles(5, gameManager_Script.bookwormBallsAmount);
            knowledgeScript.ModifyNumberBubbles(14, gameManager_Script.geekBallsAmount);
            knowledgeScript.ModifyNumberBubbles(15, gameManager_Script.geniusBallsAmount);
            knowledgeScript.ModifyNumberBubbles(22, gameManager_Script.loyalBallsAmount);

            knowledgeScript.ModifyNumberBubbles(30, gameManager_Script.romanticBallsAmount);
            knowledgeScript.ModifyNumberBubbles(16, gameManager_Script.goodBallsAmount);
            knowledgeScript.ModifyNumberBubbles(15, gameManager_Script.geniusBallsAmount);
            knowledgeScript.ModifyNumberBubbles(22, gameManager_Script.loyalBallsAmount);

            bubbleManager.CreateRandomBubbles(15, knowledgeScript.listToCreate);
            lockInAlchemyPanel = true;
        }
    }
}


