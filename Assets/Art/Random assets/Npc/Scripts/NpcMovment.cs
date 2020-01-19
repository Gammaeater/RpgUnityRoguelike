using UnityEngine;

public class NpcMovment : MonoBehaviour
{
    public Animator anim;
    public PlayerIIMovment playerTarget;
    [SerializeField]
    public NpcSara myContoller;
    public Transform moveSpot;
    public Rigidbody2D myRbBodyNpc;
    public Transform myPosTransform;
    public Transform myMovePointTransform;
    public GameObject questLog;
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
        myContoller = GameObject.FindWithTag("Npc").GetComponent<NpcSara>();
        myMovePointTransform = GameObject.FindWithTag("MoveSpotPoint").transform;
        canMove = true;
       // GameObject questLog = GameObject.FindWithTag("QuestLog").gameObject;
        

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
        
        if (_other.gameObject.tag == "PlayerII")
        {
            busy = true;
            questLog.SetActive(true);
            
            anim.SetBool("isMoving", false);


        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        questLog.SetActive(false);
        anim.SetBool("isMoving", true);
        busy = false;
    }
}

