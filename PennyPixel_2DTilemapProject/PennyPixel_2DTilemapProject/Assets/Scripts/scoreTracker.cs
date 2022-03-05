using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreTracker : MonoBehaviour
{
    public bool won = false;
    public Text textbox;
    public int score = 0;
    // Update is called once per frame
    void Update()
    {
        //checks if the game is won
        if (!won)
        {
            //if not update score
            textbox.text = "Score: " + score;
        }
        //if player has won
        else
        {
            //print they win and tell them thier score
            textbox.text = "You won with a score of " + score + "\nPress R to try again!";
            //Also allow them to restart by pressing R
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
