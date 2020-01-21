using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   

    
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");

        Time.timeScale = 1;
        
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
