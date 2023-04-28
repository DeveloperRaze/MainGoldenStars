using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    //Forward/Backward input
    private float horizontalInput;
    //Steering left/Right input
    private float verticalInput;
    //Steer angle
    private float currentSteerAngle;
    //brake force
    private float currentbreakForce;
    //break bool
    private bool isBreaking;
    //Switch between keyboard/Touch input
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

    //Method to change input type
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
        FindObjectOfType<AudioManager>().Play("Gas");

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
            isBreaking = Input.GetKey(KeyCode.Space);
        }
    }

    private void HandleMotor()
    {
        //Handle engine torque / velocity and breaking
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;
        currentbreakForce = isBreaking ? breakForce : 0f;
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        //Apply brakeTorque to all wheels based on break force
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
        //Update wheel rotations based on UpdateSingleWheel method
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
        UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        //Local position and rotation variable
        Vector3 pos;
        Quaternion rot;
        //GameObject collider position and rotation
        wheelCollider.GetWorldPose(out pos, out rot);
        //Adjust trans
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}
