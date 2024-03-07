using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardTutorialScript : MonoBehaviour
{
    //Bool canStartDialogue
    [SerializeField] bool canStartDialogue = true;

    //Bool canTalk
    [SerializeField] bool canTalk = false;

    //Bool playerIsAnswering
    [SerializeField] bool playerIsAnswering;

    //Dialogue Panel
    public GameObject dialogueTextPanel;

    //Bool hasEndedTyping
    [SerializeField] bool hasEndedTyping;

    //Dialogue Line Counter
    [SerializeField] int dialogueLine;

    //Dialogue Text
    [SerializeField] TextMeshProUGUI dialogueText;

    //Sound 0
    [SerializeField] PlaySound playSound;

    //Text to write
    [SerializeField] string texToToWrite;

    [SerializeField] private GameObject audioSourceGameObject;

    [SerializeField] private GameObject tagGameObject;

    [SerializeField] private Sprite luisPanelSprite;
    [SerializeField] private Sprite normalPanelSprite;


    [SerializeField] private Image textPanelImage;

    bool isFirstColor = true;
    public string playerName;

    [SerializeField] private GameObject[] initialTabletopGameObjects;

    [SerializeField] private GameObject answerButtonsPanel;


    [SerializeField] private GameObject firstPanel;


    private void Start()
    {
        audioSourceGameObject.SetActive(false);
        playerName = PlayerPrefs.GetString("Player Name");

        for(int i = 0; i < initialTabletopGameObjects.Length; i++)
        {
           initialTabletopGameObjects[i].SetActive(false);  
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //If can Start Dialogue
            if (canStartDialogue == true)
            {
                //canTalk a true perque comenci la primera linea de dialeg
                canTalk = true;

                //canStartDialogue a false perque nomes serveix pel primer cop per activar el dialeg 1.
                canStartDialogue = false;
            }

            // If canStartDialogue && playerIsAnswering == false
            else if (canStartDialogue == false && playerIsAnswering == false)
            {
                //Activar el Dialogue Text Panel
                dialogueTextPanel.SetActive(true);

                //hasEndedTyping (Quan ha acabat d'escriure el autoType del dialeg o s'ha skipejat el autoType)
                if (hasEndedTyping)
                {
                    //Passar a la seguent linea de dialeg
                    dialogueLine++;

                    LineJump();

                    //canTalk a true per poder cirdar la funcio DialogueTalk();
                    canTalk = true;
                }

                //Si hasEndedTyping es false
                if (hasEndedTyping == false)
                {
                    //Posal a true
                    hasEndedTyping = true;
                }
            }
        }

        //If canTalk
        if (canTalk)
        {
            //Funcio dels dialegs
            DialogueTalk();
        }
    }

    //Logica del TypeText (passar el text amb el que vols escriure al string textContent de la funcio)
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
                if (textContent.Substring(printIndex, 1) == "<")
                {
                    if (isFirstColor)
                    {
                        printIndex += 17;
                        isFirstColor = false;
                        Debug.Log("First Jump");
                    }

                    else
                    {
                        printIndex += 8;
                        isFirstColor = true;
                        Debug.Log("Second Jump");
                    }

                }

                dialogueText.text = textContent.Substring(0, printIndex);

                if (printIndex % 3 == 0 && textContent.Substring(0, printIndex) != "")
                {

                    playSound.playEffect();

                }
                yield return new WaitForSeconds(0.04f);
                //yield return new WaitForSeconds(0.5f);
            }
        }
    }

    void LineJump()
    {

    }

    private void DialogueTalk()
    {
        //Depenent del valor del contador de lineas (dialogueLine) que es faci el dialeg corresponent al numero del contador
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
                DialogueLine5part2();
                break;

            case 7:
                DialogueLine6();
                break;

            case 8:
                DialogueLine6part2();
                break;

            case 9:
                DialogueLine7();
                break;

            case 10:
                DialogueLine8();
                break;

            case 11:
                DialogueLine9();
                break;

            case 12:
                DialogueLine10();
                break;

            case 13:
                DialogueLine11();
                break;

            case 14:
                DialogueLine12();
                break;

            case 15:
                DialogueLine13();
                break;
        }
    }

    private void DialogueLine0()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = playerName + ", the game I chose�";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine1()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "Is a card game! Gambling is my guilty pleasure�";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "My favorite thing in the damn world!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine3()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "Here I thought we would have some kind of strategy game� But okay, whatever you want, Luis.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        tagGameObject.SetActive(false);
        textPanelImage.sprite = normalPanelSprite;
    }

    private void DialogueLine4()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "It goes like this�";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine5()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "We have 4 types of cards.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine5part2()
    {
        //ROHE
        //(Es mostren les 4 cartes per pantalla)

        dialogueTextPanel.SetActive(false);
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }
    private void DialogueLine6()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "I deal 3 different types of cards, as you can see, two visible and one unrevealed.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine6part2()
    {
        //ROHE
        //(Es barallen les cartes i es posen sobre la taula (rollo 2 visibles i 1 boca abaix com quan dones a deal)

        dialogueTextPanel.SetActive(false);
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(false);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine7()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "The ones you see will always be different between them.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine8()
    {
        //ROHE
        //(Apareix el bot� de Play i fa una demostracio del joc sense aposta (apretes play i es revela la carta i tot normal pero sense aposta)

        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "The point of the game is to bet on the card you think will match the mysterious one!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine9()
    {
        //ROHE
        //(Apareixen les fitxes)

        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "How do you bet? Simply grab one of the tokens and place it on the card you think is the correct one!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine10()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "Simple isn�t it?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine11()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "What if I think none of the cards match with the unrevealed one?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(false);
        textPanelImage.sprite = normalPanelSprite;
    }

    private void DialogueLine12()
    {
        //ROHE
        //(Apareix el boto de doubt)

        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "In that case, use Doubt� If you guessed correctly and none match, you win!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine13()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "Ready " + playerName + "?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(true);
        textPanelImage.sprite = luisPanelSprite;
    }

    private void DialogueLine14()
    {
        answerButtonsPanel.SetActive(true);
        dialogueTextPanel.SetActive(false);
    }

    public void YesFunctionButton()
    {
        dialogueLine++;
    }

    public void NoFunctionButton()
    {
        dialogueLine = 4;
        answerButtonsPanel.SetActive(false);
    }

    private void DialogueLine15()
    {
        dialogueTextPanel.SetActive(false);
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        tagGameObject.SetActive(false);
        answerButtonsPanel.SetActive(false);

        StartMonte();
    }

    public void StartMonte()
    {

    }
}

