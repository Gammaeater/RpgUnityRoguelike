using UnityEngine;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{

    [SerializeField] public Text healtText;
    [SerializeField] private Text expirence;
    [SerializeField] private Text level;
    public HealthSystem playerHealtShystem;
    public LevelSystem playerlevelSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
        UpdateExpirience(); 
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


}