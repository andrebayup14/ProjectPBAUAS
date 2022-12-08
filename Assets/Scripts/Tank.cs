using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float gravityMul;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }
    private void Update()
    {
       
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10) / 2);
        }
        Vector3 locVelocity = transform.InverseTransformDirection(rb.velocity);
        locVelocity.x = 0;
        rb.velocity = transform.TransformDirection(locVelocity);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * turnSpeed * 10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-Vector3.up * turnSpeed * 10);
        }
    }
    
}
