/*
 * Zackary Hopkins
 * Challenge 5
 * this handles the timerand when the game should end 
 *  
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemainging = 60;

    public TextMeshProUGUI timertext;

    private GameManagerX gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.isGameActive)
        {
            if (timeRemainging > 0)
            {
                timeRemainging -= Time.deltaTime;
                timertext.text = "Timer: " + Mathf.Round(timeRemainging);
            }
            else
            {
                gameManagerScript.GameOver();
            }
        }
    }
}
