using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullerColisionExplo : MonoBehaviour
{

    public GameObject hiteEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hiteEffect, transform.position, Quaternion.identity) as GameObject;
       Destroy(effect,2f);
      Destroy(gameObject);
    }
    void Update()
    {
        if (gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject, 2);
        }
    }

}
