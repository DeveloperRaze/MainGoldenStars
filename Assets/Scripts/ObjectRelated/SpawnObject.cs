using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] letterObjects;

    //X/Y=Z value
    float xValue = -45;
    float zValue = 45;
    //Y (Height) value
    float yValue = 100;
    //time in seconds
    float timePassed = 0f;

    void Update()
    {
        //float in seconds
        timePassed += Time.deltaTime;

        //Spawns 1 object every 5 seconds
        if (timePassed > 5f)
        {
            //Select random item from index
            int randomIndex = Random.Range(0, letterObjects.Length);

            //Select random spawn position based on parameters
            Vector3 randomSpawnPosition = new Vector3(Random.Range(xValue, zValue), yValue, Random.Range(xValue, zValue));

            //Instantiate chosen object at chosen random spawn position
            Instantiate(letterObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

            //Set timePassed back to 0.
            timePassed = 0f;
        }
    }
}
