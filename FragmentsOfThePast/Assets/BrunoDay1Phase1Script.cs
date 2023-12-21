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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Bruno, am I right?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Uh, yeah. That's me.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine3()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = gameManager_Script.playerName;
        hasEndedTyping = false;
        texToToWrite = "Nice to meet you, Bruno.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You too.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Nervous? I'm not...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine7()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine8()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
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
            dialogueLine = 30;
            playSound1.playEffect();
        }
    }

    private void DialogueLine10()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I'm not worried about biting.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine11()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Just... not used to this.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine12()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Getting help, I mean.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine13()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You sound like a psychologist.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine14()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Safe and comfortable... Right. I'll try.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine18()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's not about feeling safe. I'm just not used to... this. Opening up, I guess.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine19()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "But yeah, as I said, I will try, thanks for being so patient.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine20()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Well, I didn't mean it in a bad way. I just meant you seem... insightful, like one.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine21()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You're good at making people open up. It's a compliment.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine22()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine26()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "You sound genuine, so it makes me feel better, thank you again!";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine27()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Mysterious? Not intentional...";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine28()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I just... prefer to keep things to myself.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine29()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I am obviously not much of a talker, " + gameManager_Script.playerName + ".";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine30()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Uh, well, thanks. I mean, not used to... um, this kind of attention. Not that I don't appreciate it.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine31()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's just, you know, usually I'm more in the background. People don't really notice me much.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine32()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's just, you know, usually I'm more in the background. People don't really notice me much.";
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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Yeah, um, I guess I'm not the center of attention usually.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }


    private void DialogueLine35()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "More of a behind-the-scenes guy. But, um, thanks for noticing, I suppose.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine36()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "The others are definetely the protagonists, I am not a fan of the spotlight.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }
    private void DialogueLine37()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Uh, yeah, I guess that's a new experience for me.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine38()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Not used to, you know, people... noticing. But, um, thanks. It's, uh, nice to be noticed.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine39()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Specially if the one that notices is someone like you, " + gameManager_Script.playerName + "";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine40()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Yeah, you could say that. I'm not really used to being in the spotlight, so to speak.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine41()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's a bit... unexpected. But, um, let's focus on what we're here for. Memories and stuff.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine42()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Otherwise, I fear it will get awkward very fast.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine43()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Business, huh?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine44()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Comfortable sharing? Well, I'll try, I guess.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }


    private void DialogueLine47()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Not used to talking about myself... But since you are a Spirit Guide, I guess I will have to try and be more open.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoHappy;
        canTalk = false;
    }

    private void DialogueLine48()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Perfect date?";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSuprise;
        canTalk = false;
    }

    private void DialogueLine53()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I, um, haven't really thought about it.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine54()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
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
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "Daydreaming about... dates? Well, not really.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }

    private void DialogueLine58()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "I mean, there's so much going on, and I... I don't know.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoSad;
        canTalk = false;
    }

    private void DialogueLine59()
    {
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = "Bruno";
        hasEndedTyping = false;
        texToToWrite = "It's just not something I think about.";
        StartCoroutine(TypeText(texToToWrite));
        bigSpiritImage.sprite = brunoShy;
        canTalk = false;
    }
}
