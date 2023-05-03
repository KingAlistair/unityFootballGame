using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform objectToFollow;


void Update() {
    transform.position = new Vector3(
        objectToFollow.position.x,
        objectToFollow.position.y,
        transform.position.z
    );

}

}
