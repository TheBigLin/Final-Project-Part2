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

            Vector3 mouse = Input.mousePosition;
            mouse = Camera.main.ScreenToWorldPoint(mouse);
            mouse.z = 0.0f;
            Vector3 mouseDirection = (mouse - transform.position).normalized;
            Debug.DrawLine(transform.position, transform.position + mouseDirection * 5.0f);

        }


        void Shoot()
        {
          
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

          
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * bulletSpeed;



        }
    }



}


