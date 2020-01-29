using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TeddyBearQuestItem : MonoBehaviour
{
    public Text questreq;
    public Text finished;
    public LevelSystem playerref;
    public GameObject SkeletonGuardLev3;



    // Start is called before the first frame update
    void Start()
    {
        playerref = GameObject.FindWithTag("PlayerII2lev").GetComponent<LevelSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D _other)
    {

        if (_other.gameObject.tag == "PlayerII2lev")
        {
            gameObject.SetActive(false);
            questreq.text = "Odnaleziony Miś : 1";
            finished.text = "Quest Complete";
            finished.color = Color.green;

            SkeletonGuardLev3.SetActive(false);

           


        }
    }
}
