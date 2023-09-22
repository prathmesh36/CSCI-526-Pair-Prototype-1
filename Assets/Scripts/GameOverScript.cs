using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);

        // Start a coroutine to display the "Game Over" message after a specific time
        StartCoroutine(ShowGameOverAfterDelay(27.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ShowGameOverAfterDelay(float delayInSeconds)
    {
        // Wait for the specified time
        yield return new WaitForSeconds(delayInSeconds);

        // Set the text to "Game Over" or any message you want
        gameOverText.text = "GAME OVER YOU WON!!!!";

        // Display the Game Over message
        gameOverText.gameObject.SetActive(true);
    }
}
