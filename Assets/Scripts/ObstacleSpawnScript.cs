using System;
using System.Runtime.CompilerServices;

using UnityEngine;

public class ObstacleSpawnScript : MonoBehaviour
{

    public GameObject[] obstacles = new GameObject[4];

    public float spawnRate;
    public float heightOffset;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {

            timer += Time.deltaTime;

        }
        else
        {

            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;


        Instantiate(obstacles[UnityEngine.Random.Range(0, 3)], new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}