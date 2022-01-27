/*
*Zackary Hopkins
*Prototype1
*checks the y value to see if the object has dropped below -1
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseOnFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
        
    }
}
