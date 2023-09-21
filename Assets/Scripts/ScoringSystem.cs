using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public int Score = 100;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        ScoreText.text = "Score: " + Score.ToString();
    }

    void IncScore()
    {
        Score += 10;
        if (Score > 100) {
            Score = 100;
        }
        ScoreText.text = "Score: " + Score.ToString();
    }
}
