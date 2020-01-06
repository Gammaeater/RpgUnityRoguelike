using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyPatrol : MonoBehaviour
{ 

    public float patrolSpeed;

    public Transform moveSpot;
    public PlayerIIMovment __playerTarget;
    public Bat __myContoller;
    public float _attackRadiusDistance;
    private float patrolWaitTime;
    public float patrolStartWaitTime;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public bool isPlayer;



    // Start is called before the first frame update
    void Start()
    {
        patrolWaitTime = patrolStartWaitTime;
        moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
        __playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
        
    }

    // Update is called once per frame
    void Update()
    {
        float Enemydistance = Vector3.Distance(__playerTarget.transform.position, transform.position);
        if (Enemydistance > 5f)
        {
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
            }

        }
        }
        else
        {
            if (Vector2.Distance(__playerTarget.transform.position, transform.position) > _attackRadiusDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, __playerTarget.transform.position, patrolSpeed * Time.deltaTime);
            }
        }
    }


     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerII")
        {
            isPlayer = true; ;

        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Twoj staryyyyyyyyyyyyyyy je załatke");
    }
}
