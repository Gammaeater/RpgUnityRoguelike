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
        Debug.Log("Ty kurwo swietojanksjn djobsihbihdsbavughadsvugasvygascvyfg");
    }

    // Update is called once per frame
    void Update()
    {


    }
    //void OnTriggerStay2D(Collider2D _other)
    //{
    //    print("siemanko onenisnkjfnjdfhfkdl keleflelele");
    //    if (_other.gameObject.tag == "PlayerII")
    //    {
    //        print("Działa jest gameObject tag == player");

    //        if (Input.GetKeyDown(KeyCode.Space))
    //        {
    //            if (!dMan.dialogActive)
    //            {
    //                dMan.ShowBox(dialog);
    //                Debug.Log("Dziaaaaaaaaaaaaaaaaaaalaaaaaaaaaaaaaaaaaaaaaa czy niew ?");
    //            }
    //        }
    //    }

    //}
    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.tag == "PlayerII")
    //    {

    //        print("Trafilem Trafilem Trafilem");
    //        Destroy(col.gameObject);




    //    }



    //}
}
