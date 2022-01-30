/*
*Zackary Hopkins
*Challenge1
*checks if this object has collided with the player only once then increases the score
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    private bool triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreController.score++;
        }
    }
}
