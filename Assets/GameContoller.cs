using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{

    [SerializeField] private Text healtText;
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
    }


    public void UpdateHealth()
    {

        healtText.text = playerHealtShystem.GetHealth().ToString("0.0");


               


    }
}
