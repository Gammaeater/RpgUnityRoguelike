using UnityEngine;

public class NpcMovment : MonoBehaviour
{
    public PlayerIIMovment playerTarget;
    public NpcSara myContoller;
    public Transform moveSpot;
    public float patrolSpeed;
    private float patrolWaitTime;
    public float patrolStartWaitTime;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public bool isPlayer;
    public bool busy;
    // Start is called before the first frame update
    void Start()
    {
        busy = false;

        patrolWaitTime = patrolStartWaitTime;
        moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
        playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;

    }

    // Update is called once per frame
    void Update()
    {
        if (busy == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, patrolSpeed * Time.deltaTime);

            if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
            {
                Debug.Log("Wy kurwy i grajki");
                if (patrolWaitTime <= 0)
                {
                    moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                    print("Dziala mnie to czy kurwa mac nie działa o to jest pytanie :D ");
                    patrolWaitTime = patrolStartWaitTime;
                }
                else
                {
                    patrolWaitTime -= Time.deltaTime;

                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, moveSpot.transform.position, patrolSpeed * Time.deltaTime);
            }
        }

    }
}

