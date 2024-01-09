using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarmenDay1Phase1Script : MonoBehaviour
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

    //Sprite de Bruno Text Panel
    [SerializeField] Sprite TextPanelCarmenSprite;
    

    //Spirit Image
    public Image bigSpiritImage;

    //Luis Emotions
    public Sprite carmenSurprise;
    public Sprite carmenSad;
    public Sprite carmenAngry;
    public Sprite carmenShy;
    public Sprite carmenHappy;

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

            case 119:
                DialogueLine119();
                break;

            case 120:
                DialogueLine120();
                break;

            case 121:
                DialogueLine121();
                break;

            case 122:
                DialogueLine122();
                break;

            case 123:
                DialogueLine123();
                break;

            case 124:
                DialogueLine124();
                break;

            case 125:
                DialogueLine125();
                break;

            case 126:
                DialogueLine126();
                break;

            case 127:
                DialogueLine127();
                break;

            case 128:
                DialogueLine128();
                break;

            case 129:
                DialogueLine129();
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

            case 23:
                dialogueLine = 55;
                break;

            case 26:
                dialogueLine = 55;
                break;

            case 30:
                dialogueLine = 55;
                break;

            case 37:
                dialogueLine = 55;
                break;

            case 40:
                dialogueLine = 55;
                break;
                    
            case 42:
                dialogueLine = 55;
                break;

            case 51:
                dialogueLine = 55;
                break;

            case 53:
                dialogueLine = 55;
                break;

            case 67:
                dialogueLine = 71;
                break;

            case 69:
                dialogueLine = 77;
                break;

            case 71:
                dialogueLine = 80;
                break;

            case 77:
                dialogueLine = 88;
                break;

            case 80:
                dialogueLine = 88;
                break;

            case 91:
                dialogueLine = 95;
                break;

            case 93:
                dialogueLine = 107;
                break;

            case 95:
                dialogueLine = 121;
                break;

            case 104:
                dialogueLine = 125;
                break;

            case 107:
                dialogueLine = 125;
                break;

            case 114:
                dialogueLine = 125;
                break;

            case 121:
                dialogueLine = 125;
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
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = gameManager_Script.playerName + ", I am Carmen, nice to meet you, but you already know my name, don't you?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
        //gameManager_Script.assertiveBallsAmount = 5;
    }

    private void DialogueLine2()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Hello, nice to meet you too!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine3()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Yes, I did in fact know your name, but I like that you introduced yourself, easier to remember.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = gameManager_Script.playerName + "Well, " +gameManager_Script.playerName + ", I am hard to not remember... But yes, whatever you say darling.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine5()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Darling? Hm, I see. I see this is going to be an interesting conversation, Carmen.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine6()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Hmhm, pleasantries aside, we're here for a purpose. If we're working together, make it worth my time.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }


    private void DialogueLine7()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Relax, Carmen, we're a team now. Let's make it worth each other's while.";
        button2AnswerText.text = "(Flirty) Oh, Carmen, working with you is already worth my time.";
        button3AnswerText.text = "(Serious) I'm here to help, Carmen. Let's focus on the task at hand and get it done efficiently.";
        playerIsAnswering = true;
    }

    public void DialogueLine7Answer1()
    {
        if (dialogueLine == 7)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine7Answer2()
    {
        if (dialogueLine == 7)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 30;
            playSound1.playEffect();
        }
    }

    public void DialogueLine7Answer3()
    {
        if (dialogueLine == 7)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 42;
            playSound1.playEffect();
        }
    }

    private void DialogueLine8()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Well, well, someone's got a bit of charm. I'll admit, a team effort might make this ordeal more bearable.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenSurprise;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine9()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "But don't think for a second that we're sharing secrets like old friends.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine10()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "We play this smart, efficient, and to the point. Agreed?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine11()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Agreed, efficient teamwork is what we need!";
        button2AnswerText.text = "(Flirty) Oh, Carmen, who said anything about tea parties?";
        button3AnswerText.text = "(Serious) I'm not here for tea parties either.";
        playerIsAnswering = true;
    }

    public void DialogueLine11Answer1()
    {
        if (dialogueLine == 11)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine11Answer2()
    {
        if (dialogueLine == 11)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 26;
            playSound1.playEffect();
        }
    }

    public void DialogueLine11Answer3()
    {
        if (dialogueLine == 11)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 62;
            playSound1.playEffect();
        }
    }

    private void DialogueLine12()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I like your spirit, kid. Just keep it useful.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine13()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "We're not here for tea parties. If you pull your weight, we'll get along just fine.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine14()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "(Amused) Kid? How old are you Carmen?";
        button2AnswerText.text = "(Friendly) Don't worry, Carmen. I'm not here for the tea either.";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine14Answer1()
    {
        if (dialogueLine == 14)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine14Answer2()
    {
        if (dialogueLine == 14)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 23;
            playSound1.playEffect();
        }
    }

    private void DialogueLine15()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "As far as I know I was 41 years old when alive.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine16()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "But I tend to use the word kid to people that I see are more...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine17()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Let's say, not as professional as me.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine18()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "You look not a day older than 30.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine19()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Thanks, I know.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine20()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "And now that I am dead, I don't have to worry about skincare routines or waxing.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine21()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I just have to worry about my memories getting stolen by a mysterious hooded man.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }


    private void DialogueLine22()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I would say at least it is less painful than waxing.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine23()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Good. I like people who understand the importance of getting things done.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine24()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I hate procastinators and people who do not keep promises.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine25()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Stick to that idea, no drama, focus on work and we won't have any problems. Let's see if you can keep up.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine26()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I'm here to make this afterlife a little more interesting";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine27()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Interesting, huh? A lot of things come to mind with that word.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine28()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "We'll see if you're as intriguing as you think.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine29()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Just don't let your charm get in the way of our purpose.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
    }

    private void DialogueLine30()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Smooth talker, aren't you?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenSurprise;
        canTalk = false;
    }

    private void DialogueLine31()   
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Save the flattery for someone who falls for it.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;    }


    private void DialogueLine32()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "We're here for a reason, let's not get distracted.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine33()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Flirty) Well, Carmen, a woman like you deserves a little distraction, don't you think?";
        button2AnswerText.text = "(Flirty) Flattery is just a warm-up, Carmen. The real magic happens when we start working together.";
        button3AnswerText.text = "(Friendly) I get it, business first.";
        playerIsAnswering = true;
    }

    public void DialogueLine33Answer1()
    {
        if (dialogueLine == 33)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine33Answer2()
    {
        if (dialogueLine == 33)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 37;
            playSound1.playEffect();
        }
    }

    public void DialogueLine33Answer3()
    {
        if (dialogueLine == 33)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 40;
            playSound1.playEffect();
        }
    }

    private void DialogueLine34()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Distraction, huh? We'll see if you can keep up with me, darling.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
    }

    private void DialogueLine35()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Distraction, darling, is a luxury for those who can afford to lose focus. I'm not one of them.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine36()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Distractions don't pay the bills, sweetie. Stick to the task.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine37()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Magic, huh? I've heard a lot of promises...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenSurprise;
        canTalk = false;
    }

    private void DialogueLine38()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "But actions speak louder than words, darling.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine39()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "And you are all talk and no action.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine40()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Well, darling, it's good to know you can stay on track.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine41()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "We're not here to play games; we're here to solve a problem.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine42()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Well, darling, it's about time someone knows how to cut to the chase. Efficiency suits me just fine.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine43 ()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Luis and Marina have an allergy to efficieny and going to the point.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
    }

    private void DialogueLine44()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Let's see if you can keep up with my level and we will get along just fine.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine45()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Gossip) Oh? You have beef with them?";
        button2AnswerText.text = "(Friendly) We have to work together to be efficient, Carmen.";
        button3AnswerText.text = "(Sly) Oh, I am sure I will keep up with the level.";
        playerIsAnswering = true;
    }

    public void DialogueLine45Answer1()
    {
        if (dialogueLine == 45)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine45Answer2()
    {
        if (dialogueLine == 45)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 51;
            playSound1.playEffect();
        }
    }

    public void DialogueLine45Answer3()
    {
        if (dialogueLine == 45)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 53;
            playSound1.playEffect();
        }
    }

    private void DialogueLine46()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Oh, another chisme enjoyer I see~";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine47()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I do enjoy a good cup of tea and a dash of chisme. If there's any drama brewing, you can bet I'll have my cup ready.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenShy;
        canTalk = false;
    }

    private void DialogueLine48()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Besides, knowing a bit more about our companions might prove useful.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine49()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Well, part of my job is being interested in other's lifes.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine50()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "So yes, if you have any drama, please do share it with me.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine51()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Efficient, huh? I can respect that.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenSurprise;
        canTalk = false;
    }

    private void DialogueLine52()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Just make sure your idea of efficiency aligns with mine, and we won't have a problem.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
    }

    private void DialogueLine53()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Aren't you a confident person," + gameManager_Script.playerName + "?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine54()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I see you have wit, that is something attractive in a person.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine55()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Alright, moving on!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine56()
    {
        textPanelImage.sprite = TextPanelNormalSprite;  
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Let's go to the important part, shall we?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine57()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Finally, getting to the heart of the matter.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine58()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Time is money, darling, let's not waste either.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }
        
    private void DialogueLine59()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Well, in my case, I am working for free, but yeah, moving on...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine60()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "This are the instructions...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine61()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I will ask you different questions, and while I ask, you should try to really concentrate on smells, sounds, feelings that you may remember...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine62()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "This will allow me to understand you better, and that way, I will combine fragment orbs to create a memory essence orb.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine63()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Finally, getting to the heart of the matter.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine64()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask her about Family)";
        button2AnswerText.text = "(Ask her about  Materialistic trait)";
        button3AnswerText.text = "(Ask her about Ambitious trait)";
        playerIsAnswering = true;
    }

    public void DialogueLine64Answer1()
    {
        if (dialogueLine == 64)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine64Answer2()
    {
        if (dialogueLine == 64)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 67;
            playSound1.playEffect();
        }
    }

    public void DialogueLine64Answer3()
    {
        if (dialogueLine == 64)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 69;
            playSound1.playEffect();
        }
    }

    private void DialogueLine65()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Carmen, let's talk about family.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine66()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you closely tied to your family, or did you feel a sense of distance?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
        
    private void DialogueLine67()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Carmen, let's delve into your relationship with material possessions.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine68()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you someone who appreciated the finer things in life, finding comfort in luxury and opulence?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine69()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Carmen, let's delve into your ambitions.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine70()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you someone with grand aspirations, seeking recognition and applause, or did you have more grounded goals in mind?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine71()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Family, ah... I don't remember... It is very locked away... But I feel... Regret.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine72()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Pride and regrets... guess they took the lead. It is what I mostly feel when thinking about the word \"Family\".";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
    }

    private void DialogueLine73()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Any specific regrets or moments that stand out in your mind?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine74()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Can't seem to recall the specifics. It's like trying to catch the wind.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine75()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Slips through your fingers, leaves a sensation, but no tangible grasp.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine76()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I see... Well, no worries, thanks for being honest.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine77()
    {   
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Ah, material possessions, my realm of control. I never settle for anything less than the best.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
        gameManager_Script.materialisticBallsAmount++;
    }

    private void DialogueLine78()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "A touch of silk, the sparkle of diamonds – they speak a language of power.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine79()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Diamonds, are a girl's best friend, like Marilyn Monroe said once.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine80()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Ambitions are the key to control, darling.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        gameManager_Script.entrepreneurBallsAmount++;
    }

    private void DialogueLine81()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Recognition is just a sweet bonus, but control over one's life is the ultimate prize.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine82()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I don't need no ones applauses, I do it for myself.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
    }

    private void DialogueLine83()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Is there a particular achievement that stands out in your ambitious journey?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine84()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "It is hard to remember, [Player Name]...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine85()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "One achievement that resonates is the establishment of my own business. A venture that thrived on my determination and strategic prowess.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine86()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "It afforded me a taste of success and control, a testament to what relentless ambition can achieve.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine87()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I can't manage to remember, but I am pretty sure I owned a business.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine88()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask her about Assertive and Outgoing traits)";
        button2AnswerText.text = "(Ask her about Independent and Dependent traits)";
        button3AnswerText.text = "(Ask her about Romantic trait)";
        playerIsAnswering = true;
    }

    public void DialogueLine88Answer1()
    {
        if (dialogueLine == 88)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine88Answer2()
    {
        if (dialogueLine == 88)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 91;
            playSound1.playEffect();
        }
    }

    public void DialogueLine88Answer3()
    {
        if (dialogueLine == 88)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 93;
            playSound1.playEffect();
        }
    }

    private void DialogueLine89()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Carmen, let's explore some aspects of your personality.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine90()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Would you consider yourself assertive, always taking charge, or perhaps more outgoing, enjoying social events and gatherings?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine91()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Carmen, let's explore your approach to independence.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine92()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you more inclined to handle things on your own, or did you find strength in depending on others?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine93()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Carmen, let's talk about romance.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine94()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you someone who embraced the romantic side of life, or did you find it more of a game?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine95()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Assertive is my middle name, darling.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        gameManager_Script.assertiveBallsAmount++;
    }

    private void DialogueLine96()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Outgoing? Well, I do enjoy the occasional night out, sipping champagne, savoring oysters.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenSurprise;
        canTalk = false;
    }
    private void DialogueLine97()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "But I'm selective about where I invest my time.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine98()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "(Tease)";
        button2AnswerText.text = "(Admire)";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine98Answer1()
    {
        if (dialogueLine == 98)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine98Answer2()
    {
        if (dialogueLine == 98)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 104;
            playSound1.playEffect();
        }
    }

    private void DialogueLine99()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Selective, huh? I bet you've got a taste for the finer things in life.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine100()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Finer things are wasted on those who don't appreciate them.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }
        
    private void DialogueLine101()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Finer things are wasted on those who don't appreciate them.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine102()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Selective, huh? I bet you've got a taste for the finer things in life.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine103()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Finer things are wasted on those who don't appreciate them.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine104()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Being assertive is a great quality. It's essential in the business world.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine105()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Indeed, darling. In the business world, you either take control or become someone else's pawn.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine106()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "It's a game, and I play to win.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine107()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Independence is a trait I hold dear.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
        gameManager_Script.independentBallsAmount++;
    }

    private void DialogueLine108()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Relying on others tends to introduce unnecessary variables into the equation.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine109()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I prefer to control my destiny, thank you.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine110()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "(Agree)";
        button2AnswerText.text = "(Disagree)";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine110Answer1()
    {
        if (dialogueLine == 110)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine110Answer2()
    {
        if (dialogueLine == 110)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 114;
            playSound1.playEffect();
        }
    }

    private void DialogueLine111()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Independence is crucial. It's empowering to shape your own path.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine112()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Wise words. I've always believed in the power of self-reliance.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine113()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "It keeps you ahead of the game.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }
    private void DialogueLine114()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Sometimes, depending on others can bring unexpected rewards.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine115()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Unexpected rewards? I prefer predictability.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine116()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Dependence introduces chaos, and I've got enough of that in my past.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
    }

    private void DialogueLine117()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Well, Carmen, not everything in life can be planned.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine118()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Sometimes, the best things happen when we least expect them. It's the unpredictability that keeps life interesting.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine119()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I disagree, " + gameManager_Script.playerName + " I like having control, not chaos and unpredictability.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenAngry;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine120()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine121()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Romance, darling, is just a sophisticated game.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine122()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "A dance where everyone tries to outwit each other.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine123()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Love, on the other hand, is a currency of power. It's about control and finesse.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine124()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "So I guess that leaves it clear, for me, love and romance are tools in a game.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine125()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Alright, I've gathered enough; I can't take in any more essence!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine126()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "With this, I'll now attempt to weave together fragments to unveil pieces of your past memories, even if only partially!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine127()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "Well, be my guest, " + gameManager_Script.playerName + ". I'm curious to see what kind of story you'll unearth from the remnants of my past.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine128()
    {
        textPanelImage.sprite = TextPanelCarmenSprite;
        spiritNameText.text = "Carmen";
        hasEndedTyping = false;
        texToToWrite = "I'll be back for the results. Until then.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = carmenHappy;
        canTalk = false;
    }

    private void DialogueLine129()
    {
        if (!lockInAlchemyPanel)
        {
            SwitchPanels(consultaPanel, alchemyPanel);

            bubbleManager.knowledgeScript = knowledgeScript;

            bubbleManager.SetCurrentCharacter(BubbleManager.CharacterType.CARMEN);



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







