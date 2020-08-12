using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2500;
    // Reference to the Rigidbody component called rb
    public Rigidbody rb;
    // Market as "Fixed"Update because we are
    // using it to mess with physics
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {   // Add forward force (float x, float y, float z, ForceMode mode = ForceMode.Force "Type of force to apply"))
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
    }
}
