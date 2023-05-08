using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.y < -10f)
        {
            ResetBallPosition();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBallPosition();
        }
    }

    void ResetBallPosition()
    {
        transform.position = startingPosition;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
