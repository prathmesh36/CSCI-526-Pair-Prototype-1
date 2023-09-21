using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    private bool flag = false;
    private float timeBetweenDilation = 10f;
    private float dilationTime;
    public int TimeDilationPower = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        AmplifyColorBase amplifyColorEffect = GetComponent<AmplifyColorBase>();

        if (flag == false && TimeDilationPower > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            flag = true;
            TimeDilationPower--;
            Texture2D newLutTexture = Resources.Load<Texture2D>("Textures/RedDawn");
            amplifyColorEffect.LutTexture = newLutTexture;
            dilationTime = Time.time + timeBetweenDilation;
        }

        if (flag == true)
        {
            if (Time.time > dilationTime)
            {
                flag = false;
                Texture2D newLutTexture = Resources.Load<Texture2D>("Textures/Normal");
                amplifyColorEffect.LutTexture = newLutTexture;
            }
        }



    }
}
