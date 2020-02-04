using UnityEngine;

public class NpcAI : MonoBehaviour
{
    public Animator Noemianim;
   
    [SerializeField]
    
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
       // myContoller = GameObject.FindWithTag("Npc").GetComponent<NpcAI>();
        myMovePointTransform = GameObject.FindWithTag("MoveSpotNoemi").transform;
        



    }

    // Update is called once per frame
    void Update()
    {
        Noemianim.SetFloat("Horizontal", transform.position.normalized.x);

        Noemianim.SetFloat("Vertical", transform.position.normalized.y);


        if (busy == false)
        {


            Noemianim.SetBool("IsMoving", true);
            transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, patrolSpeed * Time.deltaTime);
    

            if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
            {

                if (patrolWaitTime <= 0)
                {
                    moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));


            

                    patrolWaitTime = patrolStartWaitTime;
           
                }
                else
                {
                    patrolWaitTime -= Time.deltaTime;
                    Noemianim.SetBool("IsMoving", false);
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

  void OnTriggerStay2D(Collider2D _player)
  {

      if (_player.gameObject.tag == "PlayerII2lev")
      {
          busy = true;
          questLog.SetActive(true);

            Noemianim.SetBool("IsMoving", false);



      }
  }
  void OnTriggerExit2D(Collider2D other)
  {
      questLog.SetActive(false);
        Noemianim.SetBool("IsMoving", true);

        busy = false;
  }
}

