using UnityEngine;
using UnityEngine.UI;


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
    public Rigidbody2D rb;
    public Animator animator;
    public bool attak;
    public HealthSystem playerHealtShystem;
    public Bat enemyAttack;
    public float actualHP;
    [SerializeField] private Text healtText;
   



    //_playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;






    // Update is called once per frame
    void Update()
    {
        //Input
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");


        animator.SetFloat("Horizontal", movment.x);
        animator.SetFloat("Vertical", movment.y);
        animator.SetFloat("Speed", movment.sqrMagnitude);




        if (Input.GetKey(KeyCode.Mouse0))
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



        //movment
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);
        UpdateHealth();










    }
    public void UpdateHealth()
    {
        healtText.text = playerHealtShystem.GetHealth().ToString("0.0");

    }
  




}

