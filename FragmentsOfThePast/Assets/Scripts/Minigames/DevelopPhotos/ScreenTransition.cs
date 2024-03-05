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

    void Start()
    {
        processPhotoScreen = transform.GetChild(0).gameObject;
        dryingRopeScreen = transform.GetChild(1).gameObject;
    }

    public IEnumerator TransitionToDryingRope()
    {
        while (processPhotoScreen.transform.localPosition != processPhotoOB)
        {
            processPhotoScreen.transform.localPosition = Vector3.MoveTowards(processPhotoScreen.transform.localPosition, processPhotoOB, 15);
            dryingRopeScreen.transform.localPosition = Vector3.MoveTowards(dryingRopeScreen.transform.localPosition, Vector3.zero, 15);

            yield return null;
        }
    }

    public IEnumerator TransitionToProcessPhoto()
    {
        while (dryingRopeScreen.transform.localPosition != dryingRopeOB)
        {
            dryingRopeScreen.transform.localPosition = Vector3.MoveTowards(dryingRopeScreen.transform.localPosition, dryingRopeOB, 15);
            processPhotoScreen.transform.localPosition = Vector3.MoveTowards(processPhotoScreen.transform.localPosition, Vector3.zero, 15);

            yield return null;
        }
    }
}
