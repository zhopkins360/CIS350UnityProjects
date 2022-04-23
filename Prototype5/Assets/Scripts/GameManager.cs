/*
 * Zackary Hopkins
 * Prototype 5
 * this handles the spawning of object, and also the start and end of the game.
 *  
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button gameOverButton;

    private int score;

    public bool isGameActive;

    public GameObject titleScreen;



    // Use this for initialization
    void Start()
    {
        
    }   

    public void startGame(int difficulty)
    {
        spawnRate /= difficulty;
        titleScreen.SetActive(false);
        score = 0;
        UpdateScore(0);
        isGameActive = true;
        StartCoroutine(SpawnTarget());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverText.gameObject.SetActive(true);
        gameOverButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            //wait a sec
            yield return new WaitForSeconds(spawnRate);
            //get a random index 
            int index = Random.Range(0, targets.Count);
            //create the random object
            Instantiate(targets[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
