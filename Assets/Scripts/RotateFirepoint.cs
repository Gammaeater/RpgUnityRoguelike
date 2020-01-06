
using UnityEngine;

public class RotateFirepoint : MonoBehaviour
{
    Vector2 lookDirection;
    private float lookAngle;
    public Bat enemy;
    public float speed = 5f;
    public Transform target;


    public void Start()
    {
        enemy = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
        target = enemy.transform;
    }
    public void Update()
    {
   

        FirePRotate();
              

        ////Mause position - our actuall position
        //lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //// lookDirection = target.transform.position;
        //// Atan2 calculation + eluer x y z
        //lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        ////transform.rotation = enemy.transform.rotation;
        //Debug.Log("Sarrra Ciiicho");








    }
    public void RotateToEnemy(Vector2 target)
    {
        float offset = 90f;

        Vector2 direction = target - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));

        

    }


    public void FirePRotate()
    {
        transform.LookAt(enemy.transform.position);
    }
}
