﻿/*
*Zackary Hopkins
*Assignment 6
*lets the player shoot a given prefab from it's current position
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProfab : MonoBehaviour
{
    public GameObject prefabToShoot;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}