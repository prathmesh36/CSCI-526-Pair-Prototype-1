using UnityEngine;

public class HealthControl : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject gain;
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
            obstacle.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
        }
        else
        {
            obstacle.transform.localScale = new Vector3(0.4f, 0.4f, 1f);
        }
        count++;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Cruiser 1"))
        {
            GameObject expl = Instantiate(gain, transform.position + new Vector3(-5.5f, -2f, -2f), Quaternion.identity) as GameObject;
            Destroy(obstacle);
            Destroy(expl, 0.5f);
        }
    }

}
