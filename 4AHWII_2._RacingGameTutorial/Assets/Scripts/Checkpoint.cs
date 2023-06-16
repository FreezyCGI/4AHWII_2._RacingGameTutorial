using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool IsChecked = false;
    private CHeckpointManager CHeckpointManager;

    private void Start()
    {
        CHeckpointManager = GameObject.FindObjectOfType<CHeckpointManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        IsChecked = true;
    }

    public void Reset()
    {
        IsChecked = false;
    }
}
