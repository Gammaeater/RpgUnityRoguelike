using UnityEngine;
using UnityEngine.UI;

public class QuestLogUi : MonoBehaviour
{
    [SerializeField]
    private GameObject questPrefab;
    [SerializeField]
    private Transform questParent;
    // Start is called before the first frame update


    private static QuestLogUi instance;

    public static QuestLogUi Myinstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestLogUi>();
            }
            return instance;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AcceptQuest(QuestScript quest)
    {
        GameObject go = Instantiate(questPrefab, questParent);

        go.GetComponent<Text>().text = quest.MyTitle;


    }



}
