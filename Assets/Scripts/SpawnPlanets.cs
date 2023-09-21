using UnityEngine;

public class SpawnPlanets : MonoBehaviour
{
    public GameObject obstacle;
    private float maxY = 4f;
    private float minY = -7f;
    private float timeBetweenSpawn = 5f;
    private float spawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

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
        if (obstacle.name.Equals("SpawnSun")) {
            randomY = -6f;
        } else if (obstacle.name.Equals("SpawnSand")) {
            randomY = -3f;
        }else if (obstacle.name.Equals("SpawnEarth")) {
            randomY = -1f;
        }else if (obstacle.name.Equals("SpawnRedPlant")){
            randomY = -1f;
        }

        float objectSize = Random.Range(0.9f, 1.4f);
        obstacle.transform.localScale = new Vector3(objectSize, objectSize, 1f);
        Instantiate(obstacle, transform.position + new Vector3(12f, randomY, 0), transform.rotation);
    }
}
