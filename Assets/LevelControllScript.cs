using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControllScript : MonoBehaviour
{
    public int index;
    public string LevelName;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col2)
    {
        if (col2.tag == "PlayerII")
        {
            SceneManager.LoadScene(LevelName);
            Debug.Log("debug  dzialanie colidera?");
        }
    }
}
