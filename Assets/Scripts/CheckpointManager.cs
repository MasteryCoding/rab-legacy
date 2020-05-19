using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public GameObject ball;
    private Vector3 lastCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        lastCheckpoint = ball.transform.position;
    }

    public void SetNewCheckpoint(Vector3 newCheckpoint)
    {
        lastCheckpoint = newCheckpoint;
        Debug.Log("New checkpoint set at: " + newCheckpoint.ToString());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            other.transform.position = lastCheckpoint;
            Debug.Log("Reset ball to checkpoint");
        }
    }
}
