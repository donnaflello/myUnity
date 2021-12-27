using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform marbleTransform;
    public Rigidbody marbleRigidbody;

    public float height;
    public float followDistance;
    public Vector3 lookatOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = marbleTransform.position + new Vector3(0, height, followDistance);
        transform.LookAt(marbleTransform.position);
        transform.Rotate(lookatOffset);
    }
}
