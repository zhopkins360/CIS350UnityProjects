/*
*Zackary Hopkins
*Assigment 6
*controlls the player movment and the bounds of how far it can go
*inherits singleton b/c there only needs to be one
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{

    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 18;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //transfore our player
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //keep player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
