using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 20f;
    public Rigidbody2D rbBullet;
    public PlayerIIMovment var;
    public ShotWapon target;

        // Start is called before the first frame update
    //void Start()
    //{
    //    rbBullet.velocity = transform.position
    //         * bulletSpeed ;
                    
    //}

 
    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed *Time.deltaTime);
    }
}
