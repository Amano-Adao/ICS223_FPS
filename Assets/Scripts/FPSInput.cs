using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private float speed = 9.0f;
    private float gravity = -9.8f;
    private CharacterController charController;
    private float horizontalInput;
    //Get the value of the Horizontal input axis.

    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        ////Get the value of the Horizontal input axis.

        //verticalInput = Input.GetAxis("Vertical");
        ////Get the value of the Vertical input axis.
        float horizInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizInput, 0, vertInput);
        // Clamp magnitude to limit diagonal movement
        movement = Vector3.ClampMagnitude(movement, 1.0f);
        // take speed into account
        movement *= speed;

        movement.y = gravity;

        // make movement processor independent
        movement *= Time.deltaTime;
        // Convert local to global coordinates
        movement = transform.TransformDirection(movement);
        charController.Move(movement);
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        //Vector3 movement = new Vector3(movementX, 0.0f, movementY);
    }
}
