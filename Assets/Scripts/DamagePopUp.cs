using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class DamagePopUp : MonoBehaviour
{
    public TextMeshPro textMesh;
    public PlayerIIMovment __playerTarget;
    public Bat __Bat;

    private float maxHealth;
    public float disappearTimer;
    private Color textColor;
    public EnemyController enemy;
    public bool criticalAttackChance;
    public float enemyDistance;
    [SerializeField] public Transform dmgprefab;
    public float smoothingPopUp;
    public float _AcutalPlayerHealth;











    private void Awake()

    {
        __playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
        __Bat = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
        enemy = GameObject.FindWithTag("PlayerII").GetComponent("EnemyController") as EnemyController;
        textMesh = transform.GetComponent<TextMeshPro>();
        maxHealth = 100f;




    }





    public void Setup(float damageAmount, bool isCriticalHit)
    {
        textMesh.SetText(damageAmount.ToString());
        if (!isCriticalHit)
        {
            textMesh.fontSize = 30;
            textColor = Color.white;
        }
        else
        {
            textMesh.fontSize = 25;
            textColor = Color.red;
        }
        textMesh.color = textColor;
        disappearTimer = 1f;
    }

    void FixedUpdate()
    {
        
        float moveYSpeed = 1f;

        enemyDistance = Vector3.Distance(__Bat.transform.position, __playerTarget.transform.position);


        _AcutalPlayerHealth = __playerTarget.playerHealtShystem.GetHealth();
        string aCTualHelath = _AcutalPlayerHealth.ToString();



        if (enemyDistance < 1.5f)
        {
            transform.position += new Vector3(0f, moveYSpeed) * Time.deltaTime;

            Setup(__Bat.batfullAttack, true);


            




            disappearTimer -= Time.deltaTime;
            if (disappearTimer < 0)

            {


                float disappearSpeed = 1f;

                textColor.a -= disappearSpeed * Time.deltaTime;
                textMesh.color = textColor;
                if (textColor.a < 0)
                {
                    Destroy(gameObject);


                }
            }


        }

    }










}
