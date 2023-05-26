using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatLevelScript : MonoBehaviour
{
    public static int whatLevel = 1;

    //Start - Call the level the player is on.
    //This script is to reset the level back to 1 when the player enters the letter or number tree. 
    //Iif they quit at level 5, and have earned 5 stars, reset the level back to 1 so they start at level 1.
    public void Update()
    {
        
        //Sets the value of whatLevel based on the value of collisions.
        whatLevel = GetComponent<Collisions>().currentLevel;

        //There is an error when trying to fix the null reference expection. I need assign the value of whatLevel to the value of current level but don't know how to do it without the error 
    }

    public void ResetLevel()
    {
        whatLevel = 1;
    }
}
