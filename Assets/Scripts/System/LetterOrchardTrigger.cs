using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterOrchardTrigger : MonoBehaviour
{
    public SceneLoader SceneLoader;

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<WhatLevelScript>().ResetLevel();

        SceneLoader.LetterTreeScene();
    }
}
