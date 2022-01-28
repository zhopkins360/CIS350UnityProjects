using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreController : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 5)
        {
            won = true;
            gameOver = true;
        }
        //checks if the game is over. if not update the score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        //if the R button is pressed while the game is over it resets the game
        else if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //if the game is over and the player won print a you wind screen
        else if(won)
        {
            textbox.text = "YOU WIN!\nPress R to play again";
        }
        //if the game is over and the player didn't win prints a you lose screen
        else
        {
            textbox.text = "you lost...\nPress R to play again";
        }
    }
}
