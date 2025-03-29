using UnityEngine.SceneManagement;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public string SceneName;
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
            SceneManager.LoadScene(SceneName);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TakeDamage(1);
        }
    }


}
