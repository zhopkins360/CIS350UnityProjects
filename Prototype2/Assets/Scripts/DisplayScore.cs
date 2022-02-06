/*
*Zackary Hopkins
*Prototype2
*updates the score text box every frame and starts it at 0
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour
{
    public Text textBox;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //set text componet reference on start
        textBox = GetComponent<Text>();

        textBox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Score: " + score;
    }
}
