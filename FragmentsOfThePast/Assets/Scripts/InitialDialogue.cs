using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;
using Cinemachine;

public class InitialDialogue : MonoBehaviour
{
    //Dialogue Text
    [SerializeField] TextMeshProUGUI dialogueText;

    //Game Manager Script
    [SerializeField] GameManager_Script gameManager_Script;

    //Text to write
    [SerializeField] string texToToWrite;

    //Dialogue Line Counter
    [SerializeField] int dialogueLine;

    //Bool canTalk
    [SerializeField] bool canTalk = false;

    //Bool hasEndedTyping
    [SerializeField] bool hasEndedTyping;

    //Bool canStartDialogue
    [SerializeField] bool canStartDialogue = true;

    //Dialogue Panel
    public GameObject dialogueTextPanel;

    //3 Answers Panel
    [SerializeField] GameObject answerButtonsPanel;

    //Second Answer Button
    [SerializeField] GameObject middleButtonPanel;

    //First Answer Button
    [SerializeField] GameObject leftButtonPanel;

    //Third Answer Button
    [SerializeField] GameObject rightButtonPanel;

    //Bool playerIsAnswering
    [SerializeField] bool playerIsAnswering;

    //First Answer Button Text
    [SerializeField] TextMeshProUGUI button1AnswerText;

    //Second Answer Button Text
    [SerializeField] TextMeshProUGUI button2AnswerText;

    //Third Answer Button Text
    [SerializeField] TextMeshProUGUI button3AnswerText;

    //Background Image Street/God at the beggining
    [SerializeField] Image streetPanelImage;

    //Sprite Street Background
    [SerializeField] Sprite streetBackgroundSprite;

    //Sprite Dark Street Background
    [SerializeField] Sprite streetDarkBackgroundSprite;
    
    
    [SerializeField] Sprite flowerSpaceBackgroundSprite;
    [SerializeField] Sprite blackGalaxyBackgroundSprite;
    [SerializeField] Sprite intro1Background;
    [SerializeField] Sprite intro2Background;
   // [SerializeField] Sprite intro3Background;

    [SerializeField] Animator animator;

    //Sound 0
    [SerializeField] PlaySound playSound;

    //Sound 1
    [SerializeField] PlaySound playSound1;

    //Sound 2
    [SerializeField] PlaySound playSound2;

    //Audio Source
    [SerializeField] AudioSource audioSource;

    //Clip Hooded Man Theme
    [SerializeField] AudioClip hoodedManMusic;

    //Clip Intro Theme
    [SerializeField] AudioClip introMusic;

    //CLip Street Theme
    [SerializeField] AudioClip streetMusic;

    //Bools de logica para la musica de fondo (NO SOUND EFFECTS)
    private bool canPlayMusicLine14 = true;
    private bool canPlayMusicLine31 = true;

    //Panel Invisible (Ask Arnau for More)
    [SerializeField] GameObject startHoodedManButtonGameObject;

    //Background del Text Panel
    [SerializeField] Image textPanelImage;

    //Text Panel Dark Sprite
    [SerializeField] Sprite TextPanelDarkSprite;

    //Text Panel Normal Sprite
    [SerializeField] Sprite TextPanelNormalSprite;
   
    //Hooded Man Image
    [SerializeField] GameObject hoodedManImage;

    //Marina
    [SerializeField] GameObject marinaSadImage;
    [SerializeField] GameObject marinaSurpriseImage;
    [SerializeField] GameObject marinaHappyImage;

    //Bruno
    [SerializeField] GameObject brunoSadImage;
    [SerializeField] GameObject brunoSurpriseImage;
    [SerializeField] GameObject brunoAngryImage;
    [SerializeField] GameObject brunoShyImage;

    //Carmen
    [SerializeField] GameObject carmenAngerImage;
    [SerializeField] GameObject carmenHappyImage;
    [SerializeField] GameObject carmenSurprisedImage;


    //Luis
    [SerializeField] GameObject luisSurpriseImage;
    [SerializeField] GameObject luisHappyImage;


    //Group
    [SerializeField] GameObject groupImage;

    //Spirit Name Text
    [SerializeField] TextMeshProUGUI spiritNameText;

