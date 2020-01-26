using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotourBoss : MonoBehaviour
{
    public Vector2 movment;
    public Transform _target;
    public float chaseRaidus;
    public float attackRadius;
    public float TimeBetweenShots;
    private float timeSinceLastShot;
    public Animator anim;
    public PlayerIIMovment _playerTarget;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("PlayerII").transform;

        anim = GetComponent<Animator>();
        _playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movment.x = transform.position.normalized.x;
        movment.y = transform.position.normalized.y;

        movment = transform.position;
       
        anim.SetFloat("Horizontal", movment.normalized.x);
        anim.SetFloat("Vertical", movment.y);
        anim.SetFloat("Speed", moveSpeed);
        CheckDistance();
        float distance = Vector3.Distance(_target.transform.position, transform.position);

        

        if (distance < 2.5f )


        {



            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {

                //StartCoroutine(DmgSpawn());
               // Attack(3f);




                timeSinceLastShot = Time.time;

            


            }











        }





    }

    public void CheckDistance()

    {


        if (Vector2.Distance(_target.position, transform.position) <= chaseRaidus
            && Vector2.Distance(_target.position, transform.position) > attackRadius)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, moveSpeed * Time.deltaTime);
           






        }




    }

    public void Attack(float damage)
    {

        //randomBonusHit = (float)Random.Range(1, 5);
       // batfullAttack = baseAtack + randomBonusHit;

        _playerTarget.playerHealtShystem.Damage(damage);







    }


    public void Attack2(float damage)
    {

        //randomBonusHit = (float)Random.Range(1, 5);
        // batfullAttack = baseAtack + randomBonusHit;

        _playerTarget.playerHealtShystem.Damage(damage);







    }

    public void Attack3(float damage)
    {

        //randomBonusHit = (float)Random.Range(1, 5);
        // batfullAttack = baseAtack + randomBonusHit;

        _playerTarget.playerHealtShystem.Damage(damage);







    }

}
