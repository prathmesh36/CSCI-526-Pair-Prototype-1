using UnityEngine;

public class SpaceShipControl : MonoBehaviour
{

    //private float speed = 10.0f;
    //private float horizontalInput;

    public GameObject boundary;

    // Player movement speed
    public float moveSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.down * Time.deltaTime * speed * horizontalInput);

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
