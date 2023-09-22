using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimeControl : MonoBehaviour
{
    public float gameTimeInSeconds = 28.0f; // Set the total game time in seconds.
    private bool gameEnded = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameEnded && Time.time >= gameTimeInSeconds)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        // Add your endgame logic here.
        // For example, you can show a game over screen, display a score, or perform other end-of-game actions.

        // Set the gameEnded flag to true to prevent the endgame logic from being executed repeatedly.
        gameEnded = true;
        Time.timeScale = 0f;
    }
}
