using UnityEngine;

public class MinotourBoss : MonoBehaviour
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
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("PlayerII").transform;


        _playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movment.x = transform.position.x;
        playermovment.x = _target.position.x;

        anim.SetBool("AttackLEft1", false);
        anim.SetBool("AttackRight1", false);
        anim.SetBool("AttackLEft2", false);
        anim.SetBool("AttackRight2", false);

        //anim.SetFloat("Horizontal", movment.normalized.x);
        //anim.SetFloat("Vertical", movment.y);

        CheckDistance();
        float distance = Vector3.Distance(_target.transform.position, transform.position);

        InvokeRepeating("Attack2", 10, 2);
        InvokeRepeating("Attack", 20, 1);
        InvokeRepeating("Attack2", 40,2);
        
        anim.SetBool("isMoving", true);
        if (distance < 4f)


        {
            Debug.Log("Distane checkinnnnnnnnnnnnnnnnnnnnnnng");


            anim.SetBool("isMoving", false);
            anim.SetBool("RunLeft", false);
            anim.SetBool("RunRight", false);


            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {
                
                //StartCoroutine(DmgSpawn());
                 Attack();

                Debug.Log("Its works?");
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

    public void Attack()
    {
        anim.SetBool("AttackLEft2", false);
        anim.SetBool("AttackRight2", false);
        if (movment.x < playermovment.x)
        {
            anim.SetBool("AttackLEft1", false);

            anim.SetBool("AttackRight1", true);
            // anim.SetBool("Playerontheleft", false);
            Debug.Log("Testing code attack right 1");


        }
        else
        {
            anim.SetBool("AttackRight1", false);
            anim.SetBool("AttackLEft1", true);

            Debug.Log("Testing code attack left 1");

            // anim.SetBool("Playerontheleft", true);





        }

        //randomBonusHit = (float)Random.Range(1, 5);
        // batfullAttack = baseAtack + randomBonusHit;

        //_playerTarget.playerHealtShystem.Damage(damage);
        _playerTarget.playerHealtShystem.Damage(15);






    }
    void  Attack2()
    {

        anim.SetBool("AttackLEft1", false);
        anim.SetBool("AttackRight1", false);

        if (movment.x < playermovment.x)
        {
            anim.SetBool("AttackLEft2", false);

            anim.SetBool("AttackRight2", true);
            // anim.SetBool("Playerontheleft", false);
            Debug.Log("Testing code attack right 1");


        }
        else
        {
            anim.SetBool("AttackRight2", false);
            anim.SetBool("AttackLEft2", true);

            Debug.Log("Testing code attack left 1");

            // anim.SetBool("Playerontheleft", true);





        }

        //randomBonusHit = (float)Random.Range(1, 5);

        _playerTarget.playerHealtShystem.Damage(15);







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

}



