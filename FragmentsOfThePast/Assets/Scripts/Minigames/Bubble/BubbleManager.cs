using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class BubbleManager : MonoBehaviour
{
    public enum CharacterType { LUIS, CARMEN, BRUNO, MARINA }

    [SerializeField] private GameObject alchemyPanel;
    [SerializeField] private GameObject baseBubble;
    [SerializeField] private Sprite[] bubblesSprites;
    [SerializeField] public Dictionary<string, Sprite> bubbleDictionary;
    [SerializeField] public string[] bubbleStrings;
    const int numOfBubbles = 34;
    [SerializeField] private GameObject selectionPanel; 

    private List<GameObject> currentBubbles;

    public string[] currentMergeableTypes;
    public List<Tuple<string, List<string>>> currentMergeableTypes2;
    
    float minDistance = 120.0f;

    public KnowledgeScript knowledgeScript;

    public CharacterType currentCharacter;

    [SerializeField] GameObject[] imagesBlockers;

    void Start()
    {
        LoadData();

        currentBubbles = new List<GameObject>();

        //CreateBubble("BaseBubble");
        //CreateBubble("Ambitious");

        //SetMergeableBubbleTypes(new string[] { "Snob", "Evil", "BaseBubble" });


        // Temporal
        knowledgeScript = new KnowledgeScript();
        
    }

    private void Update()   
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateRandomBubbles(5, knowledgeScript.listToCreate);
        }
    }

    public void CreateBubble(string name)
    {
        baseBubble.GetComponent<Image>().sprite = bubbleDictionary[name];
        GameObject gameObj = Instantiate(baseBubble, alchemyPanel.transform);
        gameObj.name = name;
        SetInfoPanelName(gameObj);

        currentBubbles.Add(gameObj);

        gameObj.transform.localPosition = RandomPositionWithinBounds();

        IsValidPosition(gameObj);
    }

    public void CreateRandomBubbles(int numBubbles, List<Tuple<string, int>> savedBubbles)
    {
        // Borrar Totes les Bubbles
        WipeRandomBubbles();

        for (int i = 0; i < savedBubbles.Count; i++)
        {
            for (int j = 0; j < savedBubbles[i].Item2; j++)
            {
                CreateBubble(savedBubbles[i].Item1);

            }
        }

        int initialBubblesOwned = currentBubbles.Count;

        for (int i = 0; i < numBubbles; i++)
        {
            bool notOwnedType = true;
            string randomBubble = bubbleStrings[UnityEngine.Random.Range(0, numOfBubbles)];

            for (int j = 0; j < initialBubblesOwned; j++)
            {
                // Si coincideixen Tornar a iterar fins que surti una correcte
                if (currentBubbles[j].name == randomBubble) 
                {
                    notOwnedType = false;
                    break;
                }

                // Iterar per comprobar si la bubble creada random no es del tipus del personatge actual
                for (int k = 0; k < GetCharacterBallTypes().Length; k++) 
                {
                    if (GetCharacterBallTypes()[k] == randomBubble)
                    {
                        notOwnedType = false;
                        break;
                    }
                }
            }

            if (notOwnedType)
            {
                CreateBubble(randomBubble);
            }
            else
            {
                i--;
            }
        }
    }

    private void WipeRandomBubbles()
    { 
        for (int i = 0; i < currentBubbles.Count; i++)
        {
            Destroy(currentBubbles[i]);
        }
        currentBubbles.Clear();
    }

    public void SetMergeableBubbleTypes(string[] types) // Bubbles que es poden mergear
    {
        currentMergeableTypes = types;
    }

    public List<Tuple<string, List<string>>> GetMergeableBubbleTypes()
    {
        return currentMergeableTypes2;
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

    void LoadData()
    {
        bubbleStrings = new string[numOfBubbles] { 
            "BaseBubble", 
            "Active", 
            "Ambitious", 
            "ArtLover",
            "Assertive", // NOU, sprite no correcte - Music Lover
            "Bookworm", 
            "Cheerful", 
            "Childish", 
            "Clumsy", 
            "Creative", 
            "Entrepreneur", // NOU, sprite no correcte - Grey Ball
            "Evil", 
            "Family", 
            "Foodie", 
            "Geek", 
            "Genius",
            "Good", // NOU, sprite no correcte - Lazy
            "Goof", 
            "HotHeaded",
            "Independent", // NOU, sprite no correcte - Cheerful
            "Insane", 
            "Lazy", 
            "Loner",
            "Loyal", // NOU, sprite no correcte - Foodie
            "Lure", // NOU, sprite no correcte - GoofBall
            "Materialistic",
            "Mean", 
            "Moody", 
            "MusicLover", 
            "Outgoing", 
            "Perfectionist", 
            "Romantic", 
            "Slob", 
            "Snob" 
        };

        bubbleDictionary = new Dictionary<string, Sprite>();
        for (int i = 0; i < numOfBubbles; i++)
        {
            bubbleDictionary.Add(bubbleStrings[i], bubblesSprites[i]);
        }

        currentMergeableTypes2 = new List<Tuple<string, List<string>>>();

        AddMergeableTypes("BaseBubble", new List<string>() { "Ambitious", "Perfectionist", "Lure", "Loner", "Entrepreneur", "Assertive", "Materialistic", "Independent", 
        "Bookworm","Genius","Geek","Loyal"});
        AddMergeableTypes("Ambitious", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Perfectionist", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Lure", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Loner", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Entrepreneur", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Assertive", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Materialistic", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Independent", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Bookworm", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Genius", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Geek", new List<string>() { "BaseBubble" });
        AddMergeableTypes("Loyal", new List<string>() { "BaseBubble" });
    }

    public void SetCurrentCharacter(CharacterType type)
    {
        currentCharacter = type;
    }

    public string[] GetCharacterBallTypes()
    {
        return knowledgeScript.characterBubbles[currentCharacter.GetHashCode()];
    }

    void AddMergeableTypes(string mainBall, List<string> otherBalls)
    {
        currentMergeableTypes2.Add(new Tuple<string, List<string>>(mainBall, otherBalls));
    }

    public void ToggleSelectionPanel()
    {
        selectionPanel.SetActive(!selectionPanel.activeSelf);
    }

    public void SetNamesSelectionPanel(string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            selectionPanel.transform.GetChild(i).GetChild(0).GetComponent<TMP_Text>().text = names[i];
            if (names[i] == "BaseBubble")
            {
                imagesBlockers[i].SetActive(true);
            }

            else
            {
                imagesBlockers[i].SetActive(false);
            }
        }
    }

    public void SetInfoPanelName(GameObject bubble)
    {
        bubble.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = bubble.transform.name;
    }
}
