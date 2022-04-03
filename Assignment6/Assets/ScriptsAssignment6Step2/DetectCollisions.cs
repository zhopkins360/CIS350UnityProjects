/*
*Zackary Hopkins
*Assignment 6
*checks if this object has toched another another object if it has 
*increase the score and destroy it
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food projectile prefab
public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DiscplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
