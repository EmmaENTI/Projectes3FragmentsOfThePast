using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreateChip : MonoBehaviour, IPointerDownHandler
{
    ChipManager chipManager;

    private void Start()
    {
        chipManager = transform.parent.GetComponentInChildren<ChipManager>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            chipManager.LoseChips();
            GameObject obj = Instantiate(chipManager.chipPrefab, transform.position, Quaternion.identity, transform);
            obj.name = chipManager.chipPrefab.name;
        }
    }
}
