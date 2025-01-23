using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private float speed = 9.0f;
    private float horizontalInput;
    //Get the value of the Horizontal input axis.

    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        //Vector3 movement = new Vector3(movementX, 0.0f, movementY);
    }
}
