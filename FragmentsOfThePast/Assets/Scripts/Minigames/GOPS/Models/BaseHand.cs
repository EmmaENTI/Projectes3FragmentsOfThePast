using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseHand
{
    public List<int> hand;

    public abstract void InitHand();
    public abstract void SetHand(List<int> values);
    public abstract void SpecialInteraction();
}
