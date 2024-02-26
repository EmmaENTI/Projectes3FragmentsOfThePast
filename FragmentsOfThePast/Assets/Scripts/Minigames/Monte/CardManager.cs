using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
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



    void Start()
    {
        Load();
        SetBotTopLayout();
        SetGateColor();

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

    public void CheckChipTopBotWithGate()
    {
        // Ficar Missatge dient que agafi una fitxa si no hi ha, si hi ha dirli que la fiqui en una de les cartes
        if (!chipManager.isLeftChoice && !chipManager.isRightChoice) { return; }

        if ((gateColor == leftLayoutColor) && chipManager.isLeftChoice || chipManager.isRightChoice && (gateColor == rightLayoutColor))
        {
            chipManager.GainChips();
            SuccessRound();
        }
        else
        {
            ResetRound();
        }
    }

    public void DoubtButton()
    {
        chipManager.RecollectChip();

        // Si doubt es correcte (Left i Right son diferents a la carta mostrada, no passa res)
        if ((gateColor != leftLayoutColor) && (gateColor != rightLayoutColor))
        {
            SuccessRound();
        }
        // Si alguna de les cartes es igual a la carta mostrada penalització
        else
        {
            chipManager.SetDoubtMultiplier();
            SetBotTopLayout();
            SetGateColor();
        }

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
        Debug.Log("YOU LOST!, The correct option was: " + gateColor.ToString());
        // Missatge Doubt era la opcio correcta

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
        Debug.Log("YOU WIN! " + gateColor.ToString() + " was the correct Option");
        // Missatge Doubt era la opcio correcta

        winCount++;

        if (winCount >= 5)
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
