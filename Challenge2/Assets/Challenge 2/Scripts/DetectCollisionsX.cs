/*
*Zackary Hopkins
*Prototype2
*detects the collision between the dog and ball and when they touch 
*it destroys the ball and increasses the score
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScoreScript;
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("ScoreSystem").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.Score++;
        Destroy(gameObject);
    }
}
