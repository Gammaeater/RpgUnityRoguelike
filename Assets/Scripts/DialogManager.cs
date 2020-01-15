using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public GameObject dbx;
    public Text dText;

    public bool dialogActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            dbx.SetActive(false);
            dialogActive = false;
        }
        
    }
    public void ShowBox(string dialog)
    {
        dialogActive = true;
        dbx.SetActive(true);
        dText.text = dialog;
        
    }
}
