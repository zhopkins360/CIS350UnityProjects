﻿/*
*Zackary Hopkins
*Challenge1
*sets the object an offset distance from the players current pos
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(25,0,10);
    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
