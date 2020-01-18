using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int level;
    public int experience;
    public int experienceToNextLevel;
    public int experMultiplier;

    // Update is called once per frame
    public LevelSystem()
    {
        level = 1;
        experience = 0;
        experienceToNextLevel = 100;

    }
    public void AddExperience(int amount)
    {
        experience += amount;
        if (experience >= experienceToNextLevel)
        {
            level++;
            experience -= experienceToNextLevel;
            if (level > 1)
            {
                experienceToNextLevel += experienceToNextLevel / 3;
                //experienceToNextLevel = (50 * (level - 1) ^ 2 - 150 * (level - 1) + 400 * (level - 1) / 3);


            }
        }

    }
    public int GetLevelNumber()
    {
        return level;

    }
    public int GetExpirience()
    {
        return experience;
    }
}
