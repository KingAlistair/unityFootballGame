using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
