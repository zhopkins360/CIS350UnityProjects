/*
*Zackary Hopkins
*Prototype2
*checks if a object moves out of the z bounds if it does destroy it
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
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }
    }
}
