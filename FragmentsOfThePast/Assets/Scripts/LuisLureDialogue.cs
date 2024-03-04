using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LuisLureDialogue : MonoBehaviour
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

    [SerializeField] private BubbleManager bubbleManager;
    [SerializeField] GameObject consultaPanel;
    [SerializeField] GameObject alchemyPanel;
    bool lockInAlchemyPanel = false;

    KnowledgeScript knowledgeScript;

    public Button middleButton;
    public Sprite luisSpecialButtonSprite;

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
                                /*
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
                break;*/
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
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine1()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisHappy;
        texToToWrite = "So, mystery guide, you're telling me you can see fragments of my past in that little crystal ball of yours?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisHappy;
        texToToWrite = "That's quite the performance you've got going on. I mean, I've seen my fair share of card readers and fortune tellers, but managing to conjure up a fragment crystal ball is a new one.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine3()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisHappy;
        texToToWrite = "Color me impressed, but I'm still waiting for the grand reveal. I haven't seen any mind-blowing results yet.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine4()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "So you still think I am all all smoke and mirrors...? Luis, come on, I am here, summoned by a superior entity...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine5()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "But yeah, I do have some grand reveal, I saw a fragment of your past.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine6()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "The ambience was a ballroom, you were surrounded by women, who touched you and said sweet words in your ear.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine7()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "You felt confident and pretty, totally in control of the situation, for you, being alluring was a game.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine8()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisSuprise;
        texToToWrite = "Color me impressed, but I'm still waiting for the grand reveal. I haven't seen any mind-blowing results yet.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine9()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisHappy;
        texToToWrite = "I remember that day, I had a lot of women behind me at that ball... And I got to choose, I felt really handsome and confident that day.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine10()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisShy;
        texToToWrite = gameManager_Script.playerName + "... This feels personal; I'm not sure I want someone digging into my memories. This power is unsettling, to say the least!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine11()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "Unsettling? Come on Luis, I am not a cop... I won't get bothered because you liked dating and one night stands.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine12()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        hasEndedTyping = false;
        spiritNameText.text = gameManager_Script.playerName;
        texToToWrite = "I'm on your side; there's no judgment here.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine13()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisHappy;
        texToToWrite = "I suppose I'm just not accustomed to being this vulnerable, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playSound2.playEffect();
    }

    private void DialogueLine14()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisHappy;
        texToToWrite = "I need to regain my memories, and you are the only one able to give them back...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine15()
    {
        textPanelImage.sprite = TextPanelLuisSprite;
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        bigSpiritImage.sprite = luisShy;
        texToToWrite = "But I do have to admit I did not want you to know about my dating life.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine16()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "(Tease) I do not mind knowing about it.";
        button2AnswerText.text = "(Alluringness) Well, it was an important part of your life.";
        button3AnswerText.text = "";
        playerIsAnswering = true;

        SpriteState st = new SpriteState();
        st.highlightedSprite = luisSpecialButtonSprite;
        middleButton.GetComponent<Button>().spriteState = st;
        middleButton.GetComponent<Image>().sprite = luisSpecialButtonSprite;
    }

    public void DialogueLine16Answer1()
    {
        if (dialogueLine == 16)
        {
            //dialogueTextPanel.SetActive(true);
            //answerButtonsPanel.SetActive(false);
            //playerIsAnswering = false;
            //canTalk = true;
            //dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine16Answer2()
    {
        if (dialogueLine == 16)
        {
            //dialogueTextPanel.SetActive(true);
            //answerButtonsPanel.SetActive(false);
            //playerIsAnswering = false;
            //canTalk = true;
            //dialogueLine++;
            playSound1.playEffect();
        }
    }


}






