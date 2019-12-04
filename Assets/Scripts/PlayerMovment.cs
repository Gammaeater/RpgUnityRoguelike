//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerMovment : MonoBehaviour
//{
//    public float speed;
   
//    private Vector3 change;
    
//    void Start()
//    {
//        myRigidbody = GetComponent<Rigidbody2D>();
        
//    }

    
//    void Update()
//    {
//        change = Vector3.zero;
//        change.x = Input.GetAxisRaw("Horizontal");
//        change.y = Input.GetAxisRaw("Vertical");
//        if (change != Vector3.zero)
//        {
//            MoveCharacter();
//        }
        
        
        
//    }
//    void MoveCharacter()
//    {
//        myRigidbody.MovePosition(
//            transform.position + change * speed * Time.deltaTime);
//    }
//}
