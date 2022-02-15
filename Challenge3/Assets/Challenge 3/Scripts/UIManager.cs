/*
*Zackary Hopkins
*Challenge3
*controlls the ui text and score
*also allows the player to reset the game once it is over
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public int score;

    private PlayerControllerX playerControllerScript;

    private Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 5)
        {
            textbox.text = "You win!\nPress R to try again!";
            playerControllerScript.gameOver = true;
        }
        else if (!playerControllerScript.gameOver)
        {
            textbox.text = "Score: " + score;
        }
        else
        {
            textbox.text = "You lose!\nPress R to try again!";
        }

        if(playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
