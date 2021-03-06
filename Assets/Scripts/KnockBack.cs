﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class KnockBack : MonoBehaviour

{

    public float knockPower;
    public float knockTime;

   
    
    private void OnTriggerEnter2d(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Rigidbody2D enemy = other.GetComponent<Rigidbody2D>();
                if(enemy != null)
            {
                enemy.isKinematic = false; 
                Vector2 difference = enemy.transform.position - transform.position;
                difference = difference.normalized * knockPower;
                enemy.AddForce(difference, ForceMode2D.Impulse);
                StartCoroutine(KnockCo(enemy));
                
            }
        }
    }
    private IEnumerator KnockCo(Rigidbody2D enemy)
    {
        if(enemy != null)
        {
            yield return new WaitForSeconds(knockTime);
            enemy.velocity = Vector2.zero;
            enemy.isKinematic = true;

        }
    }
}
