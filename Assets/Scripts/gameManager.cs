using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int spawnTime;
    private int timer;
    // Use this for initialization
    void Start () {
        BuatWall();
    }
	
	// Update is called once per frame
	void Update () {
        timer++;
        if (timer >= spawnTime)
        {
            BuatWall();
            timer = 0;
        }
    }
    void BuatWall()
    {
        Instantiate(Resources.Load("Wall"));
    }
}
