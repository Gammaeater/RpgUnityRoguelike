using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSara : MonoBehaviour
{

    public string name;
    public Rigidbody2D npcRBody;
    public Animator npcAnim;
    public NpcSara Npc;


    // Start is called before the first frame update
    void Start()
    {
        npcRBody = GetComponent<Rigidbody2D>();
        npcAnim = GetComponent<Animator>();
        Npc = GameObject.FindWithTag("NPC").GetComponent("NpcSara") as NpcSara;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
