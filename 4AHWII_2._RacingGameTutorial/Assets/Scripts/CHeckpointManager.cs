using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHeckpointManager : MonoBehaviour
{

    private Checkpoint[] checkpoints;

    // Start is called before the first frame update
    void Start()
    {
        checkpoints = GameObject.FindObjectsOfType<Checkpoint>();
    }

    public void OnCheckPointTriggered()
    {

    }

    private bool CheckIfAllCheckpointsHit()
    {
        foreach(Checkpoint checkpoint in checkpoints)
        {
            if(!checkpoint.IsChecked)
            {
                return false;
            }
        }

        return true;
    }

    private void ResetCheckpoints()
    {
        foreach (Checkpoint checkpoint in checkpoints)
        {
            checkpoint.Reset();
        }
    }
}
