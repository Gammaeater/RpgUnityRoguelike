using System.Collections;
using UnityEngine;


public class Bat : EnemyController
{

    public Transform _target;
    public float _chaseRaidus;
    public float _attackRadius;
    public Transform _homePosition;
    public Animator _anim;
    public PlayerIIMovment _playerTarget;


    public float TimeBetweenShots;
    private float timeSinceLastShot;
    public Bat ownBat;
    public float actualHealth;
    public Transform rAndomPatrol;

 
    public GameObject popUpprefab;
    public float randomBonusHit;
    public float batfullAttack;
    public bool isTargeted;
    public int expAmount;




    void Start()
    {






        expAmount = 50;


        _anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("PlayerII").transform;




        _playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;




        actualHealth = ownBat.enemyHealtSystem.GetHealth();

        expAmount = 50;






    }





    void FixedUpdate()
    {


        CheckDistance();
        //StartCoroutine(UpdateHpAnim());



        float distance = Vector3.Distance(_target.transform.position, transform.position);



        if (distance < 2.5f && _playerTarget.playerHealtShystem.GetHealth() >= 1)


        {



            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {

                //StartCoroutine(DmgSpawn());
                Attack(batfullAttack);
                
                


                timeSinceLastShot = Time.time;



            }











        }








    }
    public void CheckDistance()

    {


        if (Vector2.Distance(_target.position, transform.position) <= _chaseRaidus
            && Vector2.Distance(_target.position, transform.position) > _attackRadius)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, moveSpeed * Time.deltaTime);
            






        }




    }










    public void Attack(float damage)
    {

        randomBonusHit = (float)Random.Range(1, 5);
        batfullAttack = baseAtack + randomBonusHit;

        _playerTarget.playerHealtShystem.Damage(damage);







    }
    IEnumerator UpdateHpAnim()
    {
        _anim.SetFloat("hp", enemyHealtSystem.GetHealth());
        yield return new WaitForSeconds(1);

    }


    IEnumerator DmgSpawn()
    {

        yield return new WaitForSeconds(4);
        GameObject FloatHp = Instantiate(popUpprefab, transform.position, transform.rotation);


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet" || col.name == "Bullet(Clone)")
        {
            enemyHealtSystem.Damage(10f);
            print("Trafilem Trafilem Trafilem");
            Destroy(col.gameObject);




        }



    }

}