using UnityEngine;

public class PlayerIIMovment : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float dasH = 20f;

    public Rigidbody2D rb;
    public Animator animator;
    public bool attak;
    //float dashDistance = 100f;


    RotateFirepoint rfDirection;
    Vector2 movment;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        //Input
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");


        animator.SetFloat("Horizontal", movment.x);
        animator.SetFloat("Vertical", movment.y);
        animator.SetFloat("Speed", movment.sqrMagnitude);




        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("attacking", true);

            attak = true;

        }
        else
        {
            if (attak)
            {
                animator.SetBool("attacking", false);

                attak = false;

            }
        }
        if ((Input.GetKeyDown(KeyCode.LeftAlt)))
        {



        }




    }

    void FixedUpdate()
    {



        //movment
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);







    }




}

