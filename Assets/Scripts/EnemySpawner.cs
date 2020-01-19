using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public float TimeBetweenSpawn;
    public float timeSinceLastSpawn;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()

    { //InvokeRepeating("EnemyPrefab", spawnTime, spawnDelay);


        if (Time.time > TimeBetweenSpawn + timeSinceLastSpawn)
        {
            EnemySpawn();


            timeSinceLastSpawn = Time.time;
        }
    }
    public void EnemySpawn()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("EnemyPrefab");
        }
    }
}
