using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChipChoice : MonoBehaviour
{
    [SerializeField] ChipManager chipManager;
    void Start()
    {
       chipManager = transform.parent.GetComponentInChildren<ChipManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Chip")
        {
            if (transform.name == "LeftChoice")
            {
                chipManager.isLeftChoice = true;
            }
            else if (transform.name == "RightChoice")
            {
                chipManager.isRightChoice = true;
            }
        }
    }
}
