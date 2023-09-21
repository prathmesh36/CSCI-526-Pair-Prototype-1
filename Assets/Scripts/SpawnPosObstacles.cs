using UnityEngine;

public class SpawnPosObstacles : MonoBehaviour
{
    public GameObject obstacle;
    private float maxY = 4f;
    private float minY = -7f;
    private float timeBetweenSpawn = 3f;
    private float spawnTime;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        float randomY = Random.Range(minY, maxY);
   
        if (count % 10 == 0)
        {
            if (count / 10 % 2 == 0)
            {
                obstacle.transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else
            {
                obstacle.transform.localScale = new Vector3(1.2f, 1.2f, 1f);
            }
        }
        count++;
        Instantiate(obstacle, transform.position + new Vector3(24f, randomY, 0), transform.rotation);
    }
}
