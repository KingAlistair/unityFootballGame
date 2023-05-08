using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
    private CharacterController characterController;
    public GameObject leftLeg;
    public float kickAngle = 30f;
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
        float strength = 0.5f;
        float maxStrength = 3f;
        float kickDuration = 0.5f;
        float kickTime = 0f;
        bool isKicking = true;

        leftLeg.transform.localRotation = Quaternion.Euler(-kickAngle, 0f, 0f);

        StartCoroutine(ChargeKick());

        IEnumerator ChargeKick()
        {
            while (isKicking)
            {
                kickTime += Time.deltaTime;
                strength = Mathf.Lerp(1f, maxStrength, kickTime / kickDuration);

                if (!Input.GetKey(KeyCode.Space) || kickTime >= kickDuration)
                {
                    isKicking = false;

                    Collider[] colliders = Physics.OverlapSphere(leftLeg.transform.position, kickDistance);
                    foreach (Collider collider in colliders)
                    {
                        if (collider.CompareTag("Ball"))
                        {
                            Rigidbody rb = collider.GetComponent<Rigidbody>();
                            if (rb != null)
                            {
                                rb.AddForce(leftLeg.transform.forward * strength, ForceMode.Impulse);
                            }
                        }
                    }

                    Invoke("ResetLegRotation", 0.5f);
                }

                yield return null;
            }
        }
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
