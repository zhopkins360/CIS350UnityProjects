/*
*Zackary Hopkins
*Prototype2
*spawns random colored balls between random x values
*also randomizes the delay between balss spawning
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        //starts the ball spawning coroutine
        StartCoroutine(SpawnRandBallWithCoroutine());
    }
    //the enumerator to spawn the ball
    IEnumerator SpawnRandBallWithCoroutine()
    {
        //waits how every long before spawning balls
        yield return new WaitForSeconds(startDelay);
        //loops forever spawning balls
        while (true)
        {
            //spawns ball
            SpawnRandomBall();
            //creats random delay
            float randomDelay = Random.Range(3.0f, 5.0f);
            //waits they delay
            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        //randomly chose 1-3 for a ball color
        int randint = Random.Range(0, 3);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randint], spawnPos, ballPrefabs[randint].transform.rotation);
    }

}
