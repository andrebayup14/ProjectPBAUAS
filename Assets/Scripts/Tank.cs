using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tank : MonoBehaviour
{
    Rigidbody rb;
    public float speed, turnSpeed;

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
            //rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10);
            rb.velocity = speed * transform.forward;
            //Vector3 velo = rb.velocity * speed;
            //rb.AddForce(velo, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rb.AddRelativeForce(-(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10) / 2);
            rb.velocity = speed * -transform.forward;
        }

        Vector3 rot = new Vector3(0f, turnSpeed, 0f);

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion angle = Quaternion.Euler(rot);
            rb.MoveRotation(angle * rb.rotation);
            //rb.AddTorque(Vector3.up * turnSpeed * 10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion angle = Quaternion.Euler(-rot);
            rb.MoveRotation(angle * rb.rotation);
            //rb.AddTorque(-Vector3.up * turnSpeed * 10);
        }
    }
    
}
