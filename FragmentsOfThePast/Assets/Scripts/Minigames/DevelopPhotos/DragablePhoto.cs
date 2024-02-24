using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragablePhoto : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 startPoint;
    Vector2 cursorPosition;

    Rigidbody2D rb;

    //[SerializeField] float maxRotation = 70.0f;

    bool isCursorDragging = false;
    float speed = 2;
    float timeToComplete = 5;
    float timeElapsed = 0;
    float angleOffset = 0;

    [SerializeField] Vector3 redContainerPosition;
    [SerializeField] Vector3 grayContainerPosition;

    bool hasCompletedRed = false;
    bool hasCompletedReveal = false;
    public bool disableDrag = false;

    float timeToDry = 3;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        redContainerPosition = GameObject.Find("RedContainer").transform.position;
        grayContainerPosition = GameObject.Find("GrayContainer").transform.position;
    }

    private void Update()
    {
        if (isCursorDragging)
        {
            CalculateVelocity();

            RevealPhotos();

            DryPhotos();
        }
        else
        {
            angleOffset = 0;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }


    void CalculateVelocity()
    {
        if (disableDrag) { return; }

        Vector3 vector = new Vector3(cursorPosition.x, cursorPosition.y, 0) - new Vector3(transform.position.x, transform.position.y, 0);
        float distance = vector.magnitude;
        Vector3 direction = vector.normalized;
        rb.velocity = direction * distance * speed;
    }

    void FlipPhoto()
    {
        if (rb.velocity.y < 0) angleOffset = -180; else angleOffset = 0;
    }

    void CheckVelocity()
    {
        if (Mathf.Abs(rb.velocity.y) > 600)
        {
            Debug.Log("TOO FAST: " + rb.velocity.y);
        }
        else if (Mathf.Abs(rb.velocity.y) < 100)
        {
            Debug.Log("TOO SLOW: " + rb.velocity.y);
        }
        else
        {
            timeElapsed += Time.deltaTime;
        }

        CompleteStep();
    }

    void CompleteStep()
    {
        if (timeToComplete < timeElapsed)
        {
            // TODO Lerp to Next Stage

            if (!hasCompletedRed)
            {
                transform.position = grayContainerPosition;
                hasCompletedRed = true;
                timeElapsed = 0;
            }
            else
            {
                transform.SetParent(transform.parent.parent.GetChild(1));
                transform.localPosition = new(-680, -400, 0);
                hasCompletedReveal = true;
            }

        }
    }
    
    void RevealPhotos()
    {
        if (hasCompletedReveal) { return; }

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-Mathf.Clamp(rb.velocity.y / 5 + angleOffset, -250, 70), 0, 0), 0.05f);
        FlipPhoto();
        CheckVelocity();
    }

    void DryPhotos()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeToDry)
        {
            // Reveal Photo
            // Zoom Photo
        }
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        startPoint = eventData.pressPosition;
        cursorPosition = eventData.pressPosition;

        timeElapsed = 0;
    }

    public void OnDrag(PointerEventData eventData)
    {
        isCursorDragging = eventData.dragging;
        cursorPosition = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isCursorDragging = false;
        timeElapsed = 0;

        if (hasCompletedReveal)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
