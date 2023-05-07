using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 5f;

    private float startPosX;

    void Start()
    {
        startPosX = transform.position.x;
    }

    void Update()
    {
        float newX = Mathf.PingPong(Time.time * speed, distance) + startPosX;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
