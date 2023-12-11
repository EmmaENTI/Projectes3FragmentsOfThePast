using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleManager : MonoBehaviour
{
    [SerializeField] private GameObject alchemyPanel;
    [SerializeField] private GameObject baseBubble;
    [SerializeField] private Sprite[] bubblesSprites;
    [SerializeField] static public Dictionary<string, Sprite> bubbleDictionary;

    private List<GameObject> currentBubbles;

    private string[] currentMergeableTypes;

    // Num of Bubbles 27 (Not counting Orange Bubble)

    float minDistance = 120.0f;

    void Start()
    {
        LoadDictionary();

        currentBubbles = new List<GameObject>();

        for (int i = 0; i < 5; i++)
        {
            CreateBubble("Snob");
        }

        for (int i = 0; i < 5; i++)
        {
            CreateBubble("Evil");
        }

        for (int i = 0; i < 5; i++)
        {
            CreateBubble("Genius");
        }

        SetMergeableBubbleTypes(new string[] { "Snob", "Evil" });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    public void CreateBubble(string name)
    {
        baseBubble.GetComponent<Image>().sprite = bubbleDictionary[name];
        GameObject gameObj = Instantiate(baseBubble, alchemyPanel.transform);
        gameObj.name = name;
        currentBubbles.Add(gameObj);

        gameObj.transform.localPosition = RandomPositionWithinBounds();

        IsValidPosition(gameObj);
    }

    public void SetMergeableBubbleTypes(string[] types) // Bubbles que es poden mergear
    {
        currentMergeableTypes = types;
    }

    public string[] GetMergeableBubbleTypes()
    {
        return currentMergeableTypes;
    }

    private Vector3 RandomPositionWithinBounds()
    {
        return new Vector3(UnityEngine.Random.Range(-790,630+1), UnityEngine.Random.Range(450, -460+1), 0);
    }

    private void IsValidPosition(GameObject o)
    {
        for (int i = 0; i < currentBubbles.Count; i++)
        {
            // NO TOCAR, SI NO PETA, comprobació amb el mateix objecte
            if (currentBubbles[i] == o)
            {
                continue;
            }

            // Mirar si estan a prop
            if (Vector3.Distance(o.transform.position, currentBubbles[i].transform.position) < minDistance) 
            {
                o.transform.localPosition = RandomPositionWithinBounds();
                i = 0;
            }
        }
    }

    void LoadDictionary()
    {
        bubbleDictionary = new Dictionary<string, Sprite>
        {
            { "Active", bubblesSprites[0] },
            { "Ambitious", bubblesSprites[1] },
            { "ArtLover", bubblesSprites[2] },
            { "Bookworm", bubblesSprites[3] },
            { "Cheerful", bubblesSprites[4] },
            { "Childish", bubblesSprites[5] },
            { "Clumsy", bubblesSprites[6] },
            { "Creative", bubblesSprites[7] },
            { "Evil", bubblesSprites[8] },
            { "Family", bubblesSprites[9] },
            { "Foodie", bubblesSprites[10] },
            { "Geek", bubblesSprites[11] },
            { "Genius", bubblesSprites[12] },
            { "Goof", bubblesSprites[13] },
            { "HotHeaded", bubblesSprites[14] },
            { "Insane", bubblesSprites[15] },
            { "Lazy", bubblesSprites[16] },
            { "Loner", bubblesSprites[17] },
            { "Materialist", bubblesSprites[18] },
            { "Mean", bubblesSprites[19] },
            { "Moody", bubblesSprites[20] },
            { "MusicLover", bubblesSprites[21] },
            { "Outgoing", bubblesSprites[22] },
            { "Perfectionist", bubblesSprites[23] },
            { "Romantic", bubblesSprites[24] },
            { "Slob", bubblesSprites[25] },
            { "Snob", bubblesSprites[26] }
        };
    }
}
