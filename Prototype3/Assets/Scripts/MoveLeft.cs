﻿/*
*Zackary Hopkins
*Prototype3
*Moves the object it is in to the left then destroys 
*it once out of bounds if it is an obstacal
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private PlayerController playerControllerScript;
    private float leftbound = -6.5f;
    private void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
