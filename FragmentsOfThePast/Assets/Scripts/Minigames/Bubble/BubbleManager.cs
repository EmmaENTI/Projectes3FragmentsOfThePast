using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BubbleManager : MonoBehaviour
{
    [SerializeField] private GameObject alchemyPanel;
    [SerializeField] private GameObject baseBubble;
    [SerializeField] private Sprite[] bubblesSprites;
    [SerializeField] static public Dictionary<string, Sprite> bubbleDictionary;
    [SerializeField] private GameObject selectionPanel; 

    private List<GameObject> currentBubbles;

    public string[] currentMergeableTypes;

    // Num of Bubbles 27 (Not counting Orange Bubble)

    float minDistance = 120.0f;

    void Start()
    {
        LoadDictionary();

        currentBubbles = new List<GameObject>();

        for (int i = 0; i < 5; i++)
        {
            CreateBubble("BaseBubble");
        }

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

        SetMergeableBubbleTypes(new string[] { "Snob", "Evil", "BaseBubble" });
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
        {   { "BaseBubble", bubblesSprites[0] },
            { "Active", bubblesSprites[1] },
            { "Ambitious", bubblesSprites[2] },
            { "ArtLover", bubblesSprites[3] },
            { "Bookworm", bubblesSprites[4] },
            { "Cheerful", bubblesSprites[5] },
            { "Childish", bubblesSprites[6] },
            { "Clumsy", bubblesSprites[7] },
            { "Creative", bubblesSprites[8] },
            { "Evil", bubblesSprites[9] },
            { "Family", bubblesSprites[10] },
            { "Foodie", bubblesSprites[11] },
            { "Geek", bubblesSprites[12] },
            { "Genius", bubblesSprites[13] },
            { "Goof", bubblesSprites[14] },
            { "HotHeaded", bubblesSprites[15] },
            { "Insane", bubblesSprites[16] },
            { "Lazy", bubblesSprites[17] },
            { "Loner", bubblesSprites[18] },
            { "Materialist", bubblesSprites[19] },
            { "Mean", bubblesSprites[20] },
            { "Moody", bubblesSprites[21] },
            { "MusicLover", bubblesSprites[22] },
            { "Outgoing", bubblesSprites[23] },
            { "Perfectionist", bubblesSprites[24] },
            { "Romantic", bubblesSprites[25] },
            { "Slob", bubblesSprites[26] },
            { "Snob", bubblesSprites[27] }
        };
    }

    public void ToggleSelectionPanel()
    {
        selectionPanel.SetActive(!selectionPanel.activeSelf);
    }

    public void SetNamesSelectionPanel(string[] names)
    {
        
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
            selectionPanel.transform.GetChild(i).GetChild(0).GetComponent<TMP_Text>().text = names[i];
        }
    }
}
