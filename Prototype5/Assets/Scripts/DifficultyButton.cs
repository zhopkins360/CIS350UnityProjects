﻿/*
 * Zackary Hopkins
 * Prototype 5
 * this handles the difficlty when pressing the button this script is on
 *  
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;

    private GameManager gameManager;

    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(setDifficulty);

        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void setDifficulty()
    {
        Debug.Log(gameObject.name + "was clicked");
        gameManager.startGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
