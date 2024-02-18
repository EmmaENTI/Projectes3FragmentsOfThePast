using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreateChip : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update

    [SerializeField] GameObject chipPrefab;


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("EI");
        if (transform.childCount == 0)
        {
            Instantiate(chipPrefab, transform.position, Quaternion.identity, transform);
        }
    }
}
