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

    public AudioSource goalSound;

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
    goalSound.Play();
    Invoke("StopGoalSound", 1f); 
    Invoke("ResetPositions", 2f);
}
    }

    public void StopGoalSound()
{
    goalSound.Stop();
}

    private void ResetPositions()
{
    goalScored = false;

    GameObject ball = GameObject.FindGameObjectWithTag("Ball");
    if (ball != null)
    {
        ball.transform.position = initialBallPosition;
        ball.transform.rotation = initialBallRotation;
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        if (ballRigidbody != null)
        {
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;
        }
    }

    GameObject player = GameObject.FindGameObjectWithTag("Player");
    if (player != null)
    {
        player.transform.position = initialPlayerPosition;
        player.transform.rotation = initialPlayerRotation;
        Rigidbody playerRigidbody = player.GetComponent<Rigidbody>();
        if (playerRigidbody != null)
        {
            playerRigidbody.velocity = Vector3.zero;
            playerRigidbody.angularVelocity = Vector3.zero;
        }
    }
}
}