using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragablePhoto : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 startPoint;
    Vector2 cursorPosition;

    Rigidbody2D rb;

    [SerializeField] float maxRotation = 70.0f;

    bool isCursorDragging = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isCursorDragging)
        {
            Debug.Log(cursorPosition);

            Vector3 vector = new Vector3(0, cursorPosition.y, 0) - new Vector3(0, transform.position.y, 0);

            float distance = vector.magnitude;

            Vector3 direction = vector.normalized;

            rb.velocity = direction * distance;
        }
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        startPoint = eventData.pressPosition;
        cursorPosition = eventData.pressPosition;
    }

    

    public void OnDrag(PointerEventData eventData)
    {
        isCursorDragging = eventData.dragging;
        cursorPosition = eventData.position;

        rb.isKinematic = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rb.isKinematic = false;
    }
}
