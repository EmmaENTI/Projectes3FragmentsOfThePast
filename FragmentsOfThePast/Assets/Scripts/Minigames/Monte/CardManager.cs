using CardHouse;
using CardHouse.SampleGames.Tarot;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    private enum CardSuit { RED, GREEN, BLUE, YELLOW, NONE }
    List<CardSuit> deck;
    Dictionary<CardSuit, Color> cardColor;

    CardSuit leftLayoutColor;
    CardSuit rightLayoutColor;
    CardSuit gateColor;

    [SerializeField] GameObject botLayout;
    [SerializeField] GameObject topLayout;
    [SerializeField] GameObject gate;

    ChipManager chipManager;

    [SerializeField] int winCount = 0;
    [SerializeField] TextMeshProUGUI winCountText;

    bool doubleScoreActive = false;
    bool revealActive = false;
    bool predictoActive = false;
    bool immunityActive = false;
    bool doubleChipActive = false;

    public List<CardGroup> Slots;
    public List<Sprite> Sprites;

    public CardGroup GuessSlot;

    [SerializeField] PlaySound playSound;
    [SerializeField] PlaySound playSound1;

    [SerializeField] SpreadManager spPlayer;
    [SerializeField] SpreadManager sp;

    TarotCard GuessCard;

    [SerializeField] GameObject chip;
    private Vector3 initialPosition;

    void Start()
    {
        Load();
        SetBotTopLayout();
        SetGateColor();

        initialPosition = chip.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetRound();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            ResetGame();
        }

        PrintCardStates();

        winCountText.text = winCount.ToString();
    }

    // Funcions para activar habilidades
    public void ActivateDoubleScore()
    {
        doubleScoreActive = true;
    }

    public void ActivateReveal()
    {
        revealActive = true;
    }

    public void ActivatePredicto()
    {
        predictoActive = true;
    }

    public void ActivateImmunity()
    {
        immunityActive = true;
    }

    public void ActivateDoubleChip()
    {
        doubleChipActive = true;
    }

    public void CheckChipTopBotWithGate()
    {
        // Ficar Missatge dient que agafi una fitxa si no hi ha, si hi ha dirli que la fiqui en una de les cartes
        //if (!chipManager.isLeftChoice && !chipManager.isRightChoice) { return; }

        //if ((gateColor == leftLayoutColor) && chipManager.isLeftChoice 
        //    || chipManager.isRightChoice && (gateColor == rightLayoutColor))
        //{
        //    chipManager.GainChips();
        //    SuccessRound();
        //}
        //else
        //{
        //    ResetRound();
        //}

        if (GuessSlot.MountedCards[0].GetComponent<TarotCard>().Image.sprite == 
            Slots[0].MountedCards[0].GetComponent<TarotCard>().Image.sprite 
            && chipManager.isLeftChoice ||
            chipManager.isRightChoice && 
            GuessSlot.MountedCards[0].GetComponent<TarotCard>().Image.sprite ==
            Slots[1].MountedCards[0].GetComponent<TarotCard>().Image.sprite)
        {
            chipManager.GainChips();
            SuccessRound();
        }
        else
        {
            ResetRound();
        }

        chip.transform.position = initialPosition;
    }

    public void DoubtButton()
    {
        chipManager.RecollectChip();

        // Si doubt es correcte (Left i Right son diferents a la carta mostrada, no passa res)
        //if ((gateColor != leftLayoutColor) && (gateColor != rightLayoutColor))
        //{
        //    SuccessRound();
        //    Debug.Log("Doubted");
        //}
        //// Si alguna de les cartes es igual a la carta mostrada penalització
        //else
        //{
        //    chipManager.SetDoubtMultiplier();
        //    SetBotTopLayout();
        //    SetGateColor();

        //    Debug.Log("Doubted");
        //}

        if ((GuessSlot.MountedCards[0].GetComponent<TarotCard>().Image.sprite !=
            Slots[0].MountedCards[0].GetComponent<TarotCard>().Image.sprite) && 
            (GuessSlot.MountedCards[0].GetComponent<TarotCard>().Image.sprite !=
            Slots[1].MountedCards[0].GetComponent<TarotCard>().Image.sprite))
        {
            SuccessRound();
            Debug.Log("Doubted");
        }
        // Si alguna de les cartes es igual a la carta mostrada penalització
        else
        {
            chipManager.SetDoubtMultiplier();
            SetBotTopLayout();
            SetGateColor();

            Debug.Log("Doubted");
        }

        chip.transform.position = initialPosition;
    }

    void PrintCardStates()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(leftLayoutColor.ToString() + " " + rightLayoutColor.ToString() + " " + gateColor.ToString());
        }
    }

    void ResetRound()
    {
        if (immunityActive) // Inmunitat
        {
            immunityActive = false;
            return;
        }

        playSound1.playEffect();
        Debug.Log("YOU LOST!, The correct option was: " + gateColor.ToString());
        // Missatge Doubt era la opcio correcta
        doubleScoreActive = false;

        if (chipManager.GetChips() <= 0)
        {
            ResetGame();
            return;
        }

        //gate.SetActive(false);

        SetBotTopLayout();
        SetGateColor();
    }

    void SuccessRound()
    {

        playSound.playEffect();

        if (doubleScoreActive) // Doble puntuación
        {
            winCount += 2;
            Debug.Log("YOU WIN! " + gateColor.ToString() + " was the correct Option");
            doubleScoreActive = false;
            // Missatge Doubt era la opcio correcta
        }
        else
        {
            winCount++;
            Debug.Log("YOU WIN! " + gateColor.ToString() + " was the correct Option");
            doubleScoreActive = false;
            // Missatge Doubt era la opcio correcta
        }

        if (winCount >= 3)
        {
            Debug.Log("YOU WON, GG");

            // TEMP_START
            winCount = 0;
            chipManager.ResetLives();

            SetBotTopLayout();
            SetGateColor();
            chipManager.ResetLives();
            //TEMP_END

            // Progress with the Story
            return;
        }

        //gate.SetActive(true);

        SetBotTopLayout();
        SetGateColor();
    }

    void ResetGame()
    {
        Debug.Log("YOU LOST ALL LIVES, GIT GUD");

        winCount = 0;
        chipManager.ResetLives();

        SetBotTopLayout();
        SetGateColor();
        //gate.SetActive(false);

        doubleChipActive = false;
        doubleScoreActive = false;
        revealActive = false;
        immunityActive = false;
        predictoActive = false;
    }

    void SetGateColor()
    {
        gateColor = deck[Random.Range(0, 4)];
        gate.GetComponent<Image>().color = cardColor[gateColor];
    }

    void SetBotTopLayout()
    {
        int randNum = Random.Range(0, 4);
        int prevRandNum = randNum;

        leftLayoutColor = deck[randNum];

        while (randNum == prevRandNum)
        {
            randNum = Random.Range(0, 4);
        }

        rightLayoutColor = deck[randNum];

        botLayout.GetComponent<Image>().color = cardColor[leftLayoutColor];
        topLayout.GetComponent<Image>().color = cardColor[rightLayoutColor];
    }

    void Load()
    {
        deck = new();
        deck.Add(CardSuit.RED);
        deck.Add(CardSuit.GREEN);
        deck.Add(CardSuit.BLUE);
        deck.Add(CardSuit.YELLOW);

        cardColor = new();
        cardColor.Add(deck[0], Color.red);
        cardColor.Add(deck[1], Color.green);
        cardColor.Add(deck[2], Color.blue);
        cardColor.Add(deck[3], Color.yellow);

        chipManager = transform.parent.GetComponentInChildren<ChipManager>();
    }
}
