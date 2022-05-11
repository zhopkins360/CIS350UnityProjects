﻿/*
*Zackary Hopkins
*Assignment 6
*Checks if the current object is out of bounds 
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBound = 25;
    public float bottomBound = -5;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBound)
        {
            //grad the health system script
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
}