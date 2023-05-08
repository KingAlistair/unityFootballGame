using UnityEngine;

public class KeepYPosition : MonoBehaviour
{
    private float originalY;

    void Start()
    {
        originalY = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, originalY, transform.position.z);
    }
}