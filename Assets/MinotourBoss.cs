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

        

        //anim.SetFloat("Horizontal", movment.normalized.x);
        //anim.SetFloat("Vertical", movment.y);

        CheckDistance();
        float distance = Vector3.Distance(_target.transform.position, transform.position);



        if (distance < 10.5f)


        {
            Debug.Log("Distane checkinnnnnnnnnnnnnnnnnnnnnnng");

           //anim.SetBool("isMoving", false);

            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {

                //StartCoroutine(DmgSpawn());
                Attack(2f);
                Debug.Log("Its works?");
                //Tount();


                timeSinceLastShot = Time.time;




            }











        }
        else
        {
            anim.SetBool("isMoving", true);
        }






    }

    public void CheckDistance()

    {


        if (Vector2.Distance(_target.position, transform.position) <= chaseRaidus
            && Vector2.Distance(_target.position, transform.position) > attackRadius)
        {

            transform.position = Vector2.MoveTowards(transform.position, _target.position, moveSpeed * Time.deltaTime);
            anim.SetBool("isMoving", true);


            if (movment.x < playermovment.x)
            {
                anim.SetBool("RunLeft", false);
                anim.SetBool("RunRight", true);


            }
            else
            {
                anim.SetBool("RunRight", false);
                anim.SetBool("RunLeft", true);






            }
           // anim.SetBool("isMoving", false);



        }
    }

    public void Attack(float damage)
    {

        //randomBonusHit = (float)Random.Range(1, 5);
        // batfullAttack = baseAtack + randomBonusHit;

        //_playerTarget.playerHealtShystem.Damage(damage);







    }


    public void Attack2(float damage)
    {

        //randomBonusHit = (float)Random.Range(1, 5);
        // batfullAttack = baseAtack + randomBonusHit;

        // _playerTarget.playerHealtShystem.Damage(damage);







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
    public void CheckHoritontalPOosition()
    {
        if (movment.x < playermovment.x)
        {
            anim.SetBool("isMoving", true);
            anim.SetBool("RunLeft", false);
            anim.SetBool("RunRight", true);


        }
        else
        {
            anim.SetBool("RunRight", false);
            anim.SetBool("RunLeft", true);


        }
    }
}



