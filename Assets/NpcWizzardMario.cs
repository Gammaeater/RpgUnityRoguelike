using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWizzardMario : MonoBehaviour
{
    public GameObject SpellText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D _player)
    {

        if (_player.gameObject.tag == "PlayerII2lev")
        {
            SpellText.SetActive(true);

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        SpellText.SetActive(false);
    }
}
