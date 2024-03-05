using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetection : MonoBehaviour
{
    CheckpointManager checkpointManager;

    private void Start()
    {
        checkpointManager = transform.GetComponentInParent<CheckpointManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Photo"))
        {
            checkpointManager.PhotoDetected(transform.name);
        }
    }
}
