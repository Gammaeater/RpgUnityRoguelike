using UnityEngine;

public class NpcPatrolWalking : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    public Vector2 movment;
    public Animator saraAnim;
    public Rigidbody2D myRbBody;
    public bool isWalking;
    public bool hasWalkZone;
    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int WalkDirection;

    public Collider2D walkZone;

    // Start is called before the first frame update
    void Start()
    {
        myRbBody = GetComponent<Rigidbody2D>();

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

        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
        saraAnim.SetFloat("Horizontal", movment.x);
        saraAnim.SetFloat("Vertical", movment.y);


        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (WalkDirection)
            {
                case 0:
                    myRbBody.velocity = new Vector2(0, moveSpeed);
                    if(hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        
                        isWalking = false;
                        waitCounter = waitTime;
                        
                    }
                    break;
                case 1:
                    myRbBody.velocity = new Vector2(moveSpeed, 0);
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 2:
                    myRbBody.velocity = new Vector2(0, -moveSpeed);
                    if (hasWalkZone && transform.position.y < minWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                case 3:
                    myRbBody.velocity = new Vector2(-moveSpeed, 0);
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

            }

        }
        saraAnim.SetFloat("Horizontal", myRbBody.transform.position.x);
        saraAnim.SetFloat("Vertical", myRbBody.transform.position.y);
    }
    public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
