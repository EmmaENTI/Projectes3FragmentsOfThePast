using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ScreenTransition : MonoBehaviour
{
    [SerializeField] GameObject processPhotoScreen;
    [SerializeField] GameObject dryingRopeScreen;

    Vector3 processPhotoOB = new(-1920, 0, 0);
    Vector3 dryingRopeOB = new(1920, 0, 0);

    bool lockToDryingRope = false;
    bool lockToProcessPhoto = false;

    void Start()
    {
        processPhotoScreen = transform.GetChild(0).gameObject;
        dryingRopeScreen = transform.GetChild(1).gameObject;

        //processPhotoScreen = transform.GetChild(0).gameObject.GetComponent<RectTransform>();
        //dryingRopeScreen = transform.GetChild(1).gameObject.GetComponent<RectTransform>();
    }

    void Update()
    {
        for (int i = 0; i < dryingRopeScreen.transform.childCount; i++)
        {
            Debug.Log(dryingRopeScreen.transform.GetChild(i).name);
        }
        
        //TransitionToDryingRope();
        //StartCoroutine(TransitionToProcessScreen());
    }

    public IEnumerator TransitionToDryingRope()
    {
        if (lockToDryingRope) { yield break; }

        while (processPhotoScreen.transform.localPosition != processPhotoOB)
        {
            processPhotoScreen.transform.localPosition = Vector3.MoveTowards(processPhotoScreen.transform.localPosition, processPhotoOB, 15);
            dryingRopeScreen.transform.localPosition = Vector3.MoveTowards(dryingRopeScreen.transform.localPosition, Vector3.zero, 15);

            yield return null;
        }

        lockToProcessPhoto = false;
    }

    public IEnumerator TransitionToProcessPhoto()
    {
        if (lockToProcessPhoto) { yield break; }

        while (dryingRopeScreen.transform.localPosition != dryingRopeOB)
        {
            dryingRopeScreen.transform.localPosition = Vector3.MoveTowards(dryingRopeScreen.transform.localPosition, dryingRopeOB, 15);
            processPhotoScreen.transform.localPosition = Vector3.MoveTowards(processPhotoScreen.transform.localPosition, Vector3.zero, 15);

            yield return null;
        }

        lockToDryingRope = false;
    }

    public void LockDryingRope()
    {
        lockToDryingRope = true;
    }

    public void LockProcessPhoto()
    {
        lockToProcessPhoto = true;
    }
}
