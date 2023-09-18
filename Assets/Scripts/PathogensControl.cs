using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathogensControl : MonoBehaviour
{

    public GameObject obstacle;
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
}
