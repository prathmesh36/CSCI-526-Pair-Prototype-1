using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public int Score = 100;
    public Text ScoreText;
    public Text TimeDilationPowerText;
    public int TimeDilationPower = 3;
    private bool flag = false;
    private float timeBetweenDilation = 10f;
    private float dilationTime;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Health: " + Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == false && TimeDilationPower > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            TimeDilationPower--;
            flag = true;
            TimeDilationPowerText.text = "Time Dilation Left: " + TimeDilationPower.ToString() + "/3";
            dilationTime = Time.time + timeBetweenDilation;
        }

        if (flag == true)
        {
            if (Time.time > dilationTime)
            {
                flag = false;
            }
        }

        if(Score < 50)
        {
            ScoreText.text = "You Lost!";
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("corona_idle")) {
            DecScore();
        } else if (other.gameObject.name.Equals("potionred05")) {
            IncScore();
        }
        
    }

    void DecScore()
    {
        Score -= 5;
        if (Score < 0)
        {
            Score = 0;
        }
        ScoreText.text = "Health: " + Score.ToString();
    }

    void IncScore()
    {
        Score += 10;
        if (Score > 100) {
            Score = 100;
        }
        ScoreText.text = "Health: " + Score.ToString();
    }
}
