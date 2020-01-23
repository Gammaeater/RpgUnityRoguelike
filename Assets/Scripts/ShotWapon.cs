using UnityEngine;

public class ShotWapon : MonoBehaviour


{
    private float angle;
    public float TimeBetweenRangeShots;
    private float timeSinceLastRangeShot;

    public float bulletSpeed;
    public GameObject bulletPrefab;
    public Bat targetBat;
    public Vector2 lookDirection;
    public Animator _animator;
    public Transform firePoint;
    private Transform target;
    public Vector2 moveDirection;
    private Vector3 targetPos;
    private Vector3 thisPos;

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

        


        targetPos = targetBat.transform.position;
        thisPos = rbbullet2.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        rbbullet2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));


    }

}
