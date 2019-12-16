using UnityEngine;


public class Bat : Enemy
{
    public Rigidbody2D _myRigidBody;
    public Transform _target;
    public float _chaseRaidus;
    public float _attackRadius;
    public Transform _homePosition;
    public Animator _anim;
    public PlayerIIMovment _playerTarget;
    public GameObject Player;
    public float TimeBetweenShots;
    private float timeSinceLastShot;
    public Bat ownBat;
    public float actualHealth;
    public float cloudAttack;
    public Animator AttackEffect;
    public FloatingNumbers FloatingNumbers;




    private float timerSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.idle;
        _myRigidBody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("PlayerII").transform;




        _playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;

        //AttackEffect = ownBat.AttackEffect.GetComponent<Animator>();


        actualHealth = ownBat.enemyHealtSystem.GetHealth();









    }





    void FixedUpdate()
    {





        CheckDistance();
        UpdateHpAnim();




        float distance = Vector3.Distance(_target.transform.position, transform.position);



        if (distance < 1.5f && _playerTarget.playerHealtShystem.GetHealth() >= 1)


        {

            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {
                //_playerTarget.animator.Play("AttackEffect", 0);

                Attack(1f);


                Debug.Log("Chuj wie co sie dziejdcccce");

                timeSinceLastShot = Time.time;


            }











        }






    }
    void CheckDistance()

    {


        if (Vector3.Distance(_target.position, transform.position) <= _chaseRaidus
            && Vector3.Distance(_target.position, transform.position) > _attackRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, moveSpeed * Time.deltaTime);
            Debug.Log("Tu szukam playera");






        }




    }






    public void Attack(float damage)
    {



        _playerTarget.playerHealtShystem.Damage(damage);
        Debug.Log("Zycie Gracza  atak Bata  " + _playerTarget.playerHealtShystem.GetHealth());





    }
    public void UpdateHpAnim()
    {
        _anim.SetFloat("hp", enemyHealtSystem.GetHealth());

    }

}