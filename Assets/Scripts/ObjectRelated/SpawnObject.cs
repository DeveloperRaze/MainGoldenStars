using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] letterObjects;

    //X/Z value border for spawning objects 
    float xValue = -50;
    float zValue = 50;
    //Y (Height) value. Lower = Closer to the floor. 
    float yValue = 75;
    //time in seconds for counter.
    float timePassed = 0f;


    public float Items = 0f;


    //Debug value for what object to spawn

    void Update()
    {
        //Debug value for what object to spawn
        Debug.Log("WhatObject" + Items);

        //float in seconds
        timePassed += Time.deltaTime;

        //Spawns 1 object every 5 seconds
        //if (timePassed > 5f)
        //{
            //Select random item from index
        //    int randomIndex = Random.Range(0, letterObjects.Length);

            //Select random spawn position based on parameters
        //    Vector3 randomSpawnPosition = new Vector3(Random.Range(xValue, zValue), yValue, Random.Range(xValue, zValue));

            //Instantiate chosen object at chosen random spawn position
        //    Instantiate(letterObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

            //Set timePassed back to 0.
        //    timePassed = 0f;
        //}
    }

    public void InstantiateObjects()
    {

        //To correctly call a variable from another script - eg. number 2 or number 3 has fallen, then set that variable to be instantiated.

        //Select random item from index
        int randomIndex = Random.Range(0, letterObjects.Length);

        //Select random spawn position based on parameters
        Vector3 randomSpawnPosition = new Vector3(Random.Range(xValue, zValue), yValue, Random.Range(xValue, zValue));

        if (Items == 1)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[1], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 2)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[2], randomSpawnPosition, Quaternion.identity);
        }
    }
}
