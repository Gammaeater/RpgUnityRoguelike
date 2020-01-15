using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAI : MonoBehaviour
{
    private Vector3 startingPositions;
    // Start is called before the first frame update
    void Start()
    {
        startingPositions = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GetRoamingPosition()
    {
        return startingPositions + GetRandomDir() * Random.Range(10f, 70f);
    }

    public static Vector3 GetRandomDir()
    {
        return new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;
    }
}

