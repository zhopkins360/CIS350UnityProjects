﻿/*
*Zackary Hopkins
*Prototype3
*controlls if the players enters the zone and gives them a point
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerzoneAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")&& !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
