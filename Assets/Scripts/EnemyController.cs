using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}

public class Enemy : MonoBehaviour
{
    public EnemyState currentState;
    public string enemyName;
    public int baseAtack;
    public float moveSpeed;
    public PlayerIIMovment playerhealth;
    public HealthSystem enemyHealtSystem;




    public void TakeDamage(float damage)
    {
      
       

    }
  
}
