using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int scorePlayerOne = 0;
    public int scorePlayerTwo = 0;

    public Text scoreText;

    public void PlayerOneScored()
    {
        scorePlayerOne++;
        UpdateScoreText();
    }

    public void PlayerTwoScored()
    {
        scorePlayerTwo++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = scorePlayerOne.ToString() + " - " + scorePlayerTwo.ToString();
    }
}
