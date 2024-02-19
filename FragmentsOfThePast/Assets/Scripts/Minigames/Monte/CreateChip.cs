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
        if (transform.childCount == 0)
        {
            GameObject obj = Instantiate(chipPrefab, transform.position, Quaternion.identity, transform);
            obj.name = chipPrefab.name;
        }
    }
}
