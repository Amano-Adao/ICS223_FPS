using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField]
    private string vertInputAxis = "VerticalP1";
    [SerializeField]
    Rigidbody rb;

    float vertInput;
    float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertInput = Input.GetAxisRaw(vertInputAxis);

    }

    private void FixedUpdate()
    {
        
            
        
        Vector3 movement = Vector3.up * vertInput * speed * Time.deltaTime;
        Vector3 newPos = transform.position + movement;
        newPos.y = Mathf.Clamp(newPos.y, -4, 4);
        rb.MovePosition(newPos);
    }
}
