using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;
    public float jumpHeight;
    private bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(new Vector3(0, 0, -speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(new Vector3(-speed, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(new Vector3(speed, 0, 0));
        }
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0, jumpHeight, 0));
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            canJump = true;
        }
    }
}
