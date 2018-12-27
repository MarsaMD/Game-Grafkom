using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int score = 3;
    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
    score = 3;
    scoreText.text = "Health : " + ((int)score).ToString();
    }

    // Update is called once per frame
    public void KenaUler()
    {
        if (score > 1){ 
       score -= 1;
       scoreText.text = "Health : " + ((int)score).ToString();
        }

        else {
        FindObjectOfType<Score>().Mati();
        }
	}

    
}
