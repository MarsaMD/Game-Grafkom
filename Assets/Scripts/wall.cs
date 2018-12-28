using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {

    public Vector3 spawnPoint;

    private int ranXPos;
	private Transform camPos;
    public int walang;
    private int posisiU;

    // Use this for initialization
    void Start () {
        walang = FindObjectOfType<walang>().PosisiWalang();
        

        posisiU = Random.Range(-2, 2);
        if (posisiU == walang)
        {
            posisiU = posisiU + 1;
        }
        ranXPos = posisiU +1;
        transform.position = new Vector3(ranXPos,spawnPoint.y,spawnPoint.z);
        camPos = GameObject.Find ("Main Camera").GetComponent<Transform> ();

    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.back * 50 * Time.deltaTime;
        if (transform.position.z < camPos.position.z)
        {
            Destroy(gameObject);
        }
    }

}
