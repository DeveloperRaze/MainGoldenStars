using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOrchardTrigger : MonoBehaviour
{
    public SceneLoader SceneLoader;

   private void OnTriggerEnter(Collider other)
   {
       SceneLoader.NumberTreeScene();
   }
}
