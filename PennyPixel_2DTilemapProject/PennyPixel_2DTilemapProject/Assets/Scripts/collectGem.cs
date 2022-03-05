using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectGem : MonoBehaviour
{
    scoreTracker scoreTrackerScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreTrackerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<scoreTracker>();
    }
    //increases score when collied with player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scoreTrackerScript.score++;
        }
    }
}
