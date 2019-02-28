using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Reference to Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

    // I marked this as FixedUpdate
    // because we use it to mess with physics
    void FixedUpdate()
    {
        if (Input.GetKey("w"))// if the player presses key "w"
        {
            // add a forward force
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))// if the player presses key "s"
        {
            // add a backward force
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))//if the player presses key "d"
        {
            //add force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))//if the player presses key "a"
        {
            //add force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}