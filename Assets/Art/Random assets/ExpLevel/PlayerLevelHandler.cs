using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelHandler : MonoBehaviour
{
    public bool loopcontrol;
    public Bat batController;
    public LevelSystem playerLevelSytem;
  // Start is called before the first frame update
  void Start()
    {

        loopcontrol = true;

        batController = GameObject.FindWithTag("Bat").GetComponent("Bat") as Bat;
        playerLevelSytem = GameObject.FindWithTag("PlayerII").GetComponent("LevelSystem") as LevelSystem;
    }
    

    void FixedUpdate()
    {
        if (batController.enemyHealtSystem.GetHealth() <= 1 && loopcontrol == true)
        {
            playerLevelSytem.AddExperience(batController.expAmount);
            loopcontrol = false;
        }
    }
}
