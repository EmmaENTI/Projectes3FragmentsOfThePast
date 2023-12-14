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
            //dialogueLine = 63;
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
            //dialogueLine = 65;
            playSound1.playEffect();
        }
    }

    private void DialogueLine5()
    {
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        texToToWrite = "Yay! I'm thrilled to have a guide like you!";
        bigSpiritImage.sprite = marinaHappy;
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
}
