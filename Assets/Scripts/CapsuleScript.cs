using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Space was pressed down.");
    }

    // Update is called once per frame
    void Update()
    {

     if(Input.GetKeyDown(KeyCode.R))
     {
         GetComponent<Renderer>().material.color = UnityEngine.Color.red;
     }
}
}
