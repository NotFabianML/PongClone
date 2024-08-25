using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    private float playerScore1;
    private float playerScore2;
    public Text scoreText;

    private void Start()
    {
        
    }

    public void addScore(int player, int scoreToAdd)
    {
        if (player == 1)
        {
            playerScore1 += scoreToAdd;
        }
        else if (player == 2)
        {
            playerScore2 += scoreToAdd;
        }

        scoreText.text = playerScore1.ToString() + " - " + playerScore2.ToString();

    }
}
