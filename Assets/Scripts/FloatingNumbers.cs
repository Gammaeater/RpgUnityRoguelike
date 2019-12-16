using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FloatingNumbers : MonoBehaviour
{
    public float moveSpeed;
    public float damageNumber;
    public Text displayNumber;
    public PlayerIIMovment _playerTarget;
    public Bat _batTarget;
    public GameObject NumbersPrefab;
    float distance;
    public float RespTime;
    private Vector2 screenBound;
    public bool isAttacked;




    // Start is called before the first frame update


    void Start()
    {


        _playerTarget = GameObject.FindWithTag("PlayerII").GetComponent("PlayerIIMovment") as PlayerIIMovment;

        _batTarget = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;




    }



    void FixedUpdate()

    {
        damageNumber = _playerTarget.playerHealtShystem.GetHealth();


        distance = Vector3.Distance(_batTarget.transform.position, transform.position);


        //InvokeRepeating("DisplayingdmgText", 2.0f, 0.1f);
        DisplayingdmgText();



    }


    public void DisplayingdmgText()
    {

        displayNumber.text = "" + damageNumber;
        transform.position = new Vector3(transform.position.x, transform.position.y + (moveSpeed * Time.deltaTime), transform.position.z);




    }




    //public void Spwn_Hp()
    //{
    //   GameObject Numbers = Instantiate(NumbersPrefab) as GameObject;
    //    Numbers.transform.position =  new Vector2(screenBound.x * -2, Random.Range(-screenBound.y,screenBound.y));
    //}



    IEnumerator HpSpawn(float RespTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(RespTime);
            GameObject Numbers = Instantiate(NumbersPrefab, transform.position, transform.rotation);
        }

    }

}
