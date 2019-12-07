using UnityEngine;

public class PlayerAttackmele : MonoBehaviour
{
    private float timeMeleAttack;
    public float startTimeMeleAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public float damage;


    // Update is called once per frame
    void Update()
    {
        if (timeMeleAttack <= 0)
        {
            if (Input.GetKey(KeyCode.LeftAlt))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);

                }

            }
            timeMeleAttack = startTimeMeleAttack;

        }
        else
        {
            timeMeleAttack -= Time.deltaTime;
        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);

    }
}
