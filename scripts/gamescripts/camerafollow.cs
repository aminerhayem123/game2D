using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public GameObject player;

    private void FixedUpdate()
    {
        transform.position = target.position+offset;
    }
}
