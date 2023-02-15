using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MopedController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentbreakForce;
    private bool isBreaking;

    [SerializeField] Rigidbody RB;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] float maxSpeed = 6.0f;

    [SerializeField] private WheelCollider frontWheelCollider;
    [SerializeField] private WheelCollider backWheelCollider;

    [SerializeField] private Transform frontWheelTransform;
    [SerializeField] private Transform backWheelTransform;


    // Update is called once per frame
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();

        RB.velocity = Vector3.ClampMagnitude(RB.velocity, maxSpeed);
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        //isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        frontWheelCollider.motorTorque = verticalInput * motorForce;
        currentbreakForce = isBreaking ? breakForce : 1f;

        if (isBreaking)
        {
            ApplyBreaking();
        }
    }

    private void ApplyBreaking()
    {
        frontWheelCollider.brakeTorque = currentbreakForce;
        backWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle / horizontalInput;
        frontWheelCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontWheelCollider, frontWheelTransform);
        UpdateSingleWheel(backWheelCollider, backWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}
