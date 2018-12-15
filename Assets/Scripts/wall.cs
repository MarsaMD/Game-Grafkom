using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {

    public Vector3 spawnPoint;

	private Transform camPos;
	private int ranXPos = Random.Range(-5,6);

    // Use this for initialization
    void Start () {
		ranXPos = Random.Range(-5, 5);
        transform.position = new Vector3(ranXPos,spawnPoint.y,spawnPoint.z);
        camPos = GameObject.Find ("Main Camera").GetComponent<Transform> ();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.back;
        if (transform.position.z < camPos.position.z)
        {
            Destroy(gameObject);
        }
    }
}
