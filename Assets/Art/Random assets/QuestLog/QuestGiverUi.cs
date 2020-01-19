using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiverUi : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private QuestScript[] quests;

    //debuging
    [SerializeField]
    private QuestLogUi tempLog;


    private void Awake()
    {
        tempLog.AcceptQuest(quests[0]);
        
    }
}
