using UnityEngine;

public class dialogHolder : MonoBehaviour
{
    public Rigidbody2D _NpcmyRigidBody;
    public string dialog;
    public DialogManager dMan;
    // Start is called before the first frame update
    void Start()
    {
        _NpcmyRigidBody = GetComponent<Rigidbody2D>();
        dMan = FindObjectOfType<DialogManager>();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
   
}
