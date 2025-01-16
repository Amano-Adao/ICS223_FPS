using UnityEngine;

public class wheel : MonoBehaviour
{
    private float speed = 180;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
    }
}
