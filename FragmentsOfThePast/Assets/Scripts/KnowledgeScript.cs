using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowledgeScript
{

    public bool isLuis = false;
    public List<string[]> characterBubbles = new List<string[]>()
    {
        new string[5] { "BaseBubble", "Lure", "Ambitious", "Perfectionist", "Loner" },                // Luis
        new string[5] { "BaseBubble", "Entrepreneur", "Assertive", "Materialistic", "Independent" },  // Carmen
        new string[5] { "BaseBubble", "Bookworm", "Genius", "Geek", "Loyal" },                        // Bruno
        new string[5] { "BaseBubble", "Romantic", "Good", "Active", "Childish" }                      // Marina
    };

    public List<Tuple<string, int>> listToCreate = new List<Tuple<string, int>>
    {
        // String = Tipus de Bola
        // Int = Quantitat
        
        new Tuple<string, int>("BaseBubble", 1), 
        new Tuple<string, int>("Active", 0),
        new Tuple<string, int>("Ambitious", 1),
        new Tuple<string, int>("ArtLover", 0),
        new Tuple<string, int>("Assertive", 0),
        new Tuple<string, int>("Bookworm", 0),
        new Tuple<string, int>("Cheerful", 0),
        new Tuple<string, int>("Childish", 0),
        new Tuple<string, int>("Clumsy", 0),
        new Tuple<string, int>("Creative", 0),
        new Tuple<string, int>("Evil", 0),
        new Tuple<string, int>("Family", 0),
        new Tuple<string, int>("Foodie", 0),
        new Tuple<string, int>("Geek", 0),
        new Tuple<string, int>("Genius", 0),
        new Tuple<string, int>("Good", 0),
        new Tuple<string, int>("Goof", 0),
        new Tuple<string, int>("Independent", 0),
        new Tuple<string, int>("Insane", 0),
        new Tuple<string, int>("Lazy", 0),
        new Tuple<string, int>("Loner", 0),
        new Tuple<string, int>("Loyal", 0),
        new Tuple<string, int>("Lure", 0),
        new Tuple<string, int>("Materialistic", 0),
        new Tuple<string, int>("Mean", 0),
        new Tuple<string, int>("Moody", 0),
        new Tuple<string, int>("MusicLover", 0),
        new Tuple<string, int>("Outgoing", 0),
        new Tuple<string, int>("Perfectionist", 0),
        new Tuple<string, int>("Romantic", 0),
        new Tuple<string, int>("Slob", 0),
        new Tuple<string, int>("Snob", 0),
    };

    
    //public int emptyBallAmount = 1;
    //public int ambitiousBallAmount = 1;
}
