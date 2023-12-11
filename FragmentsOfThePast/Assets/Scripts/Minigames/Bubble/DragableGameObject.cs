using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableGameObject : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        Vector2 mousePosition = (Vector2)Input.mousePosition;

        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = new Vector3(objPosition.x, objPosition.y, 0);

        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        rb.isKinematic = false;
    }
}
