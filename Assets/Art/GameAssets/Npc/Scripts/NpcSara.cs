using UnityEngine;

public class NpcSara : MonoBehaviour
{

    
    public Rigidbody2D npcRBody;
    public Animator npcAnim;
    public NpcSara Npc;
    public string Npcdialog;
    public DialogManager NpcdMan;


    // Start is called before the first frame update
    void Start()
    {
        //NpcdMan = FindObjectOfType<DialogManager>();
        npcRBody = GetComponent<Rigidbody2D>();
        npcAnim = GetComponent<Animator>();
        Npc = GameObject.FindWithTag("Npc").GetComponent("NpcSara") as NpcSara;


    }

    // Update is called once per frame
    void Update()
    {

    }

}
