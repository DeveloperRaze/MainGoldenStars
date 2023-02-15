using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;

    private float currentSteerAngle;
    private float currentbreakForce;
    private bool isBreaking;

    public ControlMode control;

    //Add Rigidbody to Vehicle.
    [SerializeField] Rigidbody RB;

    //Serialise engine power, break force, and max steer angle. 
    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    //Init speed at 6.
    [SerializeField] float maxSpeed = 6.0f;

    //Add reference to 4 wheel colliders
    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider backLeftWheelCollider;
    [SerializeField] private WheelCollider backRightWheelCollider;

    //Add reference to 4 wheel transforms
    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform backLeftWheelTransform;
    [SerializeField] private Transform backRightWheelTransform;

    //Method to change input type(Keyboard will be removed as this is a mobile game)
    public enum ControlMode
    {
        Keyboard,
        Buttons
    };

    // Update is called once per frame
    private void Update()
    {
        //Get input controls and update wheel transforms
        GetInput();
        UpdateWheels();
        //Rigidbody velocity clamp
        RB.velocity = Vector3.ClampMagnitude(RB.velocity, maxSpeed);
    }

    void LateUpdate() 
    {
        //Handle engine and steering
        HandleMotor();
        HandleSteering();
    }


    public void MoveInput(float input)
    {
        //Handle forward/backward input
        verticalInput = input;
    }

    public void SteerInput(float input)
    {
        //Handle forward/backward input
        horizontalInput = input;
    }

    void GetInput()
    {
        //if input is keyboard
        if (control == ControlMode.Keyboard)
        {
            verticalInput = Input.GetAxis(VERTICAL);
            horizontalInput = Input.GetAxis(HORIZONTAL);
            //isBreaking = Input.GetKey(KeyCode.Space);
        }
    }

    private void HandleMotor()
    {
        //Handle engine torque / velocity and breaking
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;
        currentbreakForce = isBreaking ? breakForce : 1f;

        if (isBreaking)
        {
            //Unable to get this working. 
            ApplyBreaking();
        }
    }

    private void ApplyBreaking()
    {
        //Unable to get this working. 
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        backLeftWheelCollider.brakeTorque = currentbreakForce;
        backRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        //Handle steering based on horizontal input. 
        currentSteerAngle = maxSteerAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
        UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
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
