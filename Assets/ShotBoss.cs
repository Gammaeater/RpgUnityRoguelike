using UnityEngine;

public class ShotBoss : MonoBehaviour
{

    public float bulletSpeed;
    public float TimeBetweenRangeShots;
    private float timeSinceLastRangeShot;
    private float angle;
    public Vector2 moveDirection;
    private Vector3 targetPos;
    private Vector3 thisPos;
    public GameObject bulletPrefab;
    public GameObject fireBall;
    public GameObject iceeBolt;
    public MinotourBoss targetBoss;
    // Start is called before the first frame update
    void Start()
    {
        targetBoss = GameObject.FindWithTag("BossMino").GetComponent("MinotourBoss") as MinotourBoss;
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(targetBoss.transform.position, transform.position);
        if (targetBoss.anim.GetBool("IsTargeted") == true)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {

                ShootFire();

            }
            else if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                ShootIce();
            }
            if (distance < 10f && targetBoss.enemyHealtSystem.GetHealth() >= 1)
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

        GameObject bullet = Instantiate(bulletPrefab, transform.position, targetBoss.transform.rotation);
        Rigidbody2D rbbullet2 = bullet.GetComponent<Rigidbody2D>();
        moveDirection = (targetBoss.transform.position - transform.position).normalized * bulletSpeed;
        rbbullet2.velocity = new Vector2(moveDirection.x, moveDirection.y);




        targetPos = targetBoss.transform.position;
        thisPos = rbbullet2.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        rbbullet2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));


    }
    public void ShootFire()
    {
        float offset = -90f;

        GameObject bullet = Instantiate(fireBall, transform.position, targetBoss.transform.rotation);
        Rigidbody2D rbbullet2 = bullet.GetComponent<Rigidbody2D>();
        moveDirection = (targetBoss.transform.position - transform.position).normalized * bulletSpeed;
        rbbullet2.velocity = new Vector2(moveDirection.x, moveDirection.y);




        targetPos = targetBoss.transform.position;
        thisPos = rbbullet2.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        rbbullet2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));


    }
    public void ShootIce()
    {
        float offset = -90f;

        GameObject bullet = Instantiate(iceeBolt, transform.position, targetBoss.transform.rotation);
        Rigidbody2D rbbullet2 = bullet.GetComponent<Rigidbody2D>();
        moveDirection = (targetBoss.transform.position - transform.position).normalized * bulletSpeed;
        rbbullet2.velocity = new Vector2(moveDirection.x, moveDirection.y);




        targetPos = targetBoss.transform.position;
        thisPos = rbbullet2.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        rbbullet2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));


    }
    
}
