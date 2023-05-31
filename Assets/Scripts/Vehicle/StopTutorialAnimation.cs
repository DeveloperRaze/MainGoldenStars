using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTutorialAnimation : MonoBehaviour
{
    //This script will stop the flashing go button at start of game.
    [SerializeField] GameObject Gas;
    [SerializeField] GameObject Brake;
    [SerializeField] GameObject TurnLeft;
    [SerializeField] GameObject TurnRight;

    public bool TutorialBool = true;

    //Time in seconds = 0.
    float SecondsPassed = 0f;
    //Delay of 1 second.
    float DelayAmount = 1f;
    //Timer Float.
    protected float Timer;
    //Timer bool.
    public bool TimerOn = false;

    private void Start()
    {
        TimerOn = true;
        //Start Go animation on up button
        Gas.GetComponent<Animator>().enabled = true;
    }

    private void Update()
    {
        //If timer on then start counting.
        if (TimerOn == true)
        {
            Timer += Time.deltaTime;
        }
        //If timer greater than 1 second, set to 0
        if (Timer >= DelayAmount)
        {
            Timer = 0f;
            SecondsPassed++;
        }

        //Stop flash animation on up button
        if (SecondsPassed == 5)
        {
            Gas.GetComponent<Animator>().enabled = false;
        }

        //Start flash animation on stop button
        if (SecondsPassed == 7)
        {
            Brake.GetComponent<Animator>().enabled = true;
        }

        //Stop flash animation on stop button
        if (SecondsPassed == 12)
        {
            Brake.GetComponent<Animator>().enabled = false;
        }

        //Start flash animation on turn buttons
        if (SecondsPassed == 14)
        {
            TurnLeft.GetComponent<Animator>().enabled = true;
            TurnRight.GetComponent<Animator>().enabled = true;
        }

        //Stop flash animation on turn buttons
        if (SecondsPassed == 19)
        {
            TurnLeft.GetComponent<Animator>().enabled = false;
            TurnRight.GetComponent<Animator>().enabled = false;
        }

        //Destroy animator so does not replay on start
        if (SecondsPassed == 21)
        {
            DestroyAnims();
        }
    }

    private void DestroyAnims()
    {
        Destroy(this);
    }
}
