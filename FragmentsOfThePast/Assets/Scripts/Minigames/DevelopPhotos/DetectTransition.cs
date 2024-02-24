using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DetectTransition : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] ScreenTransition transition;

    private void Start()
    {
        transition = GetComponentInParent<ScreenTransition>();
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log(transform.parent.name);

        if (transform.parent.name == "ProcessPhoto")
        {
            Debug.Log("Entered ProcessPhoto");
            transition.LockProcessPhoto();
            StartCoroutine(transition.TransitionToDryingRope());
        }
        else if (transform.parent.name == "DryingRope")
        {
            Debug.Log("Entered DryingRope");
            transition.LockDryingRope();
            StartCoroutine(transition.TransitionToProcessPhoto());
        }
    }
}
