using UnityEngine;
using UnityEngine.UI;
public abstract class AlienBase : MonoBehaviour
{
    protected float health = 100.0f;

    public abstract void TakeDamage(float damage);

    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.scoreValue += 10;
        Projectile projectile = collision.GetComponent<Projectile>();
        TakeDamage(projectile.damage);
        if (health <= 0.0f)
            Destroy(gameObject);            // Destroy the target
        Destroy(collision.gameObject);      // Destroy the bullet
    }
}