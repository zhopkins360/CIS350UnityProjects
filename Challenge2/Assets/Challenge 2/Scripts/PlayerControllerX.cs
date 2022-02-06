/*
*Zackary Hopkins
*Prototype2
*controlls when they play can shoot a dog at the balls
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float shootingDelay = 3.0f;
    private bool canShoot = true;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canShoot)
            {
                //spawns the dog 
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                //changes the can shoot var
                canShoot = false;
                //starts the coroutine to count how long before sooting again
                StartCoroutine(buttonTimer(shootingDelay));
            }
        }
    }
    //an ienumerator for timing the dog spawning
    IEnumerator buttonTimer(float delay)
    {
        //waits for 3 seconds
        yield return new WaitForSeconds(delay);
        //changes shooting var
        canShoot = true;
    }
}
