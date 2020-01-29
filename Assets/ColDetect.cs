using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColDetect : MonoBehaviour
{
    public GameObject warring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D _other)
    {

        if (_other.gameObject.tag == "PlayerII")
        {

            warring.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        warring.SetActive(false);
    }
     
}
