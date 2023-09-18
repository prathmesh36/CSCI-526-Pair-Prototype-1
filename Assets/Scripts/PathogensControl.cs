using UnityEngine;

public class PathogensControl : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject explosion;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (count % 10 == 0)
        {
            obstacle.transform.localScale = new Vector3(3, 3, 1f);
        }
        else
        {
            obstacle.transform.localScale = new Vector3(4f, 4f, 1f);
        }
        count++;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        Destroy(obstacle);
        Destroy(expl, 3);
    }

}
