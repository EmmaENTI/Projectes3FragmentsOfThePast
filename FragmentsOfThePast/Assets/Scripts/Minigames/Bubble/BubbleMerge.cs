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

        for (int i = 0; i < bubbleManager.GetMergeableBubbleTypes().Length; i++)
        {
            if (bubbleManager.GetMergeableBubbleTypes()[i] == transform.name)
            {
                canMerge1 = true;
            }
            if (bubbleManager.GetMergeableBubbleTypes()[i] == collision.transform.name)
            {
                canMerge2 = true;
            }
        }

        Debug.Log(transform.name + "  " + collision.transform.name);

        if (canMerge1 && canMerge2 && (transform.name != collision.transform.name) && !isCollisionOff)
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
