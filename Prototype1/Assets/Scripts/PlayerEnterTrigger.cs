/*
*Zackary Hopkins
*Prototype1
*checks if the player is toching an object with the "TriggerZone" tag
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
