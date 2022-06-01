using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // The reason this is called "Fixed" update is because we are using it for physics
    void FixedUpdate()
    {
        // Adding forward force for the player
         rb.AddForce(0, 0, forwardForce * Time.deltaTime);

         if (Input.GetKey("d"))
         {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }
         if (Input.GetKey("a"))
         {
             rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }
    }
}
