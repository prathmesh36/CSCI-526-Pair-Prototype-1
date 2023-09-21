using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float cameraSpeed = 30f;
    private bool flag = false;
    private float timeBetweenDilation = 10f;
    private float dilationTime;
    public int TimeDilationPower = 3;

    // Update is called once per frame
    void Update()
    {

        if (flag == false && TimeDilationPower > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Pressed");
            cameraSpeed = 10f;
            flag = true;
            TimeDilationPower--;
            dilationTime = Time.time + timeBetweenDilation;
        }

        if (flag == true) {
            if (Time.time > dilationTime)
            {
                flag = false;
                cameraSpeed = 30f;
            }
        }

        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);

    }
}
