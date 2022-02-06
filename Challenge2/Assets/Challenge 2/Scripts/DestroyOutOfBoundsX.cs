/*
*Zackary Hopkins
*Challenge2
*destroys and object when it moves out of the bounds
*if a ball move out of bounds then it takes health away
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{

    private float leftLimit = -50;
    private float bottomLimit = -5;
    private HealthSystem healthSystemScript;
    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit and takes a health away
        else if (transform.position.y < bottomLimit)
        {
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }

    }
}
