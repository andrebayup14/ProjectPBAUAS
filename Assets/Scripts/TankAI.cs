using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TankAI : MonoBehaviour
{
    [SerializeField] WheelCollider backLeftCollider;
    [SerializeField] WheelCollider backRightCollider;
    [SerializeField] WheelCollider frontLeftCollider;
    [SerializeField] WheelCollider frontRightCollider;

    [SerializeField] Transform backLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform frontRightTransform;

    public float accel = 500f;
    public float brake = 300f;
    public float maxAngleTurn = 15f;

    float currentAccel;
    float currentBrake;
    float currentAngleTurn;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        currentAccel = accel * Input.GetAxis("Vertical");
        currentAngleTurn = maxAngleTurn * Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            currentBrake = brake;
        }
        else
        {
            currentBrake = 0f;
        }

        frontLeftCollider.motorTorque = currentAccel;
        frontRightCollider.motorTorque = currentAccel;


        frontLeftCollider.brakeTorque = currentBrake;
        frontRightCollider.brakeTorque = currentBrake;
        backLeftCollider.brakeTorque = currentBrake;
        backRightCollider.brakeTorque = currentBrake;

        frontLeftCollider.steerAngle = currentAngleTurn;
        frontRightCollider.steerAngle = currentAngleTurn;

        UpdateWheel(backLeftCollider, backLeftTransform);
        UpdateWheel(backRightCollider, backRightTransform);
        UpdateWheel(frontLeftCollider, frontLeftTransform);
        UpdateWheel(frontRightCollider, frontRightTransform);

    }
    void UpdateWheel(WheelCollider wheCol, Transform trans)
    {
        Vector3 pos;
        Quaternion rot;

        wheCol.GetWorldPose(out pos, out rot);

        trans.position = pos;
        trans.rotation = rot;
    }
}
