using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    private enum CardSuit { RED, GREEN, BLUE, YELLOW, NONE }
    List<CardSuit> deck;
    Dictionary<CardSuit, Color> cardColor;

    CardSuit bottomLayoutColor;
    CardSuit topLayoutColor;
    CardSuit gateColor;

    bool isChoiceBot = false;
    bool isChoiceTop = false;

    [SerializeField] GameObject botLayout;
    [SerializeField] GameObject topLayout;
    [SerializeField] GameObject gate;

    void Start()
    {
        Load();
        SetBotTopLayout();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetBotTopLayout();
            SetGate();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            CheckChoice();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }

        PrintCardStates();

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
    }

    void SetBotTopLayout()
    {
        int randNum = Random.Range(0, 4);
        int prevRandNum = randNum;

        bottomLayoutColor = deck[randNum];
   
        while (randNum == prevRandNum)
        {
            randNum = Random.Range(0, 4);
        }

        topLayoutColor = deck[randNum];

        SetTopBotColor();
    }

    void CheckChoice()
    {
        gate.SetActive(true);
        SetGateColor();

        if (isChoiceTop)
        {
            if (gateColor == topLayoutColor)
            {
                SuccessGame();
            }
            else
            {
                ResetGame();
            }
        }
        else if (isChoiceBot)
        {
            if (gateColor == bottomLayoutColor)
            {
                SuccessGame();
            }
            else
            {
                ResetGame();
            }
        }
    }

    void SetGate()
    {
        gateColor = deck[Random.Range(0, 4)];
    }

    void PrintCardStates()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(bottomLayoutColor.ToString() + " " + topLayoutColor.ToString() + " " + gateColor.ToString());
        }
    }

    void ResetGame()
    {
        SetBotTopLayout();
        SetGate();

        gate.SetActive(false);

        isChoiceBot = false;
        isChoiceTop = false;


        Debug.Log("YOU LOST!, The correct option was: " + gateColor.ToString());
        // You lost Dialogue, Try Again
        // Doubt Button to progress Story?
    }

    void SuccessGame()
    {
        Debug.Log("YOU WIN! " + gateColor.ToString() + " was the correct Option");
        // You won Dialogue
        // Progress with the Story
    }

    public void ChoiceBotLayout()
    {
        isChoiceBot = true;
        CheckChoice();
    }

    public void ChoiceTopLayout()
    {
        isChoiceTop = true;
        CheckChoice();
    }

    void SetTopBotColor()
    {
        botLayout.GetComponent<Image>().color = cardColor[bottomLayoutColor];
        topLayout.GetComponent<Image>().color = cardColor[topLayoutColor];
    }

    void SetGateColor()
    {
        gate.GetComponent<Image>().color = cardColor[gateColor];
    }
}
