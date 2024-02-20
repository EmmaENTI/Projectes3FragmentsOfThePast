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
    [SerializeField] Sprite blackImageBackground;
    [SerializeField] Sprite quasimanSpriteBackground;

    [SerializeField] Animator animator;

    //Sound 0
    [SerializeField] PlaySound playSound;

    //Sound 1
    [SerializeField] PlaySound playSound1;

    //Sound 2
    [SerializeField] PlaySound playSound2;

    //Sound 4
    [SerializeField] PlaySound playSound4;

    //Sound 5
    [SerializeField] PlaySound playSound5;

    //Sound 6
    [SerializeField] PlaySound playSound6;

    //Sound 7
    [SerializeField] PlaySound playSound7;

    //Sound 8
    [SerializeField] PlaySound playSound8;

    //Sound 9
    [SerializeField] PlaySound playSound9;


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
    private bool canChooseOrigin = true;

    [SerializeField] private GameObject conquistadorPanel;
    [SerializeField] private GameObject ordenPanel;

    [SerializeField] private GameObject textPanelBackgroundGameObject;
    [SerializeField] private GameObject dialogueTextGameObject;
    [SerializeField] private GameObject dialogueFrameUpGameObject;
    [SerializeField] private GameObject dialogueFrameDownGameObject;
   
    [SerializeField] private GameObject darkerFilterPanel;

    public AudioClip whoAreYou;
    public AudioClip breachClip;
    public GameObject audioSourceGameObject;

    private bool canChangeSound1 = true;
    private bool canChangeSound2 = true;
    private bool canChangeSound3 = true;
    private bool canChangeSound4 = true;

    private bool canPlayEffectSound = true;

    bool isWhoAreYou;
    bool hoodedManText;


    private int benignityPoints;

    [SerializeField] GameObject saveIcon;

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
                    if(!isWhoAreYou && !hoodedManText)
                    {
                        playSound.playEffect();
                    }

                    else if(isWhoAreYou)
                    {
                        playSound6.playEffect();
                    }

                    else if(hoodedManText)
                    {
                        playSound7.playEffect();
                    }
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
/*
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

            case 46:
                DialogueLine44();
                break;*/
                /*
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

        animator.SetBool("canPlayAnim0", true);
        streetPanelImage.sprite = flowerSpaceBackgroundSprite;
        textPanelImage.sprite = TextPanelNormalSprite;
        spiritNameText.text = " ";
    }

    private void DialogueLine1()
    {
        hasEndedTyping = false;
        spiritNameText.text = "";
        texToToWrite = "Spirits are appearing among the living and viceversa.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {
        hasEndedTyping = false;
        spiritNameText.text = " ";
        texToToWrite = "Scientists and spiritists are trying to understand what's going on, but fear is spreading.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine3()
    {
        hasEndedTyping = false;
        texToToWrite = "Both between living and nonliving.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine4()
    {
        hasEndedTyping = false;
        texToToWrite = "Only a few gifted people like you, who can <color=#000000ff>interact with spirits</color>, can help restore balance between the realms.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine5()
    {
        hasEndedTyping = false;
        texToToWrite = "You're one of these gifted individuals, with a natural talent for connecting with the dead.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;  
    }


    private void DialogueLine6()
    {
        hasEndedTyping = false;
        texToToWrite = "But… Who are you?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        animator.SetBool("canPlayAnim1", true);




       if (canChangeSound1)
       {
            audioSourceGameObject.SetActive(false);
            canChangeSound1 = false;
       }

        audioSource.clip = whoAreYou;

        audioSourceGameObject.SetActive(true);

        isWhoAreYou = true;

    }

    private void DialogueLine7()
    {
        hasEndedTyping = false;
        texToToWrite = "You find a wallet with money and ID inside. Would you give it back to the owner or keep it to yourself?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        textPanelBackgroundGameObject.SetActive(false);
        dialogueTextGameObject.transform.position = dialogueFrameUpGameObject.transform.position;
        darkerFilterPanel.SetActive(false);
    }

    private void DialogueLine8()
    {
        //dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "Return the wallet to his owner.";
        button2AnswerText.text = "Keep the money for myself but I return the other documents.";
        button3AnswerText.text = "Take the entire wallet.";
        playerIsAnswering = true;
        darkerFilterPanel.SetActive(true);

        if(canPlayEffectSound)
        {
            playSound6.playEffect();
            canPlayEffectSound = false;
        }
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
            playSound4.playEffect();

            benignityPoints += 2;
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
            dialogueLine++;
            playSound4.playEffect();

            benignityPoints += 1;
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
            dialogueLine++;
            playSound4.playEffect();

            benignityPoints -= 2;
        }
    }


    private void DialogueLine9()
    {
        hasEndedTyping = false;
        texToToWrite = "You have secret information that could help you in a business deal. Will you choose not to use it, and instead, play fair and do what's right?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        darkerFilterPanel.SetActive(false);
        canPlayEffectSound = true;
    }

    private void DialogueLine10()
    {
        //dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);

        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);

        button1AnswerText.text = "Use it, it is an advantage I need.";
        button2AnswerText.text = "Not use it, it is better to play fair and do what is right.";
        button3AnswerText.text = "";
        playerIsAnswering = true;
        darkerFilterPanel.SetActive(true);

        if (canPlayEffectSound)
        {
            playSound6.playEffect();
            canPlayEffectSound = false;
        }
    }

    public void DialogueLine10Answer1()
    {
        if (dialogueLine == 10)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound4.playEffect();

            benignityPoints -= 1;
        }
    }

    public void DialogueLine10Answer2()
    {
        if (dialogueLine == 10)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound4.playEffect();

            benignityPoints += 1;
        }
    }

    private void DialogueLine11()
    {
        hasEndedTyping = false;
        texToToWrite = "You witness an authority figure abusing their power and causing harm to others. Would you speak out against injustice, even if it means putting yourself at risk, or would you prefer to stay silent to avoid trouble?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        darkerFilterPanel.SetActive(false);

        canPlayEffectSound = true;
    }

    private void DialogueLine12()
    {
        //dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);

        leftButtonPanel.SetActive(true);
        middleButtonPanel.SetActive(true);
        rightButtonPanel.SetActive(false);

        button1AnswerText.text = "Yes, I'll speak out, even if it's risky.";
        button2AnswerText.text = "No, I'd rather avoid trouble and stay quiet.";
        button3AnswerText.text = "";
        playerIsAnswering = true;
        darkerFilterPanel.SetActive(true);

        if (canPlayEffectSound)
        {
            playSound6.playEffect();
            canPlayEffectSound = false;
        }

    }

    public void DialogueLine12Answer1()
    {
        if (dialogueLine == 12)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound4.playEffect();

            benignityPoints += 1;
        }
    }

    public void DialogueLine12Answer2()
    {
        if (dialogueLine == 12)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound4.playEffect();

            benignityPoints -= 1;
        }
    }

    private void DialogueLine13()
    {
        hasEndedTyping = true;
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(false);
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        if(canChooseOrigin)
        {
            if(benignityPoints >= 0)
            {
                isOrden = true;
            }
            else if(benignityPoints < 0) 
            {
                isConquistador = true;
            }

            canChooseOrigin = false;
        }

        if (isConquistador)
        {
            conquistadorPanel.SetActive(true);
        }

        else if (isOrden)
        {

            ordenPanel.SetActive(true);
        }


        animator.SetBool("canPlayAnim2", true);

        streetPanelImage.sprite = blackGalaxyBackgroundSprite;
        darkerFilterPanel.SetActive(false);

        playSound5.playEffect();
        isWhoAreYou = false;
    }


    private void DialogueLine14()
    {
        StartCoroutine(SaveIconTimer());
        conquistadorPanel.SetActive(false);
        ordenPanel.SetActive(false);
        dialogueTextPanel.SetActive(true);

        hasEndedTyping = false;
        texToToWrite = "You step into the breach between the realms, your heart pounding with anticipation…";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        streetPanelImage.sprite = intro1Background;
        animator.SetBool("canPlayAnim3", true);

        textPanelBackgroundGameObject.SetActive(true);
        dialogueTextGameObject.transform.position = dialogueFrameDownGameObject.transform.position;

        if (canChangeSound2)
        {
            audioSourceGameObject.SetActive(false);
            canChangeSound2 = false;
        }

        audioSource.clip = breachClip;

        audioSourceGameObject.SetActive(true);

    }

    private void DialogueLine15()
    {
        hasEndedTyping = false;
        texToToWrite = "Your body feels like it's being pulled apart, torn between the worlds of the living and the dead.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine16()
    {
        hasEndedTyping = false;
        texToToWrite = "It feels really strange and unsettling, against nature's way, but your strong will pushes you forward, even though it's uncomfortable.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine17()
    {
        hasEndedTyping = false;
        texToToWrite = "Moving forward feels really hard, like pushing through thick, heavy fog. Each step is a tough fight against things you can't even see.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        streetPanelImage.sprite = intro2Background;
    }

    private void DialogueLine18()
    {
        hasEndedTyping = false;
        texToToWrite = "From the swirling void, a mysterious figure appears, surrounded by darkness. Their presence feels eerie and threatening.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        //streetPanelImage.sprite = intro2Background;
        cameraShake.Shake();
        hoodedManImage.SetActive(true);
        
    }

    private void DialogueLine19()
    {
        hasEndedTyping = false;
        texToToWrite = "You lock eyes with the figure, a sense of dread mingling with curiosity as you approach cautiously.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        animator.SetBool("canPlayAnim4", true);

        if (canChangeSound3)
        {
            audioSourceGameObject.SetActive(false);
            canChangeSound3 = false;
        }

        audioSource.clip = hoodedManMusic;

        audioSourceGameObject.SetActive(true);
    }

    private void DialogueLine20()
    {
        hasEndedTyping = false;
        texToToWrite = "Their dark hood hides their face, but you can tell they're like you, a spiritist.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine21()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "Approach";
        button2AnswerText.text = "Ignore";
        button3AnswerText.text = "";
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
            dialogueLine++;
            playSound1.playEffect();
        }
    }


    private void DialogueLine22()
    {
        hasEndedTyping = false;
        texToToWrite = "Hey there, friend, you seem a bit out of place. Are you lost…? Need someone to show you how to navigate the breach?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        spiritNameText.text = "Hooded Man";
        textPanelImage.sprite = TextPanelDarkSprite;
        hoodedManText = true;
    }

    private void DialogueLine23()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Sure, why not?";
        button2AnswerText.text = "(Cautious) Thanks, but I'll navigate this place solo. No offense.";

        if(isConquistador)
        {
            button3AnswerText.text = "(Origin) No guide needed. Move along, creep.";
            rightButtonPanel.GetComponent<Image>().color = new Color32(57, 86, 255, 210);
        }

        else if(isOrden)
        {
            button3AnswerText.text = "(Origin) Thanks, but I'm not lost. I'm just exploring the breach by myself.";
            rightButtonPanel.GetComponent<Image>().color = new Color32(64, 175, 255, 210);

        }


        playerIsAnswering = true;
    }

    public void DialogueLine23Answer1()
    {
        if (dialogueLine == 23)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine23Answer2()
    {
        if (dialogueLine == 23)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine23Answer3()
    {
        if (dialogueLine == 23)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }


    private void DialogueLine24()
    {
        hasEndedTyping = false;
        spiritNameText.text = "Hooded Man";
        texToToWrite = "I can sense something about you... You're a spiritist, someone who can connect with the spirit world. Your energy feels strong and alive.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        hoodedManText = true;
    }


    private void DialogueLine25()
    {
        hasEndedTyping = false;
        texToToWrite = "The subtle rise and fall of your chest… It's fascinating, really.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        hoodedManText = true;
    }

    private void DialogueLine26()
    {
        hasEndedTyping = false;
        texToToWrite = "Can you feel your heart beating? It's a reminder that you're in this strange place called the breach, somewhere between life and death.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
        hoodedManText = true;
    }

    private void DialogueLine27()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        rightButtonPanel.SetActive(true);
        button1AnswerText.text = "(Creeped Out) Too much info... Back off with the anatomy analysis.";
        button2AnswerText.text = "(Denial) Alive, dead, who knows? Just leave me be, okay?";
        button3AnswerText.text = "(Rude) Maybe a psychologist would care about your deep thoughts. Not me, though.";
        playerIsAnswering = true;
        rightButtonPanel.GetComponent<Image>().color = new Color32(255, 255, 255, 210);
    }

    public void DialogueLine27Answer1()
    {
        if (dialogueLine == 27)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine27Answer2()
    {
        if (dialogueLine == 27)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine27Answer3()
    {
        if (dialogueLine == 27)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }


    private void DialogueLine28()
    {
        hasEndedTyping = false;
        texToToWrite = "Suddenly, he grabs you by the throat, squeezing tightly. You feel your strength fading as he tries to kill you.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        cameraShake.Shake();
        streetPanelImage.sprite = quasimanSpriteBackground;
        hoodedManImage.SetActive(false);

        spiritNameText.text = "";
        textPanelImage.sprite = TextPanelNormalSprite;
        hoodedManText = false;
        playSound8.playEffect();
    }

    private void DialogueLine29()
    {
        hasEndedTyping = false;
        texToToWrite = "You are very naive if you think you can walk around here like Alice in Wonderland…";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        spiritNameText.text = "Hooded Man";
        textPanelImage.sprite = TextPanelDarkSprite;
        hoodedManText = true;
    }

    private void DialogueLine30()
    {
        hasEndedTyping = false;
        texToToWrite = "The man sneers, squeezing your throat tighter.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        spiritNameText.text = "";
        textPanelImage.sprite = TextPanelNormalSprite;
        hoodedManText = false;
    }

    private void DialogueLine31()
    {
        hasEndedTyping = false;
        texToToWrite = "Carefree, like a damn lost child.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        spiritNameText.text = "Hooded Man";
        textPanelImage.sprite = TextPanelDarkSprite;
        hoodedManText = true;
    }

    private void DialogueLine32()
    {
        hasEndedTyping = false;
        texToToWrite = "As he tries to take your powers and hurt you, something inside you fights back.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;


        spiritNameText.text = "";
        textPanelImage.sprite = TextPanelNormalSprite;
        cameraShake.Shake();
        hoodedManText = false;
    }

    private void DialogueLine33()
    {
        hasEndedTyping = false;
        texToToWrite = "He starts to struggle, and you feel a burst of energy, too strong for him to handle.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine34()
    {
        hasEndedTyping = false;
        texToToWrite = "You're tougher than I thought! But I'm not in a hurry. I enjoy a good chase. You're not the only one searching for answers about what's happening.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        hoodedManImage.SetActive(true);
        streetPanelImage.sprite = intro2Background;
        cameraShake.Shake();

        spiritNameText.text = "Hooded Man";
        textPanelImage.sprite = TextPanelDarkSprite;
        hoodedManText = true;
    }

    private void DialogueLine35()
    {
        hasEndedTyping = false;
        texToToWrite = "As he vanishes, you feel exhausted, your throat hurts, and you struggle to breathe. Time is running out to find the way out.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        animator.SetBool("canPlayAnim5", true);

        spiritNameText.text = "";
        textPanelImage.sprite = TextPanelNormalSprite;
        hoodedManText = false;

        if (canChangeSound4)
        {
            audioSourceGameObject.SetActive(false);
            canChangeSound4 = false;
        }

        audioSource.clip = breachClip;

        audioSourceGameObject.SetActive(true);
        playSound9.playEffect();
    }

    private void DialogueLine36()
    {
        hasEndedTyping = false;
        texToToWrite = "As you run, you start to feel faint.A familiar smell fills the air - candles and marigolds.It's comforting, but then darkness takes over, and you fall unconscious.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    
    
    private void DialogueLine37()
    {
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;

        hoodedManImage.SetActive(false);
        dialogueTextPanel.SetActive(false);
        animator.SetBool("canPlayAnim6", true);
    }

    IEnumerator SaveIconTimer()
    {
        saveIcon.SetActive(true);
        yield return new WaitForSeconds(2f);
        saveIcon.SetActive(false);
    }
    /*

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


    /*void FadeInAnim()
    {
        if (animator.GetBool("canPlayFadeIn"))
        {
            animator.SetBool("canPlayFadeIn", false);
            animator.SetBool("canPlayHoodedManFadeIn", false);
            animator.SetBool("canPlayFadeOut", false);

        }

        else if (!animator.GetBool("canPlayFadeIn"))
        {
            animator.SetBool("canPlayFadeIn", true);
            animator.SetBool("canPlayHoodedManFadeIn", false);
            animator.SetBool("canPlayFadeOut", false);
        }
    }

    void FadeInHoodedMain()
    {
        animator.SetBool("canPlayHoodedManFadeIn", true); 
    }*/

}


