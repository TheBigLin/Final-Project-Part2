using UnityEngine;

public class SpawnAlien : MonoBehaviour
{
    [SerializeField] GameObject spawnee;
    [SerializeField] float sizeX = 1.0f;
    [SerializeField] float sizeY = 1.0f;
    [SerializeField] float SpawnCooldown = 2.0f;

    private float spawnTime;

    void Start()
    {
        spawnTime = SpawnCooldown;
    }

    void Update()
    {
        if (spawnTime > 0)
            spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Spawn();
            spawnTime = SpawnCooldown; // Reset cooldown after spawning
        }
    }

    void Spawn()
    {
        float xPos = (Random.value - 0.5f) * sizeX + transform.position.x;
        float yPos = (Random.value - 0.5f) * sizeY + transform.position.y;

        var spawn = Instantiate(spawnee);
        spawn.transform.position = new Vector3(xPos, yPos, 0);
    }
}
