using UnityEngine;

public class SpawnAliens : MonoBehaviour
{
    [SerializeField] private GameObject spawnee;
    [SerializeField] private float sizeX = 1.0f;
    [SerializeField] private float sizeY = 1.0f;
    [SerializeField] private float spawnCooldown = 2.0f;

    private float spawnTime;

    void Start()
    {
        spawnTime = spawnCooldown;
    }

    void Update()
    {
        if (spawnTime > 0)
            spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Spawn();
            spawnTime = spawnCooldown; // Reset cooldown after spawning
        }
    }

    void Spawn()
    {
        if (spawnee == null)
        {
            Debug.LogWarning("Spawnee GameObject is not assigned.");
            return;
        }

        float xPos = (Random.value - 0.5f) * sizeX + transform.position.x;
        float yPos = (Random.value - 0.5f) * sizeY + transform.position.y;

        Instantiate(spawnee, new Vector3(xPos, yPos, 0), Quaternion.identity);
    }
}
