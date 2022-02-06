﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //set refs
    public GameObject[] prefabsToSpawn;
    public HealthSystem healthSystem;
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;
    // Update is called once per frame
    void Start()
    {
        //get healthsystem
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);    
        StartCoroutine(SpawnRandomPrefabWithCoroutine());

    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();
            float randomDelay = Random.Range(1.5f, 3.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPrefab();
        }
    }

    void SpawnRandomPrefab()
    {
        //chose random animal
        int randint = Random.Range(0, prefabsToSpawn.Length);
        //set random pos
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);
        //create prefab instance
        Instantiate(prefabsToSpawn[randint], spawnPos, prefabsToSpawn[randint].transform.rotation);
    }

}
