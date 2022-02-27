using System.Net.Mime;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreAmt;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score:100";
        scoreAmt = 0;
         if(Input.GetKeyDown(KeyCode.Space))
        {
        Debug.Log("does it even show up");
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + scoreAmt;
       
    }
}
