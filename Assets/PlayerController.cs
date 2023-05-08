using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
    private CharacterController characterController;
    public GameObject leftLeg;
    public float kickAngle = 30f;
    public float kickForce = 2.5f;
    public float kickDistance = 3f;

    private Vector3 startingPosition;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        startingPosition = transform.position;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float currentSpeed = moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }

        Vector3 movement = new Vector3(horizontal, 0, vertical) * currentSpeed * Time.deltaTime;
        characterController.Move(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition();
        }
    }

    void Kick()
    {
        leftLeg.transform.localRotation = Quaternion.Euler(-kickAngle, 0f, 0f);

        Collider[] colliders = Physics.OverlapSphere(leftLeg.transform.position, kickDistance);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Ball"))
            {
                Rigidbody rb = collider.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(leftLeg.transform.forward * kickForce, ForceMode.Impulse);
                }
            }
        }
        Invoke("ResetLegRotation", 0.5f);
    }

    void ResetLegRotation()
    {
        leftLeg.transform.localRotation = Quaternion.identity;
    }

    void ResetPosition()
    {
        transform.position = startingPosition;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
