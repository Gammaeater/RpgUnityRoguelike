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

 
}
