using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMerge : MonoBehaviour
{
    BubbleManager bubbleManager;

    public bool isCollisionOff = false;

    void Start()
    {
        bubbleManager = FindObjectOfType<BubbleManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject col = collision.gameObject; // Agafar el nom
        collision.gameObject.GetComponent<BubbleMerge>().isCollisionOff = true;

        if (!CompareTag("Bubble") || isCollisionOff)
        {
            return;
        }

        bool canMerge1 = false;
        bool canMerge2 = false;

        bool canMergeCharacter1 = false;
        bool canMergeCharacter2 = false;


        // List<Tuple<string, List<string>>>()

        // Iterar la llista de tuples per comprobar quines poden fusionarse entre elles
        for (int i = 0; i < bubbleManager.GetMergeableBubbleTypes().Count; i++) 
        {
            
            // Comprobo si pot fer merge
            if (bubbleManager.GetMergeableBubbleTypes()[i].Item1 == transform.name)
            {
                canMerge1 = true;

                for (int j = 0; j < bubbleManager.GetMergeableBubbleTypes()[i].Item2.Count; j++)
                {
                    if (bubbleManager.GetMergeableBubbleTypes()[i].Item2[j] == collision.transform.name)
                    {
                        canMerge2 = true;
                    }
                }
            }
            // Iterar Amb quines bubbles pot fer merge
            
            
            // Comprobar si les bubbles son les del personatge actual
            for (int j = 0; j < bubbleManager.GetCharacterBallTypes().Length; j++)
            {
                if (bubbleManager.GetCharacterBallTypes()[j] == transform.name)
                {
                    canMergeCharacter1 = true;
                }

                if (bubbleManager.GetCharacterBallTypes()[j] == collision.transform.name)
                {
                    canMergeCharacter2 = true;
                }
            }
            
        }

        //Debug.Log(transform.name + "  " + collision.transform.name);

        if (canMergeCharacter1 && canMergeCharacter2 && canMerge1 && canMerge2 && (transform.name != collision.transform.name) && !isCollisionOff)
        {
            // Animació Merge

            // Al acabar Animació Merge -> Transició Tinieblas

            // Destruir les dos bubbles
            Destroy(collision.gameObject);
            Destroy(gameObject);

            bubbleManager.ToggleSelectionPanel();
            bubbleManager.SetNamesSelectionPanel(new string[] { transform.name, col.transform.name });
        }

        collision.gameObject.GetComponent<BubbleMerge>().isCollisionOff = false;
        isCollisionOff = false;
    }

    // !**NO TOCAR**!, MAGIA NEGRA DEL UNITY
    // SI S'ELIMINA EL OnCollisionEnter2D no funciona bé i l'animació s'activaria 2 vegades
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
