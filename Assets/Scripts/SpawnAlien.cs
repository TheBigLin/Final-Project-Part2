using UnityEngine;

public class SpawnAlien : MonoBehaviour
{
    [SerializeField] private GameObject spawnee; // Alien prefab
    [SerializeField] private float sizeX = 1.0f;
    [SerializeField] private float sizeY = 1.0f;
    [SerializeField] private float spawnCooldown = 2.0f;

    private float spawnTime;

    [SerializeField] private Transform player; // Player reference

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
            spawnTime = spawnCooldown;
        }

        void Spawn()
        {
            float xPos = (Random.value - 0.5f) * sizeX + transform.position.x;
            float yPos = (Random.value - 0.5f) * sizeY + transform.position.y;

            GameObject spawnedAlien = Instantiate(spawnee, new Vector3(xPos, yPos, 0), Quaternion.identity);

            AlienFollow alienFollow = spawnedAlien.GetComponent<AlienFollow>();
            if (alienFollow != null)
            {
                alienFollow.SetTarget(player);
            }
        }
    }
}
    


