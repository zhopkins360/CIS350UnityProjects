/*
*Zackary Hopkins
*Prototype2
*displays the current score and managers the score var
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour
{
    public int Score = 0;
    public Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Score: " + Score;
    }
}
