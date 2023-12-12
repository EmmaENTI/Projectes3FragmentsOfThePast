using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPickTargets : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LockTarget"))
        {
            Debug.Log("ENTERED LOCK TARGET");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("LockTarget"))
        {
            Debug.Log(collision.transform.parent.name);
            Debug.Log(collision.transform.parent.GetChild(collision.transform.GetSiblingIndex() - 1));
            Destroy(collision.transform.parent.GetChild(collision.transform.GetSiblingIndex()-1).gameObject);
            Destroy(collision.gameObject);
            //Debug.Log("STAYING LOCK TARGET");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    
}
