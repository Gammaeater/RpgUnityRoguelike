using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManagerBossfight : MonoBehaviour
{
    public Transform ray;
    //public RaycastHit hit;
    [SerializeField]
    
    public MinotourBoss bossMino;
    public PlayerIIMovment _playerTarget;
    // Start is called before the first frame update
    void Start()
    {
        bossMino = GameObject.FindWithTag("BossMino").GetComponent("MinotourBoss") as MinotourBoss;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ClickTarget()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, 1024);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "BossMino")
                {
                    _playerTarget.MyTarget = hit.transform;
                    bossMino.anim.SetBool("IsTargeted", true);
                    Debug.Log("Debug LogRay Cast !!!!!! Mino");



                   
                }



            }
            else
            {
                //untarged
                _playerTarget.MyTarget = null;
                bossMino.anim.SetBool("isTargeted", false);
                
            }
        }

    }
}
