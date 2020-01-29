using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Button[] actionButtons;
    [SerializeField]
    Animator minobossAnim;

    private KeyCode action1, action2, action3, action4;

    // Start is called before the first frame update
    void Start()
    {
        action1 = KeyCode.Keypad1;
        action2 = KeyCode.Keypad2;
        action3 = KeyCode.Keypad3;
        action4 = KeyCode.Keypad4;

    }

    // Update is called once per frame
    void Update()
    {
        if (minobossAnim.GetBool("IsTargeted") == true)
        {
            if (Input.GetKeyDown(action1))
            {
                actionButtons[0].Select();
                Debug.Log("Selected 1 ActionButton");
            }
            if (Input.GetKeyDown(action2))
            {
                actionButtons[1].Select();
                Debug.Log("Selected 2 ActionButton");

            }
            if (Input.GetKeyDown(action3))
            {
                actionButtons[2].Select();
                Debug.Log("Selected 3 ActionButton");
            }
            if (Input.GetKeyDown(action4))
            {
                actionButtons[3].Select();
                Debug.Log("Selected 4 ActionButton");
            }


        }
        


    }
    private void ActionButtonOnClick()
    {
    }
}
