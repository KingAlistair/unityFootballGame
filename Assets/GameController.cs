using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform ballStartPosition;
    public Transform playerStartPosition;
    public GameObject ballPrefab;
    public GameObject playerPrefab;

    private GameObject ball;
    private GameObject player;

    void Start()
    {
        // Instantiate the ball and player prefabs at their starting positions
        ball = Instantiate(ballPrefab, ballStartPosition.position, Quaternion.identity);
        player = Instantiate(playerPrefab, playerStartPosition.position, Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPositions();
        }
    }

    void ResetPositions()
    {
        // Reset the ball's position and velocity
        Rigidbody ballRb = ball.GetComponent<Rigidbody>();
        ballRb.velocity = Vector3.zero;
        ball.transform.position = ballStartPosition.position;

        // Reset the player's position
        player.transform.position = playerStartPosition.position;
    }
}
