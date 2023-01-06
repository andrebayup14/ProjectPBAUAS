using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public Rigidbody theRB;

    public float maxSpeed;

    public float forwardAccel = 8f, reverseAccel = 4f;
    private float speedInput;

    public float turnStrength = 180f;
    private float turnInput;

    private void Start()
    {

        
    }
    private void Update()
    {
        speedInput = 0f;
        if (Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel;
        }

        turnInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        theRB.AddForce(transform.forward * speedInput * 1000f);


        //if (Input.GetKey(KeyCode.W))
        //{
        //    //rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10);
        //    rb.velocity = speed * transform.forward;
        //    //Vector3 velo = rb.velocity * speed;
        //    //rb.AddForce(velo, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    //rb.AddRelativeForce(-(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10) / 2);
        //    rb.velocity = speed * -transform.forward;
        //}

        //Vector3 rot = new Vector3(0f, turnSpeed, 0f);

        //if (Input.GetKey(KeyCode.D))
        //{
        //    Quaternion angle = Quaternion.Euler(rot);
        //    rb.MoveRotation(angle * rb.rotation);
        //    //rb.AddTorque(Vector3.up * turnSpeed * 10);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Quaternion angle = Quaternion.Euler(-rot);
        //    rb.MoveRotation(angle * rb.rotation);
        //    //rb.AddTorque(-Vector3.up * turnSpeed * 10);
        //}
    }
    
}
