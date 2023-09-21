using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float cameraSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
