using System.Collections;
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
    public Transform MyTarget { get; set; }

    public HealthSystem playerHealtShystem;
    private Transform selectedUnit;
    private Bat enemy;

    void Start()
    {


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


        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
           
            Haste();

        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {

            Heal();

        }









    }

    void FixedUpdate()
    {




        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);













    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet" || col.name == "Bullet(Clone)")
        {
            Debug.Log("Shoters Controll Logg");
            playerHealtShystem.Damage(1f);





        }
    }

    void Haste()
    {
        moveSpeed += 3f;
        StartCoroutine(Movespeednormal());






        IEnumerator Movespeednormal()
        {
            yield return new WaitForSeconds(2);
            moveSpeed = 5f;


        }




    }
    void Heal()
    {
        playerHealtShystem.Heal(10f);
    }





}




