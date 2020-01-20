using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitiontoResumMenu : MonoBehaviour
{
    [SerializeField]
    public static bool GameIsPaused2 = false;
    [SerializeField]
    public GameObject canva;
    [SerializeField]
    public GameObject pauseMenuUII;
    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        canva = GameObject.Find("ReseumeME");

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameIsPaused)

            {
                SceneManager.LoadScene("ResumeMe");


                Time.timeScale = 0f;
                GameIsPaused = true;

            }
            else
            {
                SceneManager.LoadScene("Level1");
                Time.timeScale = 1f;
                GameIsPaused = false;

            }

            
        }
    }



    public void StartResumeMenu()
    {
        SceneManager.LoadScene("ResumeMe");
        Time.timeScale = 0f;
        GameIsPaused2 = true;

    }
    public void ClosetResumeMenu()
    {
        SceneManager.LoadScene("Level1");
        GameIsPaused2 = false;

    }
}