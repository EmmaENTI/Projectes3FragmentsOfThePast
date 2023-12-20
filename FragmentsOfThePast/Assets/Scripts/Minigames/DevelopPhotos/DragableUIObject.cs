using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragablePhoto : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 startPoint;
    Vector2 endPoint;

    Rigidbody2D rb;

    [SerializeField] float maxRotation = 70.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        startPoint = eventData.pressPosition;
        endPoint = eventData.pressPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        endPoint = eventData.position;

        transform.position = endPoint;

        rb.isKinematic = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rb.isKinematic = false;
    }
}
