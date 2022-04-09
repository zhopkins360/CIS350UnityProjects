/*
*Zackary Hopkins
*Challenge 4
*handles the enemy movement and if it colliedd with either goal
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private int waveNum;
    private UIManager uIManager;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.FindGameObjectWithTag("PlayerGoal");
        waveNum = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>().waveCount;
        uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        //changes speed based on wave number
        speed += (waveNum * 2f);
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            uIManager.hasLost = true;
            Destroy(gameObject);
        }

    }
}
