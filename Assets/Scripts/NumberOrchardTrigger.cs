using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOrchardTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<SceneLoader>().NextScene();
    }
}
