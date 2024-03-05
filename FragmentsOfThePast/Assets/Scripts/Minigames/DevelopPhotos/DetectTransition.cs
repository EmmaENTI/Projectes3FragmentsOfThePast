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
        if (transform.parent.name == "ProcessPhoto")
        {
            Debug.Log("Entered ProcessPhoto");
            StartCoroutine(transition.TransitionToDryingRope());
        }   
        else if (transform.parent.name == "DryingRope")
        {
            Debug.Log("Entered DryingRope");
            StartCoroutine(transition.TransitionToProcessPhoto());
        }
    }
}
