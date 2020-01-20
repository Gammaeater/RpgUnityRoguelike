using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Awake()
    {
        //Time.timeScale = 0f;
    }
    // Start is called before the first frame update
  public void PlayGame ()
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
