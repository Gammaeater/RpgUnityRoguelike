using TMPro;
using UnityEngine;

public class DamagePopUpScript : MonoBehaviour
{

    public TextMeshPro textMesh;
    public Transform _myPosition;
    public PlayerIIMovment _target;
    private Color _textColor;
    public float disappearTimer;
    public PlayerAttackmele __target;
    public float distanceBtn;
    public Bat _batTarget;
    // Start is called before the first frame update
    private void Awake()
    {
        _target = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;
        __target = GameObject.FindWithTag("PlayerII").GetComponent("PlayerAttackmele") as PlayerAttackmele;
        _batTarget = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveNumbersSpeed = 1f;




        distanceBtn = Vector3.Distance(_target.transform.position, _batTarget.transform.position);

        if (distanceBtn < 1.5f)
        {
            _myPosition.position += new Vector3(0f, moveNumbersSpeed) * Time.deltaTime;
            SetupEnemy(__target._playerFullAttack, false);
            




            if (gameObject.name == "DamagePopUpEnemy(Clone)")
            {
                Destroy(gameObject, 2);
            }





        }


    }





    public void SetupEnemy(float damageAmount, bool isCriticalHit)
    {
        textMesh.SetText(damageAmount.ToString());
        if (!isCriticalHit)
        {
            textMesh.fontSize = 36;
            _textColor = Color.white;
        }
        else
        {
            textMesh.fontSize = 25;
            _textColor = Color.red;
        }
        textMesh.color = _textColor;
        disappearTimer = 1f;
    }




}


