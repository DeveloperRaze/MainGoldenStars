using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticNumberClass: MonoBehaviour
{
    public static int carValue = 0;

    public void Update()
    {
        Debug.Log("Hello" + carValue);
    }
}

