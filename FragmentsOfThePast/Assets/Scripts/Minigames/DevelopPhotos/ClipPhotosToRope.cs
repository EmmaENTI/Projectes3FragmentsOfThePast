using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipPhotosToRope : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Photo"))
        {
            collision.transform.position = new(collision.transform.position.x, transform.position.y, 0);
            collision.GetComponent<DragablePhoto>().disableDrag = true;
        }
    }
}