    [SerializeField] Animator cinematicAnim;
    [SerializeField] GameObject streetPanelIntroGameObject;
    [SerializeField] GameObject streetPanelGameObject;

    public bool canReturnToDialogue;

    [SerializeField] LoadManager loadManager;

    [SerializeField] ScreenShake cameraShake;

    bool isFirstColor = true;

    public bool isConquistador;
    public bool isOrden;

    [SerializeField] private GameObject conquistadorPanel;
    [SerializeField] private GameObject ordenPanel;


    private void Start()
    {

        loadManager.loadGame = PlayerPrefs.GetInt("loadManager.loadGame") == 1 ? true : false;

        if (loadManager.loadGame)
        {
            loadManager.Load();
        }

        if (loadManager.introFinished == true)
        {
            dialogueLine = 14;
            //loadManager.introFinished = false;
        }

        if (loadManager.prologueFinished == true)
        {
            dialogueLine = 67;
            //loadManager.prologueFinished = false;
        }
        
    }
    private void Update()
    {
        //GoTo68();
        //If Left CLick
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
            else if (canStartDialogue == false && playerIsAnswering==false)
            {
                //Activar el Dialogue Text Panel
                dialogueTextPanel.SetActive(true);

                //hasEndedTyping (Quan ha acabat d'escriure el autoType del dialeg o s'ha skipejat el autoType)
                if (hasEndedTyping)
                {
                    //Passar a la seguent linea de dialeg
                    dialogueLine++;

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

        //Hacks
        if (Input.GetKeyDown("a"))
        {
            //DialogueLine67();
        }

       
    }

    //Logica del TypeText (passar el text amb el que vols escriure al string textContent de la funcio)
    IEnumerator TypeText (string textContent)
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
                if(textContent.Substring(printIndex, 1) == "<")
                {
                    if(isFirstColor)
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

                if(printIndex%3 == 0 && textContent.Substring(0, printIndex) != "")
                {
                    playSound.playEffect();
                }

                yield return new WaitForSeconds(0.04f);
                //yield return new WaitForSeconds(0.5f);
            }
        }
    }

    // Logica de dialogos
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
                DialogueLine4dot1();
                break;

            case 6:
                DialogueLine4dot2();
                break;

            case 7:
                DialogueLine5();
                break;

            case 8:
                DialogueLine6();
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

            case 16:
                DialogueLine14();
                break;

            case 17:
                DialogueLine15();
                break;

            case 18:
                DialogueLine16();
                break;

            case 19:
                DialogueLine17();
                break;

            case 20:
                DialogueLine18();
                break;

            case 21:
                DialogueLine19();
                break;

            case 22:
                DialogueLine20();
                break;

            case 23:
                DialogueLine21();
                break;

            case 24:
                DialogueLine22();
                break;

            case 25:
                DialogueLine23();
                break;

            case 26:
                DialogueLine24();
                break;

            case 27:
                DialogueLine25();
                break;

            case 28:
                DialogueLine26();
                break;

            case 29:
                DialogueLine27();
                break;

            case 30:
                DialogueLine28();
                break;

            case 31:
                DialogueLine29();
                break;

            case 32:
                DialogueLine30();
                break;

            case 33:
                DialogueLine31();
                break;

            case 34:
                DialogueLine32();
                break;

            case 35:
                DialogueLine33();
                break;

            case 36:
                DialogueLine34();
                break;

            case 37:
                DialogueLine35();
                break;

            case 38:
                DialogueLine36();
                break;

            case 39:
                DialogueLine37();
                break;

            case 40:
                DialogueLine38();
                break;

            case 41:
                DialogueLine39();
                break;

            case 42:
                DialogueLine40();
                break;

            case 43:
                DialogueLine41();
                break;

           case 44:
                DialogueLine42();
                break;

