using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Adjust speed as needed
    private Vector2 direction = Vector2.zero;

    void Update()
    {
        // Reset direction to zero every frame to avoid accumulating input
        direction = Vector2.zero;

        // Check for input and update direction
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

        if (direction.magnitude > 0)
        {
            direction.Normalize();
        }

        Vector3 movement = new Vector3(direction.x, direction.y, 0) * moveSpeed * Time.deltaTime;
        transform.position += movement;
    }
}
