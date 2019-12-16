using System;
using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;



public class DamagePopUp : MonoBehaviour
{
    public TextMeshPro textMesh;
    public Transform _position;
    public PlayerIIMovment __playerTarget;
    public Bat __Bat;
    public float actualHealth;
    public float damageAmount;
    private float maxHealth;
    public float disappearTimer;
    private Color textColor;

    [SerializeField] public Transform dmgprefab;



    //Create PopUpDMg
    public static DamagePopUp Create(Vector3 position, float damageAmount, bool isCriticalHit)
    {
        Transform damagePopTransform = Instantiate(GameAsstets.i.DamagePopUp, Vector3.zero, Quaternion.identity);
        DamagePopUp damagePopup = damagePopTransform.GetComponent<DamagePopUp>();

        return damagePopup;
    }






    private void Awake()

    {
        __playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
        __Bat = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
        textMesh = transform.GetComponent<TextMeshPro>();
        maxHealth = 100f;


    }





    public void Setup(float damageAmount,bool isCriticalHit)
    {
        textMesh.SetText(damageAmount.ToString());
       if (!isCriticalHit)
        {
            textMesh.fontSize = 36;
            textColor = Color.white;
        }
        else
        {
            textMesh.fontSize = 45;
            textColor = Color.red;
        }
        textMesh.color = textColor;
        disappearTimer = 1f;
    }

    void Update()
    {
        float moveYSpeed = 1f;
        actualHealth = __playerTarget.playerHealtShystem.GetHealth();

        Setup(2.5f , true);



        transform.position += new Vector3(0f, moveYSpeed) * Time.deltaTime;

        disappearTimer -= Time.deltaTime;
        if (disappearTimer < 0)
        //start Disappear
        {
            float disappearSpeed = 3f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            textMesh.color = textColor;
            if(textColor.a  < 0)
            {
                Destroy(gameObject);

            }
        }
    }

    public static implicit operator float(DamagePopUp v)
    {
        throw new NotImplementedException();
    }



    // Update is called once per frame

}
