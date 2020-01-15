using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelHandler : MonoBehaviour
{
    // Start is called before the first frame update
  void Start()
    {
        LevelSystem levelSystem = new LevelSystem();
        Debug.Log(levelSystem.GetLevelNumber());
        levelSystem.AddExperience(60);
        Debug.Log(levelSystem.GetLevelNumber());
        levelSystem.AddExperience(80);
        Debug.Log(levelSystem.GetLevelNumber());
    }
}
