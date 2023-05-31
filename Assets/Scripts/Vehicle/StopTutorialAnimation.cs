using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTutorialAnimation : MonoBehaviour
{
    //This script will stop the flashing go button at start of game.
    [SerializeField] GameObject Gas;
    [SerializeField] GameObject Brake;

    public bool TutorialBool = true;

    private void Update()
    {
        if (TutorialBool == true)
        {
            //Stops the flashing object after 4 seconds.
            Invoke(nameof(StopGoAnimations), 4);

            //Starts the second animation - Brake flash, after 6 seconds.
            Invoke(nameof(BrakeDelay), 6);
        }
    }

    private void BrakeDelay()
    {
        Brake.GetComponent<Animator>().enabled = true;
        Invoke(nameof(StopBrakeAnimations), 7);
    }

    private void StopGoAnimations()
    {
        Gas.GetComponent<Animator>().enabled = false;
        TutorialBool = false;
    }

    private void StopBrakeAnimations()
    {
        Brake.GetComponent<Animator>().enabled = false;

    }
}
