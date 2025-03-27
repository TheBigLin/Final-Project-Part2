using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;  // Bullet speed


  

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }


        void Shoot()
        {
          
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

          
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * bulletSpeed; 
        }
    }



}


