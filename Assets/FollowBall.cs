using UnityEngine;

public class FollowBall : MonoBehaviour
{

    public Transform objectToFollow;
    public Vector3 offset = new Vector3(0f, 30f, -30f);
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        // Calculate the camera's target position based on the object to follow and offset
        Vector3 targetPosition = objectToFollow.position + offset;

        // Smoothly move the camera towards the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

        // Set the camera's position and rotation to match the smoothed position and the object to follow
        transform.position = smoothedPosition;
        transform.LookAt(objectToFollow);
    }
}
