using UnityEngine;

public class GoalkeeperCollision : MonoBehaviour
{
    public float deflectForce = 0.2f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRigidbody != null)
            {
                // Calculate the opposite direction to the ball's current velocity
                Vector3 oppositeDirection = -collision.contacts[0].normal;

                // Apply a force to the ball in the opposite direction to its current velocity
                ballRigidbody.AddForce(oppositeDirection * deflectForce, ForceMode.Impulse);
            }
        }
    }
}
