using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth;
    [SerializeField] public GameObject Player;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
      
        if (currentHealth <= 0)
        {
            GameObject.Destroy(Player);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }

 
}