            case 45:
                DialogueLine43();
                break;
 /*
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
                break;*/
        }
    }
    
    private void DialogueLine0()
    {
        dialogueTextPanel.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "In a world where the living and the dead had always remained separate, the once-firm boundaries between realms began to <color=#000000ff>fracture.</color>";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        animator.SetBool("canPlayFadeIn", true);
        streetPanelImage.sprite = flowerSpaceBackgroundSprite;
        spiritNameText.text = " ";
    }

    private void DialogueLine1()
    {
        hasEndedTyping = false;
        spiritNameText.text = " ";
        texToToWrite = "Bizarre events have led to the blurring of boundaries, with spirits crossing over into the land of the living and vice versa. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        hasEndedTyping = false;
        spiritNameText.text = " ";
        texToToWrite = "Ghostly apparitions among the living have created a sense of unease and confusion between both the spirits and living.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine3()
    {
        hasEndedTyping = false;
        texToToWrite = "As the convergence of the realms threatens to reshape the fabric of reality, scientists and spiritists are struggling to comprehend the cause of these events.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4()
    {
        hasEndedTyping = false;
        texToToWrite = "Fear and anxiety have gripped the population...";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine4dot1()
    {
        hasEndedTyping = false;
        texToToWrite = "And very few who are gifted with paranormal abilities are able to restore the balance between the realms";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4dot2()
    {
        hasEndedTyping = false;
        texToToWrite = "Or face the unknown consequences of their convergence.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine5()
    {
        hasEndedTyping = false;
        texToToWrite = "You… You are one of the gifted ones, a spiritist with a natural ease and innate ability to see and interact with the realm of the dead. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;  
    }

    private void DialogueLine6()
    {
        hasEndedTyping = false;
        texToToWrite = "In a world where such talents are rare, your unique connection to the spirits sets you apart.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine7()
    {
        hasEndedTyping = false;
        texToToWrite = "But… Who are you?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine8()
    {
        hasEndedTyping = false;
        texToToWrite = "You find a wallet filled with cash and identification. Do you return it to its owner, knowing they might be in dire need of the money?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine9()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "Return the wallet to his owner.";
        button2AnswerText.text = "Keep the money for yourself but you return the other documents.";
        button3AnswerText.text = "Take the entire wallet, bad luck.";
        playerIsAnswering = true;
    }

    public void DialogueLine9Answer1()
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

    public void DialogueLine9Answer2()
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

    public void DialogueLine9Answer3()
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


    private void DialogueLine10()
    {
        hasEndedTyping = false;
        texToToWrite = "You discover that someone you trust has betrayed you, but revealing the truth could harm them and others involved.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine11()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);

        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);

        button1AnswerText.text = "Forgive the betrayal and keep the truth hidden to avoid unnecessary pain and conflict";
        button2AnswerText.text = "Confront the betrayal and seek closure is for personal healing and integrity";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine11Answer1()
    {
        if (dialogueLine == 13)
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
        if (dialogueLine == 13)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine12()
    {
        hasEndedTyping = false;
        texToToWrite = "You are on your way to an event that you have been waiting for a long time and you see a neighbor’s dog who has been missing for days and follows you in search of help.\r\n\r\n";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine13()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);

        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);

        button1AnswerText.text = "Continue on your way ignoring the dog and you arrive at time to the event.";
        button2AnswerText.text = "Go back and take the dog with it’s owner.";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine13Answer1()
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

    public void DialogueLine13Answer2()
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

    private void DialogueLine14()
    {
        hasEndedTyping = false;
        texToToWrite = "You have insider information that could give you an unfair advantage in a business deal.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine15()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);

        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);

        button1AnswerText.text = "Exploit the information for personal gain, disregarding the potential harm it may cause to others.";
        button2AnswerText.text = "Refuse to use it, opting for fair and ethical practices";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine15Answer1()
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

    public void DialogueLine15Answer2()
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

    private void DialogueLine16()
    {
        hasEndedTyping = true;
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(false);
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        if (isConquistador)
        {
            conquistadorPanel.SetActive(true);
        }

        else if (isOrden)
        {
            ordenPanel.SetActive(true);
        }


        FadeInAnim();

        streetPanelImage.sprite = blackGalaxyBackgroundSprite;
    }

    private void DialogueLine17()
    {
        conquistadorPanel.SetActive(false);
        ordenPanel.SetActive(false);
        dialogueTextPanel.SetActive(true);

        hasEndedTyping = false;
        texToToWrite = "You step into the breach between the realms, your heart pounding with anticipation…";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        streetPanelImage.sprite = intro1Background;
    }

    private void DialogueLine18()
    {
        hasEndedTyping = false;
        texToToWrite = "Pain shoots through your limbs as if you're being pulled in two directions at once, the dissonance between the living and the dead realms tearing at your very essence.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine19()
    {
        hasEndedTyping = false;
        texToToWrite = "It feels inherently wrong, a violation of the natural order of things, yet your determination drives you forward despite the overwhelming discomfort.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine20()
    {
        hasEndedTyping = false;
        texToToWrite = "It feels like wading through thick, viscous fog, each step an agonizing struggle against unseen forces.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        streetPanelImage.sprite = intro2Background;
        cameraShake.Shake();
    }

    private void DialogueLine21()
    {
        hasEndedTyping = false;
        texToToWrite = "Amidst the swirling void, a figure emerges, cloaked in darkness and mystery, their presence ominous and foreboding.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        hoodedManImage.SetActive(true);

        FadeInHoodedMain();
    }

    private void DialogueLine22()
    {
        hasEndedTyping = false;
        texToToWrite = "You lock eyes with the enigmatic figure, a sense of dread mingling with curiosity as you approach cautiously.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine23()
    {
        hasEndedTyping = false;
        texToToWrite = "Their black hood obscures their features, but… You know he is like you, a spiritist.\r\n";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine24()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "Approach";
        button2AnswerText.text = "Ignore";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }


    public void DialogueLine24Answer1()
    {
        if (dialogueLine == 26)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine24Answer2()
    {
        if (dialogueLine == 26)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }


    /// <summary>
    /// ///
    /// </summary>

    private void DialogueLine25()
    {
        hasEndedTyping = false;
        spiritNameText.text = "???";
        texToToWrite = "Hey there, friend, you seem a bit out of place. Are you lost…? Need someone to show you how to navigate the breach?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine26()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Sure, why not?";
        button2AnswerText.text = "(Cautious) Thanks, but I'll navigate this place solo. No offense.";
        button3AnswerText.text = "(Rude) No guide needed. Move along, creep.";
        playerIsAnswering = true;
    }

    public void DialogueLine26Answer1()
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

    public void DialogueLine26Answer2()
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

    public void DialogueLine26Answer3()
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


    private void DialogueLine27()
    {
        hasEndedTyping = false;
        spiritNameText.text = "???";
        texToToWrite = "You know, I couldn't help but notice... your breathing, rhythmic and alive, you still maintain your humanity…  ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine28()
    {
        hasEndedTyping = false;
        texToToWrite = "You are a spiritist… I can feel your aura, it ripples with power around you.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine29()
    {
        hasEndedTyping = false;
        texToToWrite = "The subtle rise and fall of your chest… It's fascinating, really. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine30()
    {
        hasEndedTyping = false;
        texToToWrite = "Can you feel your heartbeat, each pulse a reminder of your existence in this... transitional state, here in the breach?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine31()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Creeped Out) Too much info... Back off with the anatomy analysis.";
        button2AnswerText.text = "(Denial) Alive, dead, who knows? Just leave me be, okay?";
        button3AnswerText.text = "(Rude) Maybe a psychologist would care about your deep thoughts. Not me, though.";
        playerIsAnswering = true;
    }

    public void DialogueLine31Answer1()
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

    public void DialogueLine31Answer2()
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

    public void DialogueLine31Answer3()
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


    private void DialogueLine32()
    {
        hasEndedTyping = false;
        texToToWrite = "(In a quick movement, he approaches you and holds your throat strongly, choking you, you can feel his powers draining yours, he is… stealing your powers to add them to his array!)";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        cameraShake.Shake();
    }

    private void DialogueLine33()
    {
        hasEndedTyping = false;
        texToToWrite = "You are very naive if you think you can walk around here like Alice in Wonderland…";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine34()
    {
        hasEndedTyping = false;
        texToToWrite = "The man sneers, his grip tightening around your throat.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine35()
    {
        hasEndedTyping = false;
        texToToWrite = "Carefree, like a damn lost child.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine36()
    {
        hasEndedTyping = false;
        texToToWrite = "As he tries to drain your powers, a sudden resistance surges within you, causing him to falter.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine37()
    {
        hasEndedTyping = false;
        texToToWrite = "Gasping for air, you feel a surge of energy coursing through your veins, your powers too potent for him to overcome.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine38()
    {
        hasEndedTyping = false;
        texToToWrite = " You`re stronger than I anticipated… But I don’t mind making this story a little longer, after all… I do love a good chase. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine39()
    {
        hasEndedTyping = false;
        texToToWrite = "Don’t think you are special, you are not the only one looking for the source of all this events.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine40()
    {
        hasEndedTyping = false;
        texToToWrite = "As he disappears into the shadows, you feel very tired, your throat hurts, you cough and search desperately for air, there is not much time to find the exit.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine41()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        rightButtonPanel.SetActive(false);
        button1AnswerText.text = "Run Forward, there is no point in returning!";
        button2AnswerText.text = "Run Backwards, to where you came from.";
        button3AnswerText.text = "";
        playerIsAnswering = true;
    }

    public void DialogueLine41Answer1()
    {
        if (dialogueLine == 43)
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
        if (dialogueLine == 43)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine42()
    {
        hasEndedTyping = false;
        texToToWrite = "You try to move, but it is useless… As run, you begin to lose consciousness, a scent fills the air—candles and marigolds.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine43()
    {
        hasEndedTyping = false;
        texToToWrite = "It's comforting but darkness envelops you entirely and you feel yourself falling unconscious.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    /*
    private void DialogueLine44()
    {
        luisHappyImage.SetActive(false);
        carmenHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Carmen";
        playSound2.playEffect();
        texToToWrite = "We can't just 'keep' a living person, Marina. And Luis, this is serious.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine45()
    {
        hasEndedTyping = false;
        texToToWrite = "We need to figure out how to retrieve our memories and deal with that hooded nuisance.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine46()
    {
        carmenHappyImage.SetActive(false);
        luisHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        playSound2.playEffect();
        texToToWrite = "Seriousness is boring. Let's spice it up! Living friend, got any wild ideas on how to catch that memory thief?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine47()
    {
        luisHappyImage.SetActive(false);
        brunoAngryImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Bruno";
        playSound2.playEffect();
        texToToWrite = "I don't think 'spicing it up' is the best approach. We need a plan, not chaos.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine48()
    {
        brunoAngryImage.SetActive(false);
        marinaHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        playSound2.playEffect();
        texToToWrite = "Oh, I have an idea! What if we throw a party and invite all the spirits? The hooded guy might show up, and we can surprise him!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine49()
    {
        marinaHappyImage.SetActive(false);
        carmenSurprisedImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Carmen";
        playSound2.playEffect();
        texToToWrite = "A party won't solve anything. We need to be strategic and find a way to track that thief. Living friend, any input here?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine50()
    {
        carmenSurprisedImage.SetActive(false);
        answerButtonsPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        leftButtonPanel.SetActive(false);
        rightButtonPanel.SetActive(false);
        dialogueTextPanel.SetActive(false);

        button2AnswerText.text = "(Explain all you know)";

        playerIsAnswering = true;
    }

    public void DialogueLine50Answer2()
    {
        if (dialogueLine == 50)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            middleButtonPanel.SetActive(true);
            leftButtonPanel.SetActive(true);
            rightButtonPanel.SetActive(true);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine51()
    {
        carmenAngerImage.SetActive(true);
        hasEndedTyping = false;
        playSound2.playEffect();
        texToToWrite = "So, we have a mystical guide, a memory thief, and a living person in the afterlife. Perfect. Just what we needed.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine52()
    {
        carmenAngerImage.SetActive(false);
        brunoSurpriseImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Bruno";
        playSound2.playEffect();
        texToToWrite = "Wait, you're a spirit guide? That's amazing! We're in good hands, right? Spirit guides are rare to encounter.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine53()
    {
        brunoSurpriseImage.SetActive(false);
        marinaSurpriseImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        playSound2.playEffect();
        texToToWrite = "A spirit guide! That's so cool! We're like protagonists of a story, like in the novelas I watch all the time!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine54()
    {
        marinaSurpriseImage.SetActive(false);
        luisHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        playSound2.playEffect();
        texToToWrite = "Living person in the dead realm, a mysterious god-like voice, and a memory thief. Now, that's a party!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine55()
    {
        hasEndedTyping = false;
        texToToWrite = "Count me in, especially if the spirit guide is this handsome human we have here… I don’t mind some time alone with ya";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine56()
    {
        luisHappyImage.SetActive(false);
        carmenHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Carmen";
        playSound2.playEffect();
        texToToWrite = "Enough with the excitement. We need a plan. Chasing the hooded guy won't get us anywhere. How do we use our new friend here to retrieve our memories?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine57()
    {
        carmenHappyImage.SetActive(false);
        answerButtonsPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        leftButtonPanel.SetActive(false);
        rightButtonPanel.SetActive(false);
        dialogueTextPanel.SetActive(false);

        button2AnswerText.text = "I have a special trait that can recover memories!";

        playerIsAnswering = true;
    }

    public void DialogueLine57Answer2()
    {
        if (dialogueLine == 57)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            middleButtonPanel.SetActive(true);
            leftButtonPanel.SetActive(true);
            rightButtonPanel.SetActive(true);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine58()
    {
        brunoShyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Bruno";
        playSound2.playEffect();
        texToToWrite = "I’m in… It’s not like I have anything better to do… My name is Bruno by the way.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine59()
    {
        brunoShyImage.SetActive(false);
        carmenHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Carmen";
        playSound2.playEffect();
        texToToWrite = "I for once agree with Bruno, my name is Carmen, it is a pleasure to meet you.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine60()
    {
        carmenHappyImage.SetActive(false);
        marinaHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        playSound2.playEffect();
        texToToWrite = "Oh, sharing memories? That sounds like fun! I'm all for it! My name’s Marina!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine61()
    {
        marinaHappyImage.SetActive(false);
        luisHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        playSound2.playEffect();
        texToToWrite = "This is starting to sound like group therapy… But yeah, well, whatever, I will play along. Name is Luis. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine62()
    {
        hasEndedTyping = false;
        texToToWrite = "Hey, living friend, got a name? I can't keep calling you 'living friend' all the time, or well, maybe you prefer different nicknames, hm?~";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine63()
    {
        luisHappyImage.SetActive(false);
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = gameManager_Script.playerName + ", that is my name…";
        button2AnswerText.text = gameManager_Script.playerName + ".";
        button3AnswerText.text = gameManager_Script.playerName + ", nice to meet you all!";
        playerIsAnswering = true;
    }

    public void DialogueLine63Answer1()
    {
        if (dialogueLine == 63)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine63Answer2()
    {
        if (dialogueLine == 63)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine63Answer3()
    {
        if (dialogueLine == 63)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }
    private void DialogueLine64()
    {
        marinaHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        playSound2.playEffect();
        texToToWrite = "Oh " + gameManager_Script.playerName + "! What a beautiful name! I can't wait to get to know you better.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine65()
    {
        hasEndedTyping = false;
        texToToWrite = "We'll be around the street outside your consult, just soaking in the afterlife vibes, waiting for our turns for these spirit-guiding sessions.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine66()
    {
        hasEndedTyping = false;
        texToToWrite = "Can't wait to get my memories back! We count on you, spirit guide!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine67()
    {
        dialogueTextPanel.SetActive(false);
        marinaHappyImage.SetActive(false);
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        playerIsAnswering = true;
        canPlayMusicLine14 = false;
        audioSource.enabled = false;
        audioSource.clip = streetMusic;
        audioSource.enabled = true;
        streetPanelGameObject.SetActive(true);
        cinematicAnim.SetBool("canPlayAnim", true);
        streetPanelIntroGameObject.SetActive(false);

        loadManager.introFinished= false;
        loadManager.prologueFinished= true;
        loadManager.Save();
    }

    private void GoTo68()
    {
        if(dialogueLine == 67 && canReturnToDialogue)
        {
        }
    }

    */


    void FadeInAnim()
    {
        if (animator.GetBool("canPlayFadeIn"))
        {
            animator.SetBool("canPlayFadeIn", false);
            animator.SetBool("canPlayHoodedManFadeIn", false);
        }

        else if (!animator.GetBool("canPlayFadeIn"))
        {
            animator.SetBool("canPlayFadeIn", true);
            animator.SetBool("canPlayHoodedManFadeIn", false);
        }
    }

    void FadeInHoodedMain()
    {
        animator.SetBool("canPlayHoodedManFadeIn", true); 
    }

}


