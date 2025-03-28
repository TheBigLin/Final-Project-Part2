using UnityEngine;
using UnityEngine.UI;
public abstract class AlienBase : MonoBehaviour
{
    protected float health = 100.0f;

    public abstract void TakeDamage(float damage);

    void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< HEAD
        ScoreScript.scoreValue += 10;
        Projectile projectile = collision.GetComponent<Projectile>();
        TakeDamage(projectile.damage);
=======
        Bullets Bullets = collision.GetComponent<Bullets>();
        TakeDamage(Bullets.damage);
>>>>>>> 9e6a36fe706565884ab4494a18e8b21ff4665b88
        if (health <= 0.0f)
            Destroy(gameObject);            // Destroy the target
        Destroy(collision.gameObject);      // Destroy the bullet
    }
}