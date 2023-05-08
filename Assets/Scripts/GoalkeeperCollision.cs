using UnityEngine;

public class GoalkeeperCollision : MonoBehaviour
{
    public float deflectForce = 5f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRigidbody != null)
            {
                Vector3 oppositeDirection = -collision.contacts[0].normal;
                ballRigidbody.AddForce(oppositeDirection * deflectForce, ForceMode.Impulse);
            }
        }
    }
}
