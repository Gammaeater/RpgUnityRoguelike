using UnityEngine;

public class NpcPatrolWalking : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    public Vector2 movment;
    public Vector2 walkinNpcrotation;
    public Animator saraAnim;
    public Rigidbody2D myRbBody;
    public bool isWalking;
    public bool hasWalkZone;
    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;
    private float axisChangeTime;
    private bool verticalGoesFirst;

    private int WalkDirection;

    public Collider2D walkZone;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

        myRbBody = GetComponent<Rigidbody2D>();
        saraAnim = GetComponent<Animator>();
        waitCounter = waitTime;
        walkCounter = walkTime;



        ChooseDirection();

        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }

    }

    // Update is called once per frame
    void Update()
    {

        
        movment.x = myRbBody.transform.position.x;
        movment.y = myRbBody.transform.position.y;
        //moveDirection = new Vector3(0, Random.Range(-1f, 1f) * moveSpeed, 0f);
        //moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);

        if (isWalking)
        {
            saraAnim.SetBool("isMoving", true);

            walkCounter -= Time.deltaTime;
            axisChangeTime -= Time.deltaTime;



            switch (WalkDirection)
            {


                case 0:
                    myRbBody.velocity = new Vector2(0, movment.y);

                    saraAnim.SetFloat("Vertical", movment.y);
                    if (hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {

                        isWalking = false;
                        waitCounter = waitTime;

                    }
                    break;
                case 1:
                    myRbBody.velocity = new Vector2(movment.x, 0);
                    //myRbBody.velocity = moveDirection;
                    saraAnim.SetFloat("Horizontal", transform.position.normalized.x);
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 2:
                    myRbBody.velocity = new Vector2(0, -movment.y);
                    saraAnim.SetFloat("Vertical", transform.position.normalized.y);
                    // myRbBody.velocity = moveDirection;
                    if (hasWalkZone && transform.position.y < minWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 3:
                    myRbBody.velocity = new Vector2(-movment.x, 0);
                    //myRbBody.velocity = moveDirection;
                    saraAnim.SetFloat("Horizontal", transform.position.normalized.x);
                    if (hasWalkZone && transform.position.x < minWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;

            }
            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }


        }
        else
        {
            waitCounter -= Time.deltaTime;


            myRbBody.velocity = Vector2.zero;
            if (waitCounter < 0)
            {
                ChooseDirection();
                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }

        }

    }
    public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
