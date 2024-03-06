using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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


    bool isFirstColor = true;





    [SerializeField] private GameObject firstPanel;


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
                //DialogueLine0();
                break;
        }
    }
}
