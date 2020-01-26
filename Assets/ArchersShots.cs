using UnityEngine;

public class ArchersShots : MonoBehaviour
{
    public float bulletSpeed;
    private float angle;
    public float TimeBetweenRangeShots;
    private float timeSinceLastRangeShot;
    public Vector2 moveDirectionLev2;
    public Vector3 targetPos;
    public Vector3 thisPos;
    public GameObject bulletPrefab;
    [SerializeField]
    public PlayerIIMovment _player;
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        //_player = GameObject.FindWithTag("PlayerII2lev").GetComponent("PlayerIIMovment") as PlayerIIMovment;
        float _distance = Vector3.Distance(_player.transform.position, transform.position);

        if (_distance < 10f)
        {
            if (Time.time > timeSinceLastRangeShot + TimeBetweenRangeShots)
            {
                Shootplayer();



                timeSinceLastRangeShot = Time.time;
            }

        }
    }


    void Shootplayer()
    {
        float offset = -90f;

        GameObject bullet = Instantiate(bulletPrefab, transform.position, _player.transform.rotation);
        Rigidbody2D rbbullet2 = bullet.GetComponent<Rigidbody2D>();
        moveDirectionLev2 = (_player.transform.position - transform.position).normalized * bulletSpeed;
        rbbullet2.velocity = new Vector2(moveDirectionLev2.x, moveDirectionLev2.y);


        targetPos = _player.transform.position;
        thisPos = rbbullet2.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        rbbullet2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));
    }
}

