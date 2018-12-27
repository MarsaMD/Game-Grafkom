using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int spawnTime;

    private int timer;
    // Use this for initialization
    void Start () {
        BuatUlar();
        BuatWalang();
    }
	
	// Update is called once per frame
	void Update () {

        timer++ ;
        if (timer >= spawnTime )
        {
            BuatUlar();
            BuatWalang();
            timer = 0;
        }
    }
    void BuatUlar()
    {
        Instantiate(Resources.Load("Ular"));
    }
    void BuatWalang()
    {
        Instantiate(Resources.Load("Walang"));
    }


}
