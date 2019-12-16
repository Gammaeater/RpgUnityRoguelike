using UnityEngine;

public class ShotWapon : MonoBehaviour


{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;


    // Update is called once per frame
    void Update()
    {
        // input for shoot

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        };







    }

    void Shoot()
    {
        //shooting logic spawning bullet

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rbbullet2 = bullet.GetComponent<Rigidbody2D>();
        rbbullet2.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);


    }
}
