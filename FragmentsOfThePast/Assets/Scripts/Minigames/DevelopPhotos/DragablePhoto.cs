using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragablePhoto : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 startPoint;
    Vector2 cursorPosition;
    
    Rigidbody2D rb;
    public bool isGoodVelocity = false;

    public bool isCursorDragging = false;
    float speed = 2;
    float angleOffset = 0;

    [SerializeField] Vector3 redContainerPosition;
    Vector3 grayContainerPosition;

    bool hasCompletedRed = false;
    bool hasCompletedReveal = false;
    public bool disableDrag = false;

    public bool startDrying = false;
    float timeToDry = 3;
    float timeElapsedDry = 0;

    Image outlinePhoto;

    ScreenTransition transition;

    [SerializeField] CheckpointManager[] checkpointManagers;
    CheckpointManager currentCheckpointManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //redContainerPosition = GameObject.Find("RedContainer").transform.position;
        grayContainerPosition = GameObject.Find("PurpleContainer").transform.position;

        outlinePhoto = transform.GetChild(0).GetComponent<Image>();

        transition = GetComponentInParent<ScreenTransition>();

        checkpointManagers = transform.parent.GetComponentsInChildren<CheckpointManager>();
        currentCheckpointManager = checkpointManagers[0];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.SetParent(transform.parent.parent.GetChild(1));
            StartCoroutine(LerpTo(new(-680, -400, 0), true));
            StartCoroutine(transition.TransitionToDryingRope());
            hasCompletedReveal = true;
        }

        if (isCursorDragging)
        {
            CalculateVelocity();

            RevealPhotos();
        }
        else
        {
            angleOffset = 0;
            if (!hasCompletedReveal)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 0, 0);
            }
            
        }

        if (startDrying)
        {
            DryPhotos();
        }
    }

    #region Reveal Photos
    void FlipPhoto()
    {
        if (rb.velocity.y < 0) angleOffset = 0; else angleOffset = -180;
    }

    void CalculateVelocity()
    {
        if (disableDrag) { return; }
        Vector3 vector = new Vector3(cursorPosition.x, cursorPosition.y, 0) - new Vector3(transform.position.x, transform.position.y, 0);
        float distance = vector.magnitude;
        Vector3 direction = vector.normalized;
        rb.velocity = direction * distance * speed;
    }

    void CalculateOutlineAlpha()
    {
        outlinePhoto.color = new Color(outlinePhoto.color.r, outlinePhoto.color.g, outlinePhoto.color.b, currentCheckpointManager.currentLaps / currentCheckpointManager.totalLaps);
    }

    void CheckVelocity()
    {
        if (rb.velocity.magnitude > 600 || rb.velocity.magnitude < 100)
        {
            isGoodVelocity = false;
            //Debug.Log("TOO FAST OR TOO SLOW");
        }
        else
        {
            isGoodVelocity = true;
            //Debug.Log("NICE");
        }
    }

    public void CompleteStep()
    {
        if (!hasCompletedRed)
        {
            currentCheckpointManager = checkpointManagers[1];
            outlinePhoto.color = new Color(outlinePhoto.color.r, outlinePhoto.color.g, outlinePhoto.color.b, 0);
            StartCoroutine(LerpTo(grayContainerPosition, false));
            hasCompletedRed = true;
        }
        else
        {
            transform.SetParent(transform.parent.parent.GetChild(1));
            StartCoroutine(LerpTo(new(-680, -400, 0), true));
            StartCoroutine(transition.TransitionToDryingRope());
            hasCompletedReveal = true;
        }
    }

    void RevealPhotos()
    {
        if (hasCompletedReveal) { return; }

        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-Mathf.Clamp(rb.velocity.y / 5 + angleOffset, -200, 50), Mathf.Atan(rb.velocity.y/rb.velocity.x) * Mathf.Rad2Deg, 0), 0.05f);
        
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rb.velocity.y / 6, 0, Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg), 0.05f);
        FlipPhoto();
        CalculateOutlineAlpha();
        CheckVelocity();
    }

    #endregion


    #region Dry Photos
    void DryPhotos()
    {
        timeElapsedDry += Time.deltaTime;

        if (timeElapsedDry >= timeToDry)
        {
            // Reveal Photo
            // Zoom Photo

            Debug.Log("SHOW FOTO");
        }
    }

    #endregion

    IEnumerator LerpTo(Vector3 newPosition, bool isLocal)
    {
        if (!isLocal)
        {
            disableDrag = true;
            cursorPosition = newPosition;
            rb.velocity = Vector2.zero;
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0, 0);
            while (transform.position != newPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, newPosition, 5);
                yield return null;
            }
            disableDrag = false;
        }
        else
        {
            disableDrag = true;
            cursorPosition = newPosition;
            rb.velocity = Vector2.zero;
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0, 180);
            while (transform.localPosition != newPosition)
            {
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, newPosition, 5);
                yield return null;
            }
            disableDrag = false;
            yield return new WaitForSeconds(2);
        }
    }

    #region Mouse Events
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        startPoint = eventData.pressPosition;
        cursorPosition = eventData.pressPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (disableDrag) { return; }
        isCursorDragging = eventData.dragging;
        cursorPosition = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isCursorDragging = false;

        if (hasCompletedReveal)
        {
            rb.velocity = Vector2.zero;
        }
    }
    #endregion
}
