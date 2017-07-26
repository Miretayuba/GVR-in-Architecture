# GVR-in-Architecture
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    //setting my variables
    public float speed = 2f;
    CharacterController player;

    float moveFrontBack;
    float moveLetRight;

    // rotation x and y for mouse 


    // start function which runs this script on program startup

    // Use this for initialization
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        moveFrontBack = Input.GetAxis("Vertical") * speed;
        moveLetRight = Input.GetAxis("Horizontal") * speed;



        // defining the player movemennt when input key is pressed 
        Vector3 movement = new Vector3(moveLetRight, 0, moveFrontBack);


        movement = transform.rotation * movement;

        player.Move(movement * Time.deltaTime);

    }
}
