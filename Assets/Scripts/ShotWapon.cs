using System.Collections;
using UnityEngine;

public class ShotWapon : MonoBehaviour


{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Bat targetBat;
    public float TimeBetweenRangeShots;
    private float timeSinceLastRangeShot;
    public float bulletSpeed;
    public Vector2 moveDirection;

    void Start()
    {
        targetBat = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;

    }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(targetBat.transform.position, transform.position);
        if (targetBat.isTargeted == true)
        {
            if (distance < 10f && targetBat.enemyHealtSystem.GetHealth() >= 1)
            {
                if (Time.time > timeSinceLastRangeShot + TimeBetweenRangeShots)
                {
                    Debug.Log("Im Tryin to kill u u wack ass sucker");
                    Shoot();
                    Debug.Log("Shooooooooooooooooot without Ammo but im still tryin'");



                    timeSinceLastRangeShot = Time.time;

                }




            }
        }


    }

    public void Shoot()
    {
        //shooting logic spawning bullet
        //yield return new WaitForSeconds(2);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rbbullet2 = bullet.GetComponent<Rigidbody2D>();
        moveDirection = (targetBat.transform.position - transform.position).normalized * bulletSpeed;
        rbbullet2.velocity = new Vector3(moveDirection.x, moveDirection.y);
        Debug.Log("Spawn ammo + nadanie rotacji");
       // rbbullet2.AddForce(firePoint.position * bulletSpeed, ForceMode2D.Force);
        //rbbullet2.position = Vector2.MoveTowards(rbbullet2.position, targetBat.transform.position, bulletSpeed * Time.deltaTime);


    }
}
