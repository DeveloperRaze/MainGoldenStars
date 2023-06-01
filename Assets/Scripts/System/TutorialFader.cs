using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialFader : MonoBehaviour
{
    [SerializeField] private CanvasGroup characterUIGroup;
    [SerializeField] private TextMeshProUGUI ojectiveText;

    [SerializeField] public bool fadeIn = false;
    [SerializeField] public bool fadeOut = false; 

    public float Tutorialnumber = 1;
    public bool isPlaying;

    //Time in seconds = 0.
    float SecondsPassed = 0f;
    //Delay of 1 second.
    float DelayAmount = 1f;
    //Timer Float.
    protected float Timer;
    //Timer bool.
    public bool TimerOn = false;

    //Start counter
    public void StartTimer()
    {
        if (isPlaying == false)
        {
            isPlaying = true;
        }
    }

    public void start()
    {
        HideUI();
    }

    public void Update()
    {
        FadeIn();
        if (isPlaying == true)
        {
            StartTutorial();
        }
    }

    public void StartTutorial()
    {
        Tutorialnumber = 1;
        TimerOn = true;

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

        if (SecondsPassed == 1)
        {
            ShowUI();
        }

        if (SecondsPassed == 5)
        {
            HideUI();
        }

        if (SecondsPassed == 7)
        {
            Tutorialnumber = 2;
            ShowUI();
        }

        if (SecondsPassed == 12)
        {
            HideUI();
        }

        if (SecondsPassed == 14)
        {
            Tutorialnumber = 3;
            ShowUI();
        }

        //This is how long the text displays before disappearing (10 seconds).
        if (SecondsPassed == 19)
        {
            HideUI();
        }

        //Remove the script after tutorial has played.
        if (SecondsPassed == 21)
        {
            DestroyFader();
        }

        if (Tutorialnumber == 1)
        {
            ojectiveText.text = "Press the UP button to go forwards.";
        }

        if (Tutorialnumber == 2)
        {
            ojectiveText.text = "Press the Down button to stop or go backwards.";
        }

        if (Tutorialnumber == 3)
        {
            TimerOn = false;
            isPlaying = false;
            ojectiveText.text = "Press the Left and Right buttons to turn.";
        }
    }

    public void ShowUI()
    {
        fadeIn = true;
    }

    public void HideUI()
    {
        fadeOut = true;
    }

    public void FadeIn()
    {
        //If fadeIn is true.
        if (fadeIn)
        {
            //And the UI group is hidden.
            if (characterUIGroup.alpha < 1)
            {
                //Fade alpha by Time.deltaTime.
                characterUIGroup.alpha += Time.deltaTime;
                //and if alpha is >=1
                if (characterUIGroup.alpha >= 1)
                {
                    //Stop the fade in effect.
                    fadeIn = false;
                }
            }
        }

        //If fadeOut is true.
        if (fadeOut)
        {
            //And the UI group is visible.
            if (characterUIGroup.alpha >= 0)
            {
                //Fade alpha - Time.deltaTime.
                characterUIGroup.alpha -= Time.deltaTime;
                //and if alpha is 0
                if (characterUIGroup.alpha == 0)
                {
                    //stop the fade out effect.
                    fadeOut = false;
                }
            }
        }
    }

    private void DestroyFader()
    {
        Destroy(this);
    }
}
