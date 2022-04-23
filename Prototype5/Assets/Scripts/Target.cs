/*
 * Zackary Hopkins
 * Prototype 5
 * this takes care of the random force and spin for an object.
 * Also when the player clicks on the object
 *  
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetBody;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpqanPos = -6;

    public int pointValue;

    private GameManager gameManager;

    public ParticleSystem explisionParticle;

    // Start is called before the first frame update
    void Start()
    {
        targetBody = GetComponent<Rigidbody>();

        //add force
        targetBody.AddForce(RandomForce(), ForceMode.Impulse);

        //add torque
        targetBody.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        //set random pos
        transform.position = RandomSpawnPos();

        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpqanPos);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            gameManager.UpdateScore(pointValue);

            Instantiate(explisionParticle, transform.position, explisionParticle.transform.rotation);

            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.gameOver();
        }
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
