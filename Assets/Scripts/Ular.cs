using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ular : MonoBehaviour {

    public Vector3 spawnPoint;
	public int speed = 1;

	private Transform camPos;
	private int ranXPos;

    // Use this for initialization
    void Start () {
		ranXPos = Random.Range(-2, 2);
        transform.position = new Vector3(ranXPos,spawnPoint.y,spawnPoint.z);
        camPos = GameObject.Find ("Main Camera").GetComponent<Transform> ();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.back * speed;
        if (transform.position.z < camPos.position.z)
        {
            Destroy(gameObject);
        }
    }
}
