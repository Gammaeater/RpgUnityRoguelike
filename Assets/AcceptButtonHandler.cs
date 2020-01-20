using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptButtonHandler : MonoBehaviour
{
    public Text questAccept;
    // Start is called before the first frame update
    public void AcceptQuest()
    {
        questAccept.text = "Accepted!";
        questAccept.color = Color.green;
    }
}
