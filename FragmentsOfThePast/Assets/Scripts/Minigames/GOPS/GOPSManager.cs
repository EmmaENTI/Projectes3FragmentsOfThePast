using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GOPSManager : MonoBehaviour
{

    [SerializeField] GameObject playerCardPrefab;
    [SerializeField] GameObject playerHandObject;
    int playerCardResponse = -1;

    [SerializeField] GameObject enemyCardPrefab;
    [SerializeField] GameObject enemyHandObject;

    float enemyDIfficulty; // 0 -> 100% Winrate Player, 1 --> 0% Winrate Player

    BaseHand player;
    BaseHand enemy;

    List<int> deckCards;
    int deckIterator;

    [SerializeField] TMP_Text cardPrizeText;

    void Start()
    {
        SetDifficulty(0.5f);
        InitHands();
        CreatePlayerCards();
        CreateEnemyCards();
    }

    void Update()
    {
        if (deckIterator >= 0)
        {
            UpdatePrizeCard(deckCards[deckIterator].ToString());
        }
        else
        {
            UpdatePrizeCard("FINISH");
        }
    }

    void CreatePlayerCards()
    {
        for (int i = 0; i < player.hand.Count; i++)
        {
            GameObject card = Instantiate(playerCardPrefab, new Vector3(200 * i + 300, 140, 0), Quaternion.identity, playerHandObject.transform);
            card.GetComponent<CardClicked>().SetCardValue(player.hand[i]);
            card.GetComponent<CardClicked>().SetManager(this);
        }
    }

    void CreateEnemyCards()
    {
        for (int i = 0; i < enemy.hand.Count; i++)
        {
            GameObject card = Instantiate(enemyCardPrefab, new Vector3(200 * i + 300, 940, 0), Quaternion.identity, enemyHandObject.transform);
        }
    }

    public void SetPlayerCardResponse(int num)
    {
        playerCardResponse = num;

        deckIterator--;
    }

    public void SetDifficulty(float value)
    {
        enemyDIfficulty = value;
    }

    void InitHands()
    {
        player = new PlayerHand();
        enemy = new TestEnemyHand();


        deckCards = new();
        ShuffleDeckCards();
        deckIterator = deckCards.Count - 1;
    }

    void ShuffleDeckCards()
    {
        List<int> temp = new();

        for (int i = 0; i < player.hand.Count; i++)
        {
            temp.Add(i + 1);
        }

        for (int i = 0; i < player.hand.Count; i++)
        {
            int index = Random.Range(0, temp.Count);
            deckCards.Add(temp[index]);
            temp.RemoveAt(index);
        }

        
        for (int i = 0; i < deckCards.Count; i++)
        {
            Debug.Log("# " + deckCards[i]);
        }    
        
    }

    void UpdatePrizeCard(string text)
    {
        cardPrizeText.text = text;
    }
}
