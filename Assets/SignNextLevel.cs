using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignNextLevel : MonoBehaviour
{
    public GameObject textLevel;
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

            textLevel.SetActive(true);

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        textLevel.SetActive(false);
    }
}
