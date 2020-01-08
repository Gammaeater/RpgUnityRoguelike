
using UnityEngine;

public class RotateFirepoint : MonoBehaviour
{
    Vector2 lookDirection;
    private float lookAngle;
    public Bat enemy;
    public float speed = 5f;
    public Transform target;
    public float fprotationSpeed;
    private float turnSpeed;

    public void Start()
    {
        enemy = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
        target = enemy.transform;

    }
    public void Update()
    {


        // FirePRotate();
        //RotateToEnemy(target.position);
        //transform.LookAt(enemy.transform.position);
        // transform.LookAt(2 * transform.position - enemy.transform.position);

        ////Mause position - our actuall position
        ///lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //// lookDirection = target.transform.position;
        //// Atan2 calculation + eluer x y z
        //lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        ////transform.rotation = enemy.transform.rotation;
        //Debug.Log("Sarrra Ciiicho");


        //Vector3 lookDirection = target.position - transform.position;
       // Vector3 rotatedVectorToTarget = Quaternion.Euler(0, 0, 90) * lookDirection;
        //Quaternion rotoation = Quaternion.LookRotation(lookDirection, Vector3.forward);
        //transform.rotation = rotoation;


       //w Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedVectorToTarget);

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);





    }
    public void RotateToEnemy(Vector2 target)
    {
        float offset = 90f;

        Vector2 direction = target - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
        Quaternion rotation = Quaternion.AngleAxis(angle + offset, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, fprotationSpeed * Time.deltaTime);



    }


    public void FirePRotate()
    {
        transform.LookAt(enemy.transform.position);
    }
}
