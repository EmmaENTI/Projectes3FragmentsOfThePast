using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverBubble : MonoBehaviour
{
    BubbleManager bubbleManager;

    private void Start()
    {
        bubbleManager = FindObjectOfType<BubbleManager>();
    }

    public void HoverOnBubble()
    {
        // OPTIMITZAR

        // List<Tuple<string, List<string>>>()

        for (int i = 0; i < bubbleManager.GetMergeableBubbleTypes().Count; i++)
        {
            for (int j = 0; j < bubbleManager.GetCharacterBallTypes().Length; j++)
            {
                if (bubbleManager.GetCharacterBallTypes()[j] == transform.name && bubbleManager.GetMergeableBubbleTypes()[i].Item1 == transform.name)
                {
                    transform.GetComponent<Image>().color = new Color(1, 0, 0, 1);
                }
            }
        }
    }

    public void LeaveBubble()
    {
        transform.GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }
}
