using UnityEngine;

public class AlienFollow : MonoBehaviour
{
    private Transform target; // Player's position
    [SerializeField] private float speed = 3.0f; // Movement speed

    void Update()
    {
       

        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    public void SetTarget(Transform player)
    {
        target = player; 
    }
}