/*
*Zackary Hopkins
*Prototype2
*the health system given to use by prof.Owen from prototype2 
*works the same by managing health and then dispaying it as UI elements
*added and extra ending game condition when the corrent score is reached
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    //creates varaiable s to be used later
    public int health;
    public int maxHealth;

    public List<Image> hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public bool gameOver = false;

    public GameObject gameOverText;
    void Update()
    {
        //If health is somehow more than max health, set health to max health
        if (health > maxHealth)
        {
            health = maxHealth;
        }


        for (int i = 0; i < hearts.Count; i++)
        {
            //Display full or empty heart sprite based on current health
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            //Show the number of hearts equal to current max health
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        //if the health falls to 0 or lower end game 
        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
        // if the score gets to 5 or higher end the game with a victory screen
        if (GameObject.FindGameObjectWithTag("ScoreSystem").GetComponent<DisplayScore>().Score >= 5)
        {
            gameOver = true;
            gameOverText.GetComponent<Text>().text = "YOU WIN!\nPress R to restart!";
            gameOverText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }

    }

    public void TakeDamage()
    {
        health--;
    }

    public void AddMaxHealth()
    {
        maxHealth++;
    }


}
