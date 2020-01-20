using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class QuestScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private string title;
    void Start()
    {
        
    }
    public string MyTitle
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
