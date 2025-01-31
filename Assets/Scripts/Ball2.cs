using UnityEngine;

public class Ball2 : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    float speed = 7f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Launch();
    }

    public void Launch(Vector3 direction)
    {
        Vector3 movement =direction * speed;
        rb.AddForce(movement, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        rb.linearVelocity = Vector3.zero;
        transform.position = Vector3.zero;
        //Launch(GetRandomBallDirection());
    }

    
}
