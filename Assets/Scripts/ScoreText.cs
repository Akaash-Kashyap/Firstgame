using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class ScoreText : MonoBehaviour
{
    //Vars
    public static int totalScore = 0;
    public TMP_Text scoreString;





    // Start is called before the first frame update
    void Start()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
        scoreString.text = "Score: " + totalScore.ToString();
    }
}
