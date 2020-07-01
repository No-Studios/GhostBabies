using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score = 0;
    public int gameOverCount = 0; 
    public Text scoreText;
    public GameObject GameOverScreen; 
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + score; 
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOverCount == 3)
        {
            GameOverScreen.SetActive(true);
        }
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = "" + score; 
    }
}
