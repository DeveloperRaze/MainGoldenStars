using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTree : MonoBehaviour
{
    public Animator anim;

    public void SetTrigger()
    {
        anim.SetTrigger("RestoredLife");
    }
}
