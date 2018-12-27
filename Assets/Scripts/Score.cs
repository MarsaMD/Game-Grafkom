using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float score = 0.0f;
    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString();
    }
    public void KenaWalang()
    {
       score += 10;
       scoreText.text = ((int)score).ToString();
	}

    public void Mati()
    {
        if(PlayerPrefs.GetFloat ("Highscore") < score)
             PlayerPrefs.SetFloat ("Highscore", score);

        Application.LoadLevel (Application.loadedLevel);
    }
}
