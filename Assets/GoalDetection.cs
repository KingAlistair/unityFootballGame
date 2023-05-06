using UnityEngine;

public class GoalDetection : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private ScoreBoardController scoreBoardController;
    [SerializeField] private string team1GoalName = "Team1Goal";
    [SerializeField] private string team2GoalName = "Team2Goal";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (gameObject.name == team1GoalName)
            {
                GoalScoredForTeam2();
            }
            else if (gameObject.name == team2GoalName)
            {
                GoalScoredForTeam1();
            }
        }
    }

    private void GoalScoredForTeam1()
    {
        scoreBoardController.IncrementTeam1Score();
    }

    private void GoalScoredForTeam2()
    {
        scoreBoardController.IncrementTeam2Score();
    }
}