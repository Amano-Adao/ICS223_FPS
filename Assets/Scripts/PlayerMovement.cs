using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    // Rigidbody of the player.
    private Rigidbody rb;
   

    private float horizontalInput;
    //Get the value of the Horizontal input axis.

    private float verticalInput;
    //Get the value of the Vertical input axis.
    // Speed at which the player moves.
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get and store the Rigidbody component attached to the player.
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3 (horizontalInput, 0, verticalInput) * speed * 100 * Time.deltaTime;
        //rb.transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        
        //// Create a 3D movement vector using the X and Y inputs.
        //Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        //// Apply force to the Rigidbody to move the player.
        //rb.AddForce(movement * speed);
    }
}
