
using UnityEngine;

public class RotateFirepoint : MonoBehaviour
{
    Vector2 lookDirection;
    private float lookAngle;

    public float speed = 5f;
    public Transform arrget;
    private void Update()
    {

        //Mause position - our actuall position
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        // Atan2 calculation + eluer x y z
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);
            
    }
}
