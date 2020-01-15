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
    public Vector2 lookAngle;
    public Vector2 lookDirection;



    private Transform target;
    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;


    void Start()
    {
        targetBat = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
       // firePoint = GameObject.FindWithTag("PlayerII").GetComponent("FirePoint").transform;
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
                    





                    timeSinceLastRangeShot = Time.time;

                }




            }
        }


    }

    public void Shoot()
    {
        float offset = -90f;
        
        GameObject bullet = Instantiate(bulletPrefab, transform.position, targetBat.transform.rotation);
        Rigidbody2D rbbullet2 = bullet.GetComponent<Rigidbody2D>();
        moveDirection = (targetBat.transform.position - transform.position).normalized * bulletSpeed;
        rbbullet2.velocity = new Vector2(moveDirection.x, moveDirection.y);

        Debug.Log("Spawn ammo + nadanie KIERUNKU LOTU");


        targetPos = targetBat.transform.position;
        thisPos = rbbullet2.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        rbbullet2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));


    }

}
