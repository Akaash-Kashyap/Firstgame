using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewScoreScript : MonoBehaviour
{
    //Vars
    Text scoreString1;





    // Start is called before the first frame update
    void Start()
    {
        scoreString1 = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        scoreString1.text = "Score: " + ScoreText.totalScore.ToString();
    }
}
