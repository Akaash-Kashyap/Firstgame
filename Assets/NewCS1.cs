using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NewCS1 : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    private bool jumpKeyWasPressed;
    private float horizontalMovement;
    private Rigidbody rigidbodyComponent;
    Vector3 spawn = new Vector3(0,2,0);
    Color CharacterColor = new Color(1,0.3820755f,0.3820755f,1);
    



    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
     {
         jumpKeyWasPressed = true;
     }
     horizontalMovement = Input.GetAxis("Horizontal");

        //death
        if(rigidbodyComponent.position.y < -5)
        {
            rigidbodyComponent.MovePosition(spawn);
            rigidbodyComponent.velocity = new Vector3(.5f,.5f,0.5f);
            ScoreText.totalScore = 0;
        }
     
    }
    // fixed update is called once every physics update
    private void FixedUpdate()
    {
        
        rigidbodyComponent.velocity = new Vector3(horizontalMovement * 3,rigidbodyComponent.velocity.y,0);

        if(Physics.OverlapSphere(groundCheckTransform.position,0.1f, playerMask).Length == 0)
        {
            return;
        }

        if(jumpKeyWasPressed)
     {
         rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
         jumpKeyWasPressed = false;
     }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            Destroy(other.gameObject);
            ScoreText.totalScore++;
            

        }
        if(other.gameObject.layer == 8)
        {
            spawn = new Vector3(rigidbodyComponent.position.x, rigidbodyComponent.position.y + 2,0);
            //UnityEngine.Debug.Log("does it reach?");
            other.gameObject.GetComponent<Renderer>().material.color = CharacterColor;
        }
        
    }



}
