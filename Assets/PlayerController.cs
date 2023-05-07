using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f;
    private CharacterController characterController;
    public GameObject leftLeg;
    public float kickAngle = 90f;
    public float kickForce = 10f;
    public float kickDistance = 1f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        characterController.Move(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
        }
    }

    void Kick()
    {
        // Rotate the LeftLeg gameobject to mimic kicking the ball
        leftLeg.transform.localRotation = Quaternion.Euler(-kickAngle, 0f, 0f);

        // Check if there is a ball nearby
        Collider[] colliders = Physics.OverlapSphere(leftLeg.transform.position, kickDistance);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Ball"))
            {
                Rigidbody rb = collider.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // Apply a force to the ball to simulate kicking it
                    rb.AddForce(leftLeg.transform.forward * kickForce, ForceMode.Impulse);
                }
            }
        }

        // Rotate the LeftLeg gameobject back to its original position after a short delay
        Invoke("ResetLegRotation", 0.5f);
    }

    void ResetLegRotation()
    {
        leftLeg.transform.localRotation = Quaternion.identity;
    }
}