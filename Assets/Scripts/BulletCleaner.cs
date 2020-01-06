using UnityEngine;

public class BulletCleaner : MonoBehaviour
{


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
