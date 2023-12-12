using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateLockPick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector3 startPoint;
    Vector3 endPoint;

    private float startRotationZ;


    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        startPoint = eventData.pressPosition;
        startRotationZ = transform.eulerAngles.z;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 pivotWorld = transform.position;

        Vector3 pivotToMouse = Input.mousePosition - pivotWorld;
        float currentRotationZ = -Mathf.Atan2(pivotToMouse.x, pivotToMouse.y) * Mathf.Rad2Deg;

        // Precise Lock Pick
        float rotationDelta = currentRotationZ - startRotationZ;
        transform.Rotate(Vector3.forward, rotationDelta * 0.5f);


        // Funky LockPick
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, currentRotationZ *0.8f);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        
        startRotationZ = currentRotationZ;

        rb.isKinematic = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rb.isKinematic = false;
    }

}