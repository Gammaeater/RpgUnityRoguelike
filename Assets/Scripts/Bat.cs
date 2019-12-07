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
    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.idle;
        _myRigidBody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("PlayerII").transform;


        _playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
        Debug.Log(_playerTarget);
        



    }

    // Update is called once per frame  
    void FixedUpdate()
    {
        CheckDistance();

        















    }
    void CheckDistance()
    {
        if (Vector3.Distance(_target.position, transform.position) <= _chaseRaidus
            && Vector3.Distance(_target.position, transform.position) > _attackRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, moveSpeed * Time.deltaTime);

           if(_attackRadius == 0)
            {
                Attack(2f);
            }

        }


    }
  void Attack(float damage)
    {
        _playerTarget.playerHealtShystem.Damage(damage);
        Debug.Log(_playerTarget.playerHealtShystem.GetHealth());

       _playerTarget.playerHealtShystem.Damage(damage);
        Debug.Log(_playerTarget.playerHealtShystem.GetHealth());
    }
}
