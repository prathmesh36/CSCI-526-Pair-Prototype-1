using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    private float maxY = 5f;
    private float minY = -7f;
    private float timeBetweenSpawn = 5f;
    private float spawnTime;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(12f, randomY, 0), transform.rotation);
    }
}
