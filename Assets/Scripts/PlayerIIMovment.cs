using UnityEngine;


public enum PlayerState
{
    walk,
    attack,
    interact
}

public class PlayerIIMovment : MonoBehaviour
{
    public PlayerState currentState;
    public float moveSpeed = 5f;

    public float dasH = 20f;
    public Vector2 movment;
    public Vector2 mausePosition;
    public Rigidbody2D rb;
    public Animator animator;
    public bool attak;
    public Bat enemyAttack;
    public float actualHP;

    public HealthSystem playerHealtShystem;
    private Transform selectedUnit;
    private Bat enemy;
  
    void Start()
    {
        enemy = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;

    }





    // Update is called once per frame
    void Update()
    {
        //Input
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");




        animator.SetFloat("Horizontal", movment.x);
        animator.SetFloat("Vertical", movment.y);
        animator.SetFloat("Speed", movment.sqrMagnitude);




        if (Input.GetKey(KeyCode.Mouse1))
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

     





    }

    void FixedUpdate()
    {




        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);
        //TargetEnemy();
        











        }

    void TargetEnemy()
    {


        enemy._anim.SetBool("isTargeted", true);
        Debug.Log("Jeeeeeeeeeeeeebbbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaaaaaaacccccccccccc poooooooooooliiiiiiiicje");


    }






}




