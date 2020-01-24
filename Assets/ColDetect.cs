using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D _other)
    {

        if (_other.gameObject.tag == "PlayerII2lev")
        {

            Debug.Log("It Collision detected?");
                

        }
    }
}
