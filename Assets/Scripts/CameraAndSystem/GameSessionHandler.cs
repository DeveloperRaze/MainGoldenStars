using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;


public class GameSessionHandler : MonoBehaviour
{
    public float StarCount = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Theme");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("StarCount" + StarCount);
    }

}
