using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterOrchardTrigger : MonoBehaviour
{
    // Triggers for Orchard 1 & 2.
    public void OnTriggerEnter(Collider other)
    {
        GetComponent<SceneLoader>().LetterTreeScene();
    }
}
