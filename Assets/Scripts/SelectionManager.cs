using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Transform ray;
    public RaycastHit hit;
    [SerializeField]
    public PlayerAttackmele player;
    public Bat _enemy;
    public Bat _enemy2;
    // Start is called before the first frame update

    void Start()
    {
        _enemy  = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
        _enemy2 = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
    }
    void Update()
    {
        ClickTarget();

    }
    private void ClickTarget()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, 1024);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "Bat" )
                {
                    player.MyTarget = hit.transform;
                    _enemy._anim.SetBool("isTargeted", true);
                    _enemy.isTargeted = true;

                }
               

                Debug.Log("Działa czy nieeeeeeeeeeeeeeeeeeeeeeee?");
            }
            else
            {
                //untarget
                player.MyTarget = null;
                _enemy._anim.SetBool("isTargeted", false);
                _enemy.isTargeted = false;
            }
        }

    }
}



