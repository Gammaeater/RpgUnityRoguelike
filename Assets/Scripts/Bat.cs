using System.Collections;
using UnityEngine;


public class Bat : EnemyController
{
    public Rigidbody2D _myRigidBody;
    public Transform _target;
    public float _chaseRaidus;
    public float _attackRadius;
    public Transform _homePosition;
    public Animator _anim;
    public PlayerIIMovment _playerTarget;
    public Bat _myContoller;
    public GameObject Player;
    public float TimeBetweenShots;
    private float timeSinceLastShot;
    private float timeSpawnDeley;
    public Bat ownBat;
    public float actualHealth;
    public Transform rAndomPatrol;
    public Vector3 positionRandom;
    public EnemyPatrol is_Player;
    public GameObject popUpprefab;
    public float randomBonusHit;
    public float batfullAttack;
    public bool isTargeted;




    void Start()
    {






        Debug.Log("wezto rozkmin smieciu");
        currentState = EnemyState.idle;
        _myRigidBody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("PlayerII").transform;




        _playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
        _myContoller = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;



        actualHealth = ownBat.enemyHealtSystem.GetHealth();







    }





    void FixedUpdate()
    {


        CheckDistance();
        StartCoroutine(UpdateHpAnim());




        float distance = Vector3.Distance(_target.transform.position, transform.position);



        if (distance < 1.5f && _playerTarget.playerHealtShystem.GetHealth() >= 1)


        {



            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {

                StartCoroutine(DmgSpawn());
                Attack(batfullAttack);












                Debug.Log("Chuj wie co sie dziejdcccce");

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
            Debug.Log("Tu szukam playera");







        }




    }










    public void Attack(float damage)
    {

        randomBonusHit = (float)Random.Range(1, 5);
        batfullAttack = baseAtack + randomBonusHit;

        _playerTarget.playerHealtShystem.Damage(damage);
        Debug.Log("Zycie Gracza  atak Bata  " + _playerTarget.playerHealtShystem.GetHealth());






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
            enemyHealtSystem.Damage(5f);
            print("Trafilem Trafilem Trafilem");




        }



    }
}