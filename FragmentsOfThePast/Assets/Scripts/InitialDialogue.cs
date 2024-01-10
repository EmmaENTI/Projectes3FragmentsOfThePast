using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

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
        GoTo68();
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
            DialogueLine67();
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
                dialogueText.text = textContent.Substring(0, printIndex);
                if(printIndex%3 == 0 && textContent.Substring(0, printIndex) != "")
                {
                    playSound.playEffect();
                }

                yield return new WaitForSeconds(0.04f);
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
        }
    }
    
    private void DialogueLine0()
    {
        hasEndedTyping = false;
        texToToWrite = "";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine1()
    {
        hasEndedTyping = false;
        spiritNameText.text = "???";
        texToToWrite = "Wake up… " + gameManager_Script.playerName + " wake up…! ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine2()
    {

        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Confused) What? Where? Who are you? ";
        button2AnswerText.text = "(Amazed) Whoa, what's this? Feels like a dream… ";
        button3AnswerText.text = "(Panic) Is this sleep paralysis?! ";
        playerIsAnswering = true;
    }

    public void DialogueLine2Answer1()
    {
        if (dialogueLine == 2)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine2Answer2()
    {
        if (dialogueLine == 2)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine2Answer3()
    {
        if (dialogueLine == 2)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine3()
    {
        hasEndedTyping = false;
        texToToWrite = "To answer all of those questions running through your little human mind… ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }


    private void DialogueLine4()
    {
        hasEndedTyping = false;
        texToToWrite = "A danger has been born of desires untamed, stealing memories and disrupting the delicate balance that binds our worlds, the dead and the living. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine5()
    {
        hasEndedTyping = false;
        texToToWrite = "The Memory Thief steals memories from dead ones, and what is more important to our dead ones than their memories? ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine6()
    {
        hasEndedTyping = false;
        texToToWrite = "Without them, they cannot go back to their families and are bound to be forgotten…";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine7()
    {
        hasEndedTyping = false;
        texToToWrite = "But fear not, you're a bridge between worlds… One of a kind human, able to communicate with spirits. Time is your companion, but also your adversary.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine8()
    {
        hasEndedTyping = false;
        texToToWrite = "As the sun sets on Dia De Los Muertos, a deadline approaches. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine9()
    {
        hasEndedTyping = false;
        texToToWrite = "You have a week, dear human, a precious span of time to gather the keys before the fabric of the afterlife unravels completely.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine10()
    {
        hasEndedTyping = false;
        texToToWrite = "Take heart, for you are not alone in this endeavor. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine11()
    {
        hasEndedTyping = false;
        texToToWrite = "Spirits yearn for resolution, their memories waiting to be rediscovered.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine12()
    {
        hasEndedTyping = false;
        texToToWrite = "Reach out, uncover their tales, and restore the stolen fragments.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }
    private void DialogueLine13()
    {
        hasEndedTyping = false;
        texToToWrite = "Good luck " + gameManager_Script.playerName + ", we will see each other once more, in the future. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine14()
    {
        dialogueTextPanel.SetActive(false);
        streetPanelImage.sprite = streetBackgroundSprite;
        if(canPlayMusicLine14)
        {
            canPlayMusicLine14 = false;
            audioSource.enabled = false;
            audioSource.clip = hoodedManMusic;
            audioSource.enabled = true;
        }

        loadManager.introFinished = true;
        loadManager.Save();

        playerIsAnswering = true;
        startHoodedManButtonGameObject.SetActive(true);
    }

    public void StartHoodedManButton()
    {
        if (dialogueLine == 14)
        {
            startHoodedManButtonGameObject.SetActive(false);
            textPanelImage.sprite = TextPanelNormalSprite;
            spiritNameText.text = "";
            dialogueTextPanel.SetActive(true);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
        }
    }

    private void DialogueLine15()
    {
        hasEndedTyping = false;
        texToToWrite = "You open your eyes to Calle de las Almas, a spectral street adorned with marigolds and papel picado.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine16()
    {
        hasEndedTyping = false;
        texToToWrite = "The air is a sweet blend of copal and memories, stalls overflow with sugar skulls and candles, and the laughter of spirits mingles with the aroma of pan de muerto. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine17()
    {
        hasEndedTyping = false;
        texToToWrite = "The sky is painted in beautiful purples and pinks.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine18()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Curiously look around) Calle de las Almas… ";
        button2AnswerText.text = "(Scream into the air in hopes the mysterious voice comes back).";
        button3AnswerText.text = "(Panic) What...? (Frantically looking around) This isn't where I was.";
        playerIsAnswering = true;
    }

    public void DialogueLine18Answer1()
    {
        if (dialogueLine == 18)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine18Answer2()
    {
        if (dialogueLine == 18)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine18Answer3()
    {
        if (dialogueLine == 18)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine19()
    {
        hasEndedTyping = false;
        texToToWrite = "A gentle tap graces your shoulder, and as you turn, your eyes meet a mysterious hooded figure.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine20()
    {
        hasEndedTyping = false;
        texToToWrite = "The air around him seems to ripple with an odd energy. His voice is disarmingly warm.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine21()
    {
        streetPanelImage.sprite = streetDarkBackgroundSprite;
        textPanelImage.sprite = TextPanelDarkSprite;
        hoodedManImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Hooded Man";
        playSound2.playEffect();
        texToToWrite = "Hey there, friend, you seem a bit out of place. Are you lost…? Need someone to show you around Calle de las Almas?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine22()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Sure, why not? ";
        button2AnswerText.text = "(Cautious) Thanks, but I'll navigate this place solo. No offense.";
        button3AnswerText.text = "(Rude) No guide needed. Move along, creep.";
        playerIsAnswering = true;
    }

    public void DialogueLine22Answer1()
    {
        if (dialogueLine == 22)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine22Answer2()
    {
        if (dialogueLine == 22)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine22Answer3()
    {
        if (dialogueLine == 22)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine23()
    {
        hasEndedTyping = false;
        texToToWrite = "You know, I couldn't help but notice... your breathing, rhythmic and alive.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine24()
    {
        hasEndedTyping = false;
        texToToWrite = "The subtle rise and fall of your chest… It's fascinating, really.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine25()
    {
        hasEndedTyping = false;
        texToToWrite = "Can you feel your heartbeat, each pulse a reminder of your existence in this... transitional state?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine26()
    {
        hasEndedTyping = false;
        texToToWrite = "Do you often think, when this heartbeat will stop?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine27()
    {
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Creeped Out) Too much info... Back off with the anatomy analysis.";
        button2AnswerText.text = "(Denial) Alive, dead, who knows? Just leave me be, okay?";
        button3AnswerText.text = "(Rude) Maybe a psychologist would care about your deep thoughts. Not me, though.";
        playerIsAnswering = true;
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
        texToToWrite = "Life is a precious gift, isn't it? Your abilities, your memories... they're tempting. Imagine the power, the richness I could savor.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine29()
    {
        hasEndedTyping = false;
        texToToWrite = "But be cautious, dear. Lose grip, and these treasures might find themselves in less forgiving hands.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine30()
    {
        hasEndedTyping = false;
        texToToWrite = "Consider that a friendly warning, I like you, human, a lot.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine31()
    {
        streetPanelImage.sprite = streetBackgroundSprite;
        textPanelImage.sprite = TextPanelNormalSprite;
        hoodedManImage.SetActive(false);
        if (canPlayMusicLine31)
        {
            canPlayMusicLine31 = false;
            audioSource.enabled = false;
            audioSource.clip = introMusic;
            audioSource.enabled = true;
        }

        hasEndedTyping = false;
        spiritNameText.text = "";
        texToToWrite = "The hooded figure, with an unsettling grin, melts into the shadows of a dark alleyway. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine32()
    {
        hasEndedTyping = false;
        texToToWrite = "As he vanishes, a peculiar gust of wind carries an eerie whisper, leaving you with a sense of unease.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine33()
    {
        groupImage.SetActive(true);
        hasEndedTyping = false;
        texToToWrite = "Then… You hear a group of people running towards you! Are they… dead?! Oh, true, we are in the dead realm. At this point, nothing is surprising…";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine34()
    {
        groupImage.SetActive(false);
        marinaSadImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        playSound2.playEffect();
        texToToWrite = "Hey there! Sorry to burst in like this, have you seen a hooded guy, with a super creepy vibe? He's, like, holding our memories hostage!";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine35()
    {
        marinaSadImage.SetActive(false);
        brunoSadImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Bruno";
        playSound2.playEffect();
        texToToWrite = "I-I think I saw him going into the alley, but I didn't want to... you know, chase after him alone. It's just, um, not my thing.";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine36()
    {
        brunoSadImage.SetActive(false);
        carmenAngerImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Carmen";
        playSound2.playEffect();
        texToToWrite = "Cut the small talk. Hooded man, stole our memories. Seen him or not?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine37()
    {
        carmenAngerImage.SetActive(false);
        luisSurpriseImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        playSound2.playEffect();
        texToToWrite = "Hey! Any chance you've crossed paths with a dude in a hood? Stole our memories, you know. ";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine38()
    {
        hasEndedTyping = false;
        texToToWrite = "Classic move. The usual Monday shenanigans. Anyone up for a bet on where our memory thief ran off to?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine39()
    {
        luisSurpriseImage.SetActive(false);
        dialogueTextPanel.SetActive(false);
        answerButtonsPanel.SetActive(true);
        button1AnswerText.text = "(Friendly) Oh yeah, I saw him…";
        button2AnswerText.text = "(Nervous) Yes…? ";
        button3AnswerText.text = "(Annoyed) Yes I saw him! All of this is crazy! ";
        playerIsAnswering = true;
    }


    public void DialogueLine39Answer1()
    {
        if (dialogueLine == 39)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine39Answer2()
    {
        if (dialogueLine == 39)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    public void DialogueLine39Answer3()
    {
        if (dialogueLine == 39)
        {
            dialogueTextPanel.SetActive(true);
            answerButtonsPanel.SetActive(false);
            playerIsAnswering = false;
            canTalk = true;
            dialogueLine++;
            playSound1.playEffect();
        }
    }

    private void DialogueLine40()
    {
        carmenAngerImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Carmen";
        playSound2.playEffect();
        texToToWrite = "Great, the hooded dude vanished, once again! There is no point in chasing him, he comes and goes whenever he wants…";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine41()
    {
        carmenAngerImage.SetActive(false);
        brunoSurpriseImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Bruno";
        playSound2.playEffect();
        texToToWrite = "Um, guys, not to interrupt, but look, our new friend here is, well, not exactly one of us. Living, I mean. How do we explain that?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine42()
    {
        brunoSurpriseImage.SetActive(false);
        marinaSurpriseImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Marina";
        playSound2.playEffect();
        texToToWrite = "Oh wow! A living person in the afterlife?! That's fascinating! Maybe you're like a bridge between worlds! Can we keep them? Please?~";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

    private void DialogueLine43()
    {
        marinaSurpriseImage.SetActive(false);
        luisHappyImage.SetActive(true);
        hasEndedTyping = false;
        spiritNameText.text = "Luis";
        playSound2.playEffect();
        texToToWrite = "Eh, living, dead, who cares? What's your story, living one? You here for a wild afterlife party?";
        StartCoroutine(TypeText(texToToWrite));
        canTalk = false;
    }

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

}


