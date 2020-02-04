using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Transform ray;
   // public RaycastHit hit;
    [SerializeField]
    public PlayerAttackmele player;
    public Bat _enemy;
    public MinotourBoss bossMino;
    // Start is called before the first frame update

    void Start()
    {
        //_enemy  = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;

    }
    void Update()
    {
        ClickTarget();

    }
    private void ClickTarget()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, 1024);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "Bat")
                {
                    player.MyTarget = hit.transform;
                    _enemy._anim.SetBool("isTargeted", true);

                    Debug.Log("Hit a bat !!");

                    _enemy.isTargeted = true;

                }
               

               
            }
            else
            {
                //untarged
                player.MyTarget = null;
                _enemy._anim.SetBool("isTargeted", false);
                _enemy.isTargeted = false;
            }
        }

    }
}



