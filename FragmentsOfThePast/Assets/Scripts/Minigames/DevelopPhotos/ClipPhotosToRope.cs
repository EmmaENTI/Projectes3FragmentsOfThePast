using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipPhotosToRope : MonoBehaviour
{
    GameObject frontClip;
    GameObject backClip;

    private void Start()
    {
        frontClip = transform.parent.GetChild(0).gameObject;
        backClip = transform.parent.GetChild(2).gameObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Photo"))
        {
            collision.transform.position = new(collision.transform.position.x, transform.position.y+110, 0);
            collision.GetComponent<DragablePhoto>().disableDrag = true;

            if (collision.GetComponent<DragablePhoto>().isCursorDragging) return;
            collision.GetComponent<DragablePhoto>().startDrying = true;

            collision.transform.rotation = Quaternion.Euler(collision.transform.rotation.x, collision.transform.rotation.y, 180);

            frontClip.SetActive(true);

            backClip.SetActive(true);
            backClip.transform.SetAsLastSibling();

            frontClip.transform.position = collision.transform.position + new Vector3(0, 190,0);
            backClip.transform.position = collision.transform.position + new Vector3(0, 190, 0);
        }
    }
}
