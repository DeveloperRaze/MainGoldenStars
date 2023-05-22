using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    public static int starCount = 0;
    //Debug to find out why start 12 isn't being awarded.

    private void Update()
    {
        Debug.Log("startCount" + starCount);
    }
}
