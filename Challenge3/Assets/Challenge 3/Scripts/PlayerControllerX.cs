/*
*Zackary Hopkins
*Challenge3
*Controlls the ballons floating, sounds and partical effects
*also deals with collisons of objects with the player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip bounceSound;

    private UIManager uiManager;


    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<UIManager>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && (transform.position.y < 13.5))
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
        if (Input.GetKey(KeyCode.R))
        {

        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            uiManager.score++;
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

        else if (other.gameObject.CompareTag("Ground"))
        {
            playerAudio.PlayOneShot(bounceSound, 1.0f);
            playerRb.AddForce(Vector3.up * 600);
        }
    }

}
