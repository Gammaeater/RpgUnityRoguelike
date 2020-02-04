using UnityEngine;
using UnityEngine.UI;

public class MinotourBoss : EnemyController 
{
    public Vector2 movment;
    public Vector2 playermovment;
    public Transform _target;
    public float chaseRaidus;
    public float attackRadius;
    public float TimeBetweenShots;
    private float timeSinceLastShot;
    public float comboAttackTimme;
    public Animator anim;
    public PlayerIIMovment _playerTarget;
    //public float moveSpeed;
    public float randomBonusHit;
    public float minoFullAttack;
    public HealthSystem playerHealtShystem;
    public LevelSystem playerlevelSystem;
    public HealthSystem minoHealtShystem;
    public Slider healthBar;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("PlayerBossLevel").transform;
        baseAtack = 4f;

        
        healthBar.gameObject.SetActive(true);


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        healthBar.value = minoHealtShystem.GetHealth();
        movment.x = transform.position.x;
        playermovment.x = _target.position.x;
        if(minoHealtShystem.GetHealth() <= 50)
        {
            anim.SetBool("Dead", true);
            healthBar.gameObject.SetActive(false);

        }
        anim.SetBool("AttackLEft1", false);
        anim.SetBool("AttackRight1", false);
        anim.SetBool("AttackLEft2", false);
        anim.SetBool("AttackRight2", false);

        //anim.SetFloat("Horizontal", movment.normalized.x);
        //anim.SetFloat("Vertical", movment.y);

        CheckDistance();
        float distance = Vector3.Distance(_target.transform.position, transform.position);

        InvokeRepeating("Attack2", 20, 2);
        //InvokeRepeating("Attack", 30, 2);
        //InvokeRepeating("Attack2", 40, 2);
        //InvokeRepeating("Attack", 20, 1);
        anim.SetBool("isMoving", true);
        if (distance < 4f && _playerTarget.playerHealtShystem.GetHealth() >= 1)


        {
            //playerTarget.playerHealtShystem.Damage(2f);



            anim.SetBool("isMoving", false);
            anim.SetBool("RunLeft", false);
            anim.SetBool("RunRight", false);


            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {

                //StartCoroutine(DmgSpawn());
                Attack(minoFullAttack);

                
                //Tount();


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
            //anim.SetBool("isMoving", true);


            if (movment.x < playermovment.x)
            {
                anim.SetBool("RunLeft", false);
                anim.SetBool("RunRight", true);
                anim.SetBool("Playerontheleft", false);


            }
            else
            {
                anim.SetBool("RunRight", false);
                anim.SetBool("RunLeft", true);

                anim.SetBool("Playerontheleft", true);





            }
            // anim.SetBool("isMoving", false);



        }
    }

    public void Attack(float damage)
    {
        anim.SetBool("AttackLEft2", false);
        anim.SetBool("AttackRight2", false);
        if (movment.x < playermovment.x)
        {
            anim.SetBool("AttackLEft1", false);

            anim.SetBool("AttackRight1", true);



        }
        else
        {
            anim.SetBool("AttackRight1", false);
            anim.SetBool("AttackLEft1", true);

            






        }

        randomBonusHit = (float)Random.Range(1, 5);
        minoFullAttack = baseAtack + randomBonusHit;

        _playerTarget.playerHealtShystem.Damage(damage);







    }
    void Attack2()
    {

        anim.SetBool("AttackLEft1", false);
        anim.SetBool("AttackRight1", false);

        if (movment.x < playermovment.x)
        {
            anim.SetBool("AttackLEft2", false);

            anim.SetBool("AttackRight2", true);



        }
        else
        {
            anim.SetBool("AttackRight2", false);
            anim.SetBool("AttackLEft2", true);







        }

        randomBonusHit = (float)Random.Range(1, 5);
        minoFullAttack = baseAtack + randomBonusHit;



        InvokeRepeating("DamageOverTimeAttack", 20, 10);




    }





    public void Tount()
    {
        anim.SetBool("IsCharging", true);
        if (movment.x < playermovment.x)
        {
            //left
            anim.SetBool("ChargeLeft", true);
        }
        else
        {
            anim.SetBool("ChargeRight", true);
        }

    }
    public void DamageOverTimeAttack()
    {
        float distanceVar = Vector3.Distance(_target.transform.position, transform.position);
        if (distanceVar <= 4f && _playerTarget.playerHealtShystem.GetHealth() >= 1)
        {
            _playerTarget.playerHealtShystem.Damage(2);

        }
    }

    void OnMouseDown()
    {

        if (anim.GetBool("IsTargeted") == false)
        {
            anim.SetBool("IsTargeted", true);
        }
        else
        {
            anim.SetBool("IsTargeted", false);
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
      
        switch (col.tag)
        {
            case ( "Bullet"):
                minoHealtShystem.Damage(50f);
                break;
            case ("Bullet(Clone)"):
                minoHealtShystem.Damage(50f);
                break;
            case ("Magic"):
                minoHealtShystem.Damage(80f);
               
                Destroy(col.gameObject,1);
                break;
        }



    }
 

}



