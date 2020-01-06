using UnityEngine;



public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}

public class EnemyController
    : MonoBehaviour
{
    public EnemyState currentState;
    public string enemyName;
    public float baseAtack;
    public float moveSpeed;
    public PlayerIIMovment playerhealth;
    public HealthSystem enemyHealtSystem;
    public float criticalAttack;
    public float fullAttack;
    public bool criticalAttackChance;
    [SerializeField] public Transform dmgprefab;
    public float randomHit;



    void Start()
    {

        criticalAttackChance = Random.Range(0, 10) < 3;

        randomHit = Random.Range(1f, 5f);




        criticalAttack = baseAtack + (float)Random.Range(1, 5);

        fullAttack = baseAtack + randomHit;






    }











}
