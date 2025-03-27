using UnityEngine;

public class RunToPlayer : MonoBehaviour
{
    [SerializeField] private Transform player; // Assign Player Transform in Inspector
    [SerializeField] private float speed = 15.0f;

    void Update()
    {
     
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}