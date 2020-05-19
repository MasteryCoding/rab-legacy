using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public CheckpointManager chkMgr;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            chkMgr.SetNewCheckpoint(transform.position);
            Debug.Log("Checkpoint reached!");
        }
    }
}
