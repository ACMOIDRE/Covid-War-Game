using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    private float spawnTime;
    public float timeBetweenSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime ){
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;

        }
        
    }

    private void Spawn()
    {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX,randomY ,0f), transform.rotation);

    }
}
