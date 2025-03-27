using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    public float moveSpeed = 40.0f; // Adjust speed as needed
    private Vector2 direction = Vector2.zero;
    private bool FacingRight = true;

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
  
        Vector3 movement = new Vector3(direction.x, direction.y, 0) * moveSpeed * Time.deltaTime;
        transform.position += movement;

        Flip();
    }

    private void Flip()
    {
        if (FacingRight && horizontal < 0f || !FacingRight && horizontal > 0f)
        {
            FacingRight = !FacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
