using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameover;
    public Text playerScore;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.instance.HighScore == GameManager.instance.Score)
        {
            print("New record");
            gameover.text = "New Record";
            playerScore.text = "High Score: " + GameManager.instance.Score;
        }else if (GameManager.instance.HighScore > GameManager.instance.Score)
        {
            print("Nothing new");
            gameover.text = "Game Over";
            playerScore.text = "Your Score: " + GameManager.instance.Score + "  Record: " + GameManager.instance.HighScore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
