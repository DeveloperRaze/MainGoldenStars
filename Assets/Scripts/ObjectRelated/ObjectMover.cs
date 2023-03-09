using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float fallSpeed = 8.0f;

    public bool landingFalse;

    private void Start()
    {
        landingFalse = false;
    }


    private void fallingDown()
    {
        if (landingFalse == false)
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        landingFalse = true;
    }

}
