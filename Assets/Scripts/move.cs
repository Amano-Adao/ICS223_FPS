using UnityEngine;

public class move : MonoBehaviour
{
    // Rigidbody of the player.
    private Rigidbody rb;
    private float horizontalInput;
    //Get the value of the Horizontal input axis.
    private float speed = 5;
    private float verticalInput;
    //Get the value of the Vertical input axis.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
       
        horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

    }

    void FixedUpdate()
    {
        rb.transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
    }


}
