using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform targetObject;
    public Vector3 cameraOffset;
    public float smoothFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = newPosition;
        transform.LookAt(targetObject);
    }
}
