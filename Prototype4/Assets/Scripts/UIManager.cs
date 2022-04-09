/*
*Zackary Hopkins
*Prototype 4
*Controlls the UI elements and reloading the scene. Also handles win and lose condition
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public Text textBox;
    private SpawnManager spawnManager;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
        if (playerController.fellOff)
        {
            textBox.text = "You Lose! Press R to Restart!";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (spawnManager.waveNumber > 10)
        {
            textBox.text = "You Win! Press R to Restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if(Time.timeScale == 1)
        {
            textBox.text = "Wave -" + spawnManager.waveNumber;
        }
    }
}
