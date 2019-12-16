using UnityEngine;

public class PlayerAttackmele : MonoBehaviour
{


    public Bat _batTarget;
    public DamagePopUp _Dmg;
    public float TimeBetweenShots;
    private float timeSinceLastShot;
    public Transform position;
    float distance;
    float _damageAmount;
    [SerializeField] public Transform dmgprefab;

    void Start()
    {
        _batTarget = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;

            
        //float _damageAmount = GameObject.FindWithTag("PopUpHp").GetComponent("DamagePopUp") as DamagePopUp;




    }
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))


    //    {
    //        

    //    }
    //}

    void FixedUpdate()
    {
        //DamagePopUp.Create(_batTarget.transform.position, _Dmg.actualHealth);
        distance = Vector3.Distance(_batTarget.transform.position, transform.position);

        if (distance < 1.5f && _batTarget.enemyHealtSystem.GetHealth() >= 0)
        {
            if (Time.time > timeSinceLastShot + TimeBetweenShots)
            {

                Attack(1f);

                Debug.Log("Atack Wariata hp Bata");

                timeSinceLastShot = Time.time;

            }

        }
       
    }





    void Attack(float damage)
    {




        _batTarget.enemyHealtSystem.Damage(damage);
        Debug.Log("zycie Bata :" + _batTarget.enemyHealtSystem.GetHealth());





    }

}
