using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonGuard : MonoBehaviour
{
    public GameObject EnterenceText;
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
            EnterenceText.SetActive(true);

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        EnterenceText.SetActive(false);
    }
}
