using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float moveStrength;
    public float jumpStrength;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (isGrounded) {
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpStrength);
        }
        if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * moveStrength);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * moveStrength);
        }
        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * moveStrength);
        }
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * moveStrength);
        }
    }
}
