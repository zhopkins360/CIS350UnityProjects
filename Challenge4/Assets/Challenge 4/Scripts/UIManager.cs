/*
*Zackary Hopkins
*Challenge 4
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
    private SpawnManagerX spawnManager;
    private PlayerControllerX playerController;
    public bool hasLost = false;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
        if (hasLost)
        {
            Time.timeScale = 0;
            textBox.text = "You Lose! Press R to Restart!";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (spawnManager.waveCount > 10)
        {
            Time.timeScale = 0;
            textBox.text = "You Win! Press R to Restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (Time.timeScale == 1)
        {
            textBox.text = "Wave - " + (spawnManager.waveCount -1);
        }
    }
}
