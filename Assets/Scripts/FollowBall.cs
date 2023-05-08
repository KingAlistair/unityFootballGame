using UnityEngine;

public class FollowBall : MonoBehaviour
{

    public Transform objectToFollow;
    public Vector3 offset = new Vector3(0f, 30f, -30f);
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        Vector3 targetPosition = objectToFollow.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(objectToFollow);
    }
}
