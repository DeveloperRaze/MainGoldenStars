using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatLevelScript : MonoBehaviour
{
    public static int whatLevel = 1;

    //Start - Call the level the player is on.
    public void Update()
    {
        Debug.Log("WhatLevel" + whatLevel);

        //Sets the value of whatLevel based on the value of collisions.
        whatLevel = GetComponent<Collisions>().currentLevel;

        if (whatLevel == 2)
        {
            FindObjectOfType<AudioManager>().Play("Find_2");
        }
    }

    public void ResetLevel()
    {
        whatLevel = 1;
    }
}
