using UnityEngine;

public class SpawnNegObstacles : MonoBehaviour
{
    public GameObject obstacle;
    private float maxY = 4f;
    private float minY = -7f;
    private float timeBetweenSpawn = 1f;
    private float spawnTime;
    private int count = 0;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomY_1 = Random.Range(minY, maxY);
        float randomY_2 = Random.Range(minY, maxY);
        if (count % 10 == 0)
        {
            if (count / 10 % 2 == 0)
            {
                obstacle.transform.localScale = new Vector3(1, 1, 1f);
            }
            else{
                obstacle.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            }
        }
        
        count++;
        Instantiate(obstacle, transform.position + new Vector3(12f, randomY_1, 0), transform.rotation);

        Instantiate(obstacle, transform.position + new Vector3(12f, randomY_2, 0), transform.rotation);
    }
}
