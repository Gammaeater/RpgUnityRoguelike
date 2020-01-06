//using TMPro;
//using UnityEngine;




//public class DamagePopUpEnemy : MonoBehaviour

//{
//    public TextMeshPro textMesh;
//    public Transform _position;
//    public PlayerIIMovment __playerTarget;
//    public Bat __Bat;
//    public float actualHealth;
//    //public float damageAmount;
//    private float maxHealth;
//    public float disappearTimer;
//    private Color textColor;
//    private VertexGradient dissapearEffect;





//    public EnemyController enemy;
//    public bool criticalAttackChance;
//    public float fullAttack;

//    [SerializeField] public Transform dmgprefab;










//    private void Awake()

//    {
//        __playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
//        __Bat = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
//        enemy = GameObject.FindWithTag("Bat").GetComponent("EnemyController") as EnemyController;
//        textMesh = transform.GetComponent<TextMeshPro>();
//        maxHealth = 100f;
//        Debug.Log("Siemanko zyjemy11?");
//        Debug.Log("Dmg Pop Up");



//    }





//    public void Setup(float damageAmount, bool isCriticalHit)
//    {
//        textMesh.SetText(damageAmount.ToString());
//        if (!isCriticalHit)
//        {
//            textMesh.fontSize = 36;
//            textColor = Color.white;
//        }
//        else
//        {
//            textMesh.fontSize = 45;
//            textColor = Color.red;
//        }
//        textMesh.color = textColor;
//        disappearTimer = 1f;
//    }

//    void Update()
//    {
//        float moveYSpeed = 1f;
//        actualHealth = 100 - __Bat.enemyHealtSystem.GetHealth();


//        float damageAmount = __playerTarget.
        
       




//        Setup(damageAmount, false);



//        transform.position += new Vector3(0f, moveYSpeed) * Time.deltaTime;
//        Debug.Log("Siemanko zyjemy?");

//        disappearTimer -= Time.deltaTime;
//        if (disappearTimer < 0)
//        //start Disappear
//        {

//            Debug.Log("Siemanko zyjemy?22");
//            float disappearSpeed = 1f;

//            textColor.a -= disappearSpeed * Time.deltaTime;
//            textMesh.color = textColor;
//            if (textColor.a < 0)
//            {
//                Destroy(gameObject);
//                Debug.Log("Siemanko zyjemyelooo?");

//            }
//        }
//    }







//}
