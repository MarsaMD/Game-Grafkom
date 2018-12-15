using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 5)
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5)
        {
            transform.position += Vector3.left;
        }

    }
}
