using UnityEngine;

public class SpaceShipControl : MonoBehaviour
{

    //private float speed = 10.0f;
    private float horizontalInput;
    float verticalInput;
    public GameObject boundary;
    private Rigidbody2D rb;

    // Player movement speed
    public float moveSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
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
