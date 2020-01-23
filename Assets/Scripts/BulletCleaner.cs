using UnityEngine;

public class BulletCleaner : MonoBehaviour
{
    private Bat _playertarget;

    void Start()
    {
       // _playertarget = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
    }

    void Update()


    {
       

        if (gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject, 2f);
        }
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    //Destroy(gameObject);
    //    Debug.Log("Ide Do hajaaaa eeeeee kurwa ide do hajaaaaaaaaaaa!");
    //}
}
