using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BrunoDay1Phase1Script : MonoBehaviour
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
    [SerializeField] Sprite TextPanelBrunoSprite;


    //Spirit Image
    public Image bigSpiritImage;

    //Luis Emotions
    public Sprite brunoSuprise;
    public Sprite brunoSad;
    public Sprite brunoAngry;
    public Sprite brunoShy;
    public Sprite brunoHappy;

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

            case 130:
                DialogueLine130();
                break;

            case 131:
                DialogueLine131();
                break;

            case 132:
                DialogueLine132();
                break;

            case 133:
                DialogueLine133();
                break;

            case 134:
                DialogueLine134();
                break;

            case 135:
                DialogueLine135();
                break;

            case 136:
                DialogueLine136();
                break;

            case 137:
                DialogueLine137();
                break;

            case 138:
                DialogueLine138();
                break;

            case 139:
                DialogueLine139();
                break;

            case 140:
                DialogueLine140();
                break;

            case 141:
                DialogueLine141();
                break;

            case 142:
                DialogueLine142();
                break;

            case 143:
                DialogueLine143();
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

            case 20:
                dialogueLine = 62;
                break;

            case 27:
                dialogueLine = 62;
                break;

            case 30:
                dialogueLine = 62;
                break;

            case 37:
                dialogueLine = 62;
                break;

            case 40:
                dialogueLine = 62;
                break;

            case 43:
                dialogueLine = 62;
                break;

            case 52:
                dialogueLine = 62;
                break;

            case 60:
                dialogueLine = 62;
                break;

            case 77:
                dialogueLine = 81;
                break;

            case 79:
                dialogueLine = 86;
                break;

            case 81:
                dialogueLine = 91;
                break;

            case 86:
                dialogueLine = 98;
                break;

            case 89:
                dialogueLine = 98;
                break;

            case 101:
                dialogueLine = 105;
                break;

            case 103:
                dialogueLine = 105;
                break;

            case 112:
                dialogueLine = 135;
                break;

            case 118:
                dialogueLine = 135;
                break;

            case 131:
                dialogueLine = 135;
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
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, am I right?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Uh, yeah. That's me.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine3()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Nice to meet you, Bruno.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine4()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You too.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine5()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Hey, no need to feel nervous.";
        button2AnswerText.text = "(Flirty) You're the mysterious and quiet type, Bruno. I like that.";
        button3AnswerText.text = "(Serious) Let's get down to business, Bruno.";
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
            dialogueLine = 31;
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
            dialogueLine = 44;
            playSound1.playEffect();
        }
    }

    private void DialogueLine6()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Nervous? I'm not...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine7()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine8()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Yeah, okay, maybe a bit.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine9()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Relax, I don't bite! I am here to help.";
        button2AnswerText.text = "(Flirty) You're the mysterious type, Bruno. I like that.";
        button3AnswerText.text = "(Serious) Let's skip to the important part then.";
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
            dialogueLine = 27;
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
            dialogueLine = 62;
            playSound1.playEffect();
        }
    }

    private void DialogueLine10()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I'm not worried about biting.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine11()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Just... not used to this.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine12()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Getting help, I mean.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine13()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You sound like a psychologist.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine14()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "In a good way...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine15()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "(Friendly) No need to be shy.";
        button2AnswerText.text = "(Amused) How can it be a bad way?";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine15Answer1()
    {
        if (dialogueLine == 15)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine15Answer2()
    {
        if (dialogueLine == 15)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 20;
            playSound1.playEffect();
        }
    }

    private void DialogueLine16()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I am here to help you, I want you to feel safe and comfortable with me so my magic can work.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine17()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Safe and comfortable... Right. I'll try.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine18()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's not about feeling safe. I'm just not used to... this. Opening up, I guess.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine19()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "But yeah, as I said, I will try, thanks for being so patient.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine20()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Well, I didn't mean it in a bad way. I just meant you seem... insightful, like one.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine21()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You're good at making people open up. It's a compliment.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine22()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I really suck at this, don't I? I don't want to make it awkward.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine23()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Hey, Bruno, I am here to help, it is literally my mission.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine24()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I won't judge you, we both need to work together, I do not think you are awkward.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine25()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine26()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You sound genuine, so it makes me feel better, thank you again!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine27()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Mysterious? Not intentional...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine28()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I just... prefer to keep things to myself.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine29()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I am obviously not much of a talker, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine30()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Uh, well, thanks. I mean, not used to... um, this kind of attention. Not that I don't appreciate it.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine31()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's just, you know, usually I'm more in the background. People don't really notice me much.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine32()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "So, yeah, this is... different.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine33()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Well, you've got my attention now!";
        button2AnswerText.text = "(Flirty) Maybe it's time more people noticed you, Bruno.";
        button3AnswerText.text = "(Amused) Looks like I caught you off guard, Bruno.";
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
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Yeah, um, I guess I'm not the center of attention usually.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }


    private void DialogueLine35()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "More of a behind-the-scenes guy. But, um, thanks for noticing, I suppose.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine36()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "The others are definetely the protagonists, I am not a fan of the spotlight.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }
    private void DialogueLine37()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Uh, yeah, I guess that's a new experience for me.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine38()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Not used to, you know, people... noticing. But, um, thanks. It's, uh, nice to be noticed.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine39()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Specially if the one that notices is someone like you, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine40()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Yeah, you could say that. I'm not really used to being in the spotlight, so to speak.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine41()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's a bit... unexpected. But, um, let's focus on what we're here for. Memories and stuff.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine42()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Otherwise, I fear it will get awkward very fast.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine43()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Business, huh?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine44()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Sure, ask your questions. I'll answer what I can.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine45()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Anything you're comfortable sharing helps!";
        button2AnswerText.text = "(Flirty) So, Bruno, what's your idea of a perfect date?";
        button3AnswerText.text = "(Serious) Well, then, let's skip small talk.";
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
            dialogueLine = 52;
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
            dialogueLine = 60;
            playSound1.playEffect();
        }
    }

    private void DialogueLine46()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Comfortable sharing? Well, I'll try, I guess.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }


    private void DialogueLine47()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Not used to talking about myself... But since you are a Spirit Guide, I guess I will have to try and be more open.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine48()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Sorry if I make this awkward, I tend to do that accidentally.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine49()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Hey, don't worry Bruno, I am here to help, not to judge anyone, it is my mission after all...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }


    private void DialogueLine50()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "It is not common for me either to be in the dead realm, talking to spirits, and stuff...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine51()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "So yeah! Awkwardness is to be expected, but that is okay!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine52()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Perfect date?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine53()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I, um, haven't really thought about it.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine54()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I'm not... experienced in that area.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine55()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Oh, come on, Bruno! Everyone has some idea of a perfect date, even if it's just in their imagination.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine56()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Don't tell me you've never daydreamed about it at least once!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine57()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Daydreaming about... dates? Well, not really.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine58()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I mean, there's so much going on, and I... I don't know.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine59()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's just not something I think about.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine60()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Works for me... The more I talk, the more I make situations awkward.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine61()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Marina and Luis are the talkers, me and Carmen enjoy silence and privacy.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine62()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine63()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno... It is for the best if we get to the important part.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine64()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Yes! I am a big fan of going to the point.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine65()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Sorry if I seem too introverted, with time, I hope to be more comfortable, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine66()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Ready when you are!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }


    private void DialogueLine67()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Hey! No need to apologize, not everyone is a chatterbox.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine68()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Alright, this goes like this...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine69()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I will ask you different questions, and while I ask, you should try to really concentrate on smells, sounds, feelings that you may remember...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine70()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "This will allow me to understand you better, and that way, I will combine fragment orbs to create a memory essence orb.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine71()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Oh... It is magic...?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine72()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I kind of hoped it would have some mathematical bases...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }


    private void DialogueLine73()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "But you are the boss, " + gameManager_Script.playerName + ", I trust your judgement, ask your questions!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine74()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask him about BookWorm, Clumsy, HotHeaded)";
        button2AnswerText.text = "(Ask him about Genius, Loner, Materialistic)";
        button3AnswerText.text = "(Ask him about Geek, Lazy, Active)";
        playerIsAnswering = true;
    }

    public void DialogueLine74Answer1()
    {
        if (dialogueLine == 74)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine74Answer2()
    {
        if (dialogueLine == 74)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 77;
            playSound1.playEffect();
        }
    }

    public void DialogueLine74Answer3()
    {
        if (dialogueLine == 74)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 79;
            playSound1.playEffect();
        }
    }

    private void DialogueLine75()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, when it comes to your habits, were you more of a bookworm, immersed in the world of literature?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine76()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "And, um, were you a bit clumsy or maybe even prone to bursts of hot-headedness?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine77()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, diving a bit deeper, were you someone who embraced the label of genius, perhaps seeking intellectual challenges?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine78()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "And, did you find comfort in solitude, maybe even considering yourself a bit of a loner? Lastly, did material possessions hold a significant place in your life?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine79()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, getting to know you better. Were you more of a geek, immersed in your passions?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine80()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Did you find yourself leaning towards laziness, or were you more on the active side?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine81()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Books, yes, they were my haven. Clumsy and hotheaded, not quite my style.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
        gameManager_Script.bookwormBallsAmount++;
    }

    private void DialogueLine82()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I think I preferred the quiet corners of a library to the shame of a clumsy misstep or a heated argument.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine83()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "You wear glasses and you like books... Aren't you a stereotype?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine84()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Come on... Me having myopia and liking books is just coincidence.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine85()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I do not think being half blind comes with a \"I like books\" DLC.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine86()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Genius, yes, I had a fascination with the mysteries of the universe.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
        gameManager_Script.geniusBallsAmount++;
    }

    private void DialogueLine87()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Even now that I am dead I am constantly asking myself questions all the time...!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine88()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Loner, maybe a bit. Materialistic, not so much. The pursuit of knowledge was my treasure...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine89()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Geek, absolutely. The worst part of being dead is I will miss all the upcoming Marvel movies...!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
        playSound2.playEffect();
        gameManager_Script.geekBallsAmount++;
    }

    private void DialogueLine90()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "And I also will miss new volumes of my favorite mangas...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }


    private void DialogueLine91()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "And I also will miss playing Baldur's Gate, I never got to finish ACT 3...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine92()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Oh, I am sorry I did not mean to cause such a melancholic reaction...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine93()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "But being a geek is in your soul, that is for sure.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine94()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "No worries " + gameManager_Script.playerName + "... I am amnesiac but those things just stick to the soul, it is not in the brain.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine95()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Back to the other questions... Active, well, when it came to unraveling the secrets of the universe, you could say I was quite proactive.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine96()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Running and lifting weights... Not a fan of that activity.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine97()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "But lazy... I would not consider myself lazy either, just normal, not too much not too little.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine98()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Ask him about Loyalty, Family, Friendships)";
        button2AnswerText.text = "(Ask him about Good and Evil traits)";
        button3AnswerText.text = "(Ask him about Romantic trait)";
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
            dialogueLine = 101;
            playSound1.playEffect();
        }
    }

    public void DialogueLine98Answer3()
    {
        if (dialogueLine == 98)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 103;
            playSound1.playEffect();
        }
    }


    private void DialogueLine99()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, let's delve into the bonds that matter.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine100()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "What about loyalty, family, and friendships?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine101()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, this is a simple question, but the answer is not that simple.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine102()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "What do you think about good and evil?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine103()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, let's touch on a more personal note. How about romance?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine104()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Were you the romantic type, seeking deep connections, or maybe a bit reserved when it came to matters of the heart?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine105()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Loyalty is like the foundation of any meaningful connection, you know?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine106()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "And family, well, they're the constants in our lives, even if things get a bit chaotic.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine107()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "As for friendships, genuine ones are hard to come by, but when you find them, they're worth their weight in gold.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine108()
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

    public void DialogueLine108Answer1()
    {
        if (dialogueLine == 108)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }


    public void DialogueLine108Answer2()
    {
        if (dialogueLine == 108)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 112;
            playSound1.playEffect();
        }
    }


    private void DialogueLine109()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Absolutely, loyalty is the glue that binds relationships.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine110()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Couldn't agree more. Loyalty builds trust, and trust is like the superglue of relationships.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine111()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Without it, everything falls apart.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine112()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I think people should rely more on themselves than on others.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine113()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I get where you're coming from, but we're not meant to navigate this world alone.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoAngry;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine114()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Connections with others make life richer, even if it comes with its challenges. Besides, sometimes, you need someone to cover your blind spots.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoAngry;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine115()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Fair point. I guess relying on others does have its advantages.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine116()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "It's just sometimes people can be unreliable, you know?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine117()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Then you need to find reliable people, " + gameManager_Script.playerName + ", and cherish them.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine118()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Good and evil, huh? Well, I've always believed that the concepts of good and evil are quite subjective.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine119()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's more about intentions and consequences, don't you think? As for me, I've always aimed for the greater good in my pursuits.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }


    private void DialogueLine120()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "But, you know, sometimes the pursuit of knowledge can lead you down some morally gray paths. I've had my fair share of ethical dilemmas.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine121()
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

    public void DialogueLine121Answer1()
    {
        if (dialogueLine == 121)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }


    public void DialogueLine121Answer2()
    {
        if (dialogueLine == 121)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine = 125;
            playSound1.playEffect();    
        }
    }

    private void DialogueLine122()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Yeah, intentions matter more than black and white labels.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine123()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You get it. Life is a spectrum of grays. Intentions shape our actions, and sometimes what seems like a clear-cut choice isn't that simple.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine124()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's the shades in between that make things interesting.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine125()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I believe in clear distinctions between good and evil.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine126()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Really? That's an interesting perspective.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine127()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I'm curious, do you find it easy to navigate a world of absolutes? It must simplify things a lot.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }


    private void DialogueLine128()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "I believe in clear distinctions between good and evil.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine129()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Knowing where you stand, even if it's on shaky ground, feels better than navigating through uncertainties.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine130()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Interesting, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }
        
    private void DialogueLine131()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
        playSound2.playEffect();
    }   

    private void DialogueLine132()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine133()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Romance is... well, it's a complex equation, isn't it? I mean, deep connections are beautiful...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine134()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "But sometimes the variables involved can throw you off balance.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine135()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Alright! That's sufficient; I can't absorb any more essence!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine136()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "With this, I'll now try to piece together fragments to retrieve your past memories, at least partially!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine137()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I will wait patiently, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine138()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Let's see if magic works, I am used to science.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine139()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "My magic does work, otherwise, I would have not been summoned here by an entity.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine140()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Come around later, Bruno, and you will see my magic does work.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine141()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Alright, " + gameManager_Script.playerName + "!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
        playSound2.playEffect();
    }


    private void DialogueLine142()
    {
        textPanelImage.sprite = TextPanelBrunoSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Thanks for your help and patience, I will be around here later.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine143()
    {
        if (!lockInAlchemyPanel)
        {
            SwitchPanels(consultaPanel, alchemyPanel);

            bubbleManager.knowledgeScript = knowledgeScript;

            bubbleManager.SetCurrentCharacter(BubbleManager.CharacterType.BRUNO);


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
