using UnityEngine;

public class NpcMovment : MonoBehaviour
{
    public Animator anim;
    public PlayerIIMovment playerTarget;
    public NpcSara myContoller;
    public Transform moveSpot;
    public Rigidbody2D myRbBodyNpc;
    public Transform myPosTransform;
    public Transform myMovePointTransform;
    public string dialog;
    public DialogManager dMan;
    public float patrolSpeed;
    private float patrolWaitTime;
    public float patrolStartWaitTime;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public bool isPlayer;
    public bool busy;
    public bool canMove;
    // Start is called before the first frame update
    void Awake()
    {
        busy = false;

        patrolWaitTime = patrolStartWaitTime;
        moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));

        myMovePointTransform = GameObject.FindWithTag("MoveSpotPoint").transform;
        canMove = true;

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Vertical", myMovePointTransform.position.normalized.y);
        anim.SetFloat("Horizontal", myMovePointTransform.position.normalized.x);

        if (busy == false)
        {
            anim.SetBool("isMoving", true);
            transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, patrolSpeed * Time.deltaTime);

            if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
            {

                if (patrolWaitTime <= 0)
                {
                    moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));


                    patrolWaitTime = patrolStartWaitTime;
                    anim.SetBool("isMoving", false);
                }
                else
                {
                    patrolWaitTime -= Time.deltaTime;
                    anim.SetBool("isMoving", false);
                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, moveSpot.transform.position, patrolSpeed * Time.deltaTime);
            }
        }
        else
        {
            myRbBodyNpc.velocity = Vector2.zero;
            return;
        }

    }

    void OnTriggerStay2D(Collider2D _other)
    {
        print("siemanko onenisnkjfnjdfhfkdl keleflelele");
        if (_other.gameObject.tag == "PlayerII")
        {
            

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    if (!dMan.dialogActive)
            //    {
            //        dMan.ShowBox(dialog);
            //        Debug.Log("Dziaaaaaaaaaaaaaaaaaaalaaaaaaaaaaaaaaaaaaaaaa czy niew ?");
            //    }
            //}
        }
    }
}

