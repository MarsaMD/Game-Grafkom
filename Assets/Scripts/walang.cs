using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walang : MonoBehaviour {

    public Vector3 spawnPoint;

    private int ranXPos;
	private Transform camPos;
    private int posisiW;
	
    // Use this for initialization
    void Start () {
		ranXPos = Random.Range(-2, 2);
        posisiW = ranXPos;
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

    public int PosisiWalang()
    {
        return posisiW;
    }


}
