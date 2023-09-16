using UnityEngine;

public class SpaceShipControl : MonoBehaviour
{

    //private float speed = 10.0f;
    //private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //forwardInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.down * Time.deltaTime * speed * forwardInput);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}
