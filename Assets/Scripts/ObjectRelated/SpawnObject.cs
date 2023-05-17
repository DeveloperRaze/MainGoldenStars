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

    //Variable for array
    public float Items = 0f;

    void Update()
    {
        //Debug value for what object to spawn
        Debug.Log("WhatObject" + Items);

        //float in seconds
        timePassed += Time.deltaTime;
    }

    public void InstantiateObjects()
    {

        //call a variable from another script - eg. number 2 or number 3 has been destroyed, then set that variable to be instantiated.
        //Select random item from index
        int randomIndex = Random.Range(0, letterObjects.Length);

        //Select random spawn position based on declared variable parameters
        Vector3 randomSpawnPosition = new Vector3(Random.Range(xValue, zValue), yValue, Random.Range(xValue, zValue));

        //Items 1 to 25 covers the eventuality of 1-20 and A-Z being instantiated from the array, with A being item 0 and Z being item 25.
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

        if (Items == 3)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[3], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 4)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[4], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 5)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[5], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 6)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[6], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 7)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[7], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 8)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[8], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 9)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[9], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 10)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[10], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 11)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[11], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 12)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[12], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 13)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[13], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 14)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[14], randomSpawnPosition, Quaternion.identity);
        }

        if (Items == 15)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[15], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 16)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[16], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 17)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[17], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 18)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[18], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 19)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[19], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 20)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[20], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 21)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[21], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 22)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[22], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 23)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[23], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 24)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[24], randomSpawnPosition, Quaternion.identity);
        }
        if (Items == 25)
        {
            //Instantiate chosen object at chosen random spawn position. //letterObjects can take a specific value (0-X) or randomIndex should random be needed.
            Instantiate(letterObjects[25], randomSpawnPosition, Quaternion.identity);
        }
    }
}
