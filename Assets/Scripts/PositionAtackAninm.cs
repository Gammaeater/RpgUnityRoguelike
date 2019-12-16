using UnityEngine;

public class PositionAtackAninm : MonoBehaviour


{
    public Transform currentPosition;
    public PlayerIIMovment playerPosition;
    public float speed = 10.0f;



    // Start is called before the first frame update
    void Start()
    {
        playerPosition = gameObject.GetComponent("PlayerIIMovment") as PlayerIIMovment;

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        //currentPosition.transform.position = Vector2.MoveTowards(currentPosition,playerPosition.transform.position,step );



        //playerPosition.transform.position;

    }
}
