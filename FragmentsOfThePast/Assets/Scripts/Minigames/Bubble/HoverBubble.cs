using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HoverBubble : MonoBehaviour
{
    BubbleManager bubbleManager;

    GameObject infoPanel;

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
        ToggleInfoPanel(true);
    }

    public void LeaveBubble()
    {
        transform.GetComponent<Image>().color = new Color(1, 1, 1, 1);

        ToggleInfoPanel(false);
    }

    void ToggleInfoPanel(bool isActive)
    {
        transform.GetChild(0).gameObject.SetActive(isActive);
    }
}
