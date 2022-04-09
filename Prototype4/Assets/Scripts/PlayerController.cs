/*
*Zackary Hopkins
*Prototype 4
*controlls the movement of the player
*Also handles collisions with objects and power up buff
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private float forwardInput;

    private GameObject focalPoint;

    public bool hasPowerUP;
    private float powerupStrength = 15.0f;

    public GameObject powerupIndicator;
    public bool fellOff = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        //move our power up indicator to our player
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        if (transform.position.y < -10)
        {
            fellOff = true;
        }
    }

    private void FixedUpdate()
    {
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUP = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUP = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUP)
        {
            Debug.Log("PlayerController collided with" + collision.gameObject.name + "with powerup set to "+hasPowerUP);

            //get a local ref 
            Rigidbody enemyRididbody = collision.gameObject.GetComponent<Rigidbody>();

            //set a vector 3 with a direction away from the player
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;

            //add force away from player
            enemyRididbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
}
