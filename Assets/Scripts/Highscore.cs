using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    private float score = 0.0f;
    public Text highscoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "Highscore : " +  ((int)PlayerPrefs.GetFloat ("Highscore")).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
