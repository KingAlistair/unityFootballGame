using UnityEngine;
using TMPro;

public class UpdateScoreTeam1 : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public Transform ballStartPosition;
    public Transform playerStartPosition;

    private Vector3 initialBallPosition;
    private Quaternion initialBallRotation;
    private Vector3 initialPlayerPosition;
    private Quaternion initialPlayerRotation;
    private bool goalScored = false;

    private void Start()
    {
        initialBallPosition = ballStartPosition.position;
        initialBallRotation = ballStartPosition.rotation;
        initialPlayerPosition = playerStartPosition.position;
        initialPlayerRotation = playerStartPosition.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball") && !goalScored)
        {
            goalScored = true;
            score += 1;
            scoreText.text = "Team 1: " + score.ToString();
            Invoke("ResetPositions", 2f);
        }
    }

    private void ResetPositions()
    {
        goalScored = false;
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        ball.transform.position = initialBallPosition;
        ball.transform.rotation = initialBallRotation;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = initialPlayerPosition;
        player.transform.rotation = initialPlayerRotation;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
