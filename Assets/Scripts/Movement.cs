using UnityEngine;

public class Movement : MonoBehaviour
{

    float moveSpeed = 50.0f;

   
    Vector2 direction = Vector2.zero;
    float dt;


    void Start()
    {

        float dt = Time.deltaTime;
        Vector2 direction = Vector2.zero;
        Vector3 movement = direction * moveSpeed * dt;
        transform.position += movement;

    }
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }
}