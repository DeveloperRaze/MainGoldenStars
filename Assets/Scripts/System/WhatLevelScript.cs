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
        whatLevel = GetComponent<Collisions>().currentLevel;
    }
}
