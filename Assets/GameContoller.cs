using UnityEngine;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{

    [SerializeField] public Text healtText;
    [SerializeField] private Text expirence;
    [SerializeField] private Text level;
  
    public HealthSystem playerHealtShystem;
    public LevelSystem playerlevelSystem;
    public HealthSystem bathp;
    [SerializeField] public Text enemyhp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
        UpdateExpirience();
        BatUpdateHealth();


    }


    public void UpdateHealth()
    {

        healtText.text = playerHealtShystem.GetHealth().ToString("0.0");




    }


    public void UpdateExpirience()
    {
        expirence.text = playerlevelSystem.GetExpirience().ToString("0");
        level.text = playerlevelSystem.GetLevelNumber().ToString("0");

    }

    public void BatUpdateHealth()
    {

        enemyhp.text = bathp.GetHealth().ToString("0.0");





    }

}