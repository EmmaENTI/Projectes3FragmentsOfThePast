using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{

    Dictionary<string, bool> currentCheckpoint;
    int checkpointId = 0;

    public float currentLaps = 0;
    public float totalLaps = 3;
    public float checkpointsDone = 0;

    [SerializeField] DragablePhoto photo;

    void Start()
    {
        currentCheckpoint = new();

        for (int i = 0; i < 8; i++)
        {
            if (i == 0)
            {
                currentCheckpoint.Add("CheckPoint" + i, true);
                continue;
            }

            currentCheckpoint.Add("CheckPoint"+i, false);
        }
    }

    public void PhotoDetected(string checkpointName)
    {
        // Possible Refactor cridant CheckVelocity i que aquesta funcio retorni un bool
        if (!photo.isGoodVelocity) { return; }

        if (currentCheckpoint[checkpointName])
        {
            currentCheckpoint[checkpointName] = false;

            checkpointsDone++;
            checkpointId++;
            checkpointId %= 8;

            if (checkpointId == 0)
            {
                currentLaps++;
            }

            if (currentLaps == totalLaps)
            {
                photo.CompleteStep();
            }

            currentCheckpoint["CheckPoint"+checkpointId] = true;
        }
    }
}
