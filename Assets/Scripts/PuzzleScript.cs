using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuzzleScript : MonoBehaviour
{
    //If vehicle has tipped or inactive
    //This script has been attached to the car because of the collision script needing to access it?
    [SerializeField] private CanvasGroup characterUIGroup;

    [SerializeField] private TextMeshProUGUI characterText;
    [SerializeField] private TextMeshProUGUI ojectiveText;

    [SerializeField] public bool fadeIn = false;
        [SerializeField] public bool fadeOut = false;

    //Character text UI on the left side of screen.
    public Canvas CharacterCanvas;
    //Home, pause button, level star count top right corner of screen.
    public Canvas UICanvas;

    //Current level player is on
    public float currentLevel = 1.0f;
    float SecondsPassed = 0f;
    float DelayAmount = 1f;
    protected float Timer;
    public bool TimerOn = false;


    // Start is called before the first frame update
    void Start()
    {

        //Set text to story 1.
        characterText.text = "Can you find the number 2?";

        //Make Character text visible at start.
        ShowUI();

        //Hides the Character text after 3 seconds.
        Invoke(nameof(HideUI), 5);
    }

    // Update is called once per frame
    void Update()
    {

        CharacterTexts();
        FadeIn();

        Debug.Log("SecondsPassed" + SecondsPassed);
        //Set timer on to start counting.
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

        //This is the amount of time (10 seconds) the text displays for before disappearing.
        if (SecondsPassed >= 5)
        {
            HideUI();
            SecondsPassed = 0;
            TimerOn = false;
        }
    }

    //Show UI boolean true
    public void ShowUI()
    {
        fadeIn = true;
    }

    //Hide UI boolean true
    public void HideUI()
    {
        fadeOut = true;
    }

    //Called from collision script and activates on impact.
    public void NextLevel()
    {
        currentLevel++;
        TimerOn = true;
        ShowUI();
    }

    public void CharacterTexts()
    {

        if (currentLevel == 2f)
        {
            characterText.text = "Can you find the number 3?";
        }

        if (currentLevel == 3f)
        {
            characterText.text = "Can you find the number 4?";
        }

        if (currentLevel == 4f)
        {
            characterText.text = "Can you find the number 5?";
        }
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

    public void DisplayWrongObjectText()
    {
        ShowUI();
        TimerOn = true;

        characterText.text = "Oops! That's not quite right. Try again.";

    }

    //Level 1-1

    //If 1 is destroyed, get a star
    //If 1 is completed, set complete
    //If 1 is completed, move to next objective

    //Change text instruction
}
