using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI team1ScoreText;
    [SerializeField] private TextMeshProUGUI team2ScoreText;

    private int team1Score;
    private int team2Score;

    private void Start()
    {
        // Initialize scores to 0
        team1Score = 0;
        team2Score = 0;
        UpdateTeam1Score(team1Score);
        UpdateTeam2Score(team2Score);
    }

    public void UpdateTeam1Score(int newScore)
    {
        team1Score = newScore;
        team1ScoreText.text = team1Score.ToString();
    }

    public void UpdateTeam2Score(int newScore)
    {
        team2Score = newScore;
        team2ScoreText.text = team2Score.ToString();
    }

    // Example method to increment scores for testing purposes
    public void IncrementTeam1Score()
    {
        UpdateTeam1Score(team1Score + 1);
    }

    public void IncrementTeam2Score()
    {
        UpdateTeam2Score(team2Score + 1);
    }
}