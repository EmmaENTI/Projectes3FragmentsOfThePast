using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : BaseHand
{
    public PlayerHand()
    {
        InitHand();
    }

    public override void InitHand()
    {
        int numCards = 8;

        List<int> temp = new();
        for (int i = 0; i < numCards; i++)
        {
            temp.Add(i + 1);
        }

        SetHand(temp);


    }
    public override void SetHand(List<int> values)
    {
        hand = values;
    }

    public override void SpecialInteraction()
    {
        
    }
}
