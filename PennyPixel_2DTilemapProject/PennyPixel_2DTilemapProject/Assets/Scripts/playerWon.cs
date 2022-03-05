/*
 * Zackary Hopkins 
 * Assignment 5A
 * checks if the player enters the trigger zone and changes won bool
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWon : MonoBehaviour
{
    public scoreTracker scoreTrackerScript;
    private void Start()
    {
        scoreTrackerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<scoreTracker>();
    }
    //checks if the player is touching the endzone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            scoreTrackerScript.won = true;
            Debug.Log("won");
        }
    }
}
