using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {
        score = 0;
        UpdateScoreboard();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreboard();
    }

    private void UpdateScoreboard()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
