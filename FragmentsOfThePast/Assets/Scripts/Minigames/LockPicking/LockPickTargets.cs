using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LockPickTargets : MonoBehaviour
{
    [SerializeField] Lock lockScript;

    private void Start()
    {
        lockScript = GameObject.Find("Lock").GetComponent<Lock>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LockTarget"))
        {
            //Debug.Log("ENTERED LOCK TARGET");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "LayerTarget"+lockScript.GetNextLayerNum())
        {
            Destroy(collision.transform.parent.GetChild(collision.transform.GetSiblingIndex()-1).gameObject);
            Destroy(collision.gameObject);
            lockScript.SetNextLayerNum();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    
}
