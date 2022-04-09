﻿/*
*Zackary Hopkins
*Prototype 4
*controlls the enimes to go towards the player
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody enemyRb;
    public GameObject player;
    public float speed = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        //add force toward the direction from the player to the enemy
        
        //vector for the direction to the player
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

    }
}
