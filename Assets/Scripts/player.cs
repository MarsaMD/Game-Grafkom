using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    private CharacterController controller;
    private Vector3 moveVector;

    private float transation = 0.2f;
    private float speed = 5.0f;
    private float VerticalVelocity = 0.0f;
    private float gravity = 12.0f;
    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            VerticalVelocity = -0.5f;
        }
        else
        {
            VerticalVelocity -= gravity * Time.deltaTime;
        }

        // x-left and right
        moveVector.x = Input.GetAxis("Horizontal")* speed;
        // y-up and down
        moveVector.y = VerticalVelocity;
        //z-forward and backward
        //if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 5)
        //{
        //    transform.position += Vector3.right;
        //        
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5)
        //{
        //   transform.position += Vector3.left;
        //}
        controller.Move(moveVector * Time.deltaTime);

    }
	void OnTriggerEnter(Collider other){
    
		if (other.tag == "Ular"){
			Application.LoadLevel (Application.loadedLevel);
        }
        else if (other.tag == "Walang"){
			Application.LoadLevel (Application.loadedLevel);
        }
	}
}
