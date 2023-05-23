using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puzzlescript6 : MonoBehaviour
{
    //This script has been attached to the car because of the collision script needing to access it?

    [SerializeField] private CanvasGroup characterUIGroup;
    [SerializeField] private CanvasGroup ObjectiveUIGroup;

    //Stars awarded to player.
    [SerializeField] private GameObject Star1;
    [SerializeField] private GameObject Star2;
    [SerializeField] private GameObject Star3;

    //Character and Objective texts.
    [SerializeField] private TextMeshProUGUI characterText;
    [SerializeField] private TextMeshProUGUI ojectiveText;

    //Fade in/Out for texts.
    [SerializeField] public bool fadeIn = false;
    [SerializeField] public bool fadeOut = false;
    //Tree Object.
    public TriggerTree triggerTree;
    //Camera Objects.
    public Camera mainCamera;
    public Camera secondCamera;

    //Character text UI on the left side of screen.
    public Canvas CharacterCanvas;
    //Home, pause button, level star count top right corner of screen.
    public Canvas UICanvas;

    //Current level player is on.
    public int currentLevel = 16;
    //Time in seconds = 0.
    float SecondsPassed = 0f;
    //Delay of 1 second.
    float DelayAmount = 1f;
    //Timer Float.
    protected float Timer;
    //Timer bool.
    public bool TimerOn = false;
    //Text Colour reference.
    public Color textColor;
    //SceneLoader.
    public SceneLoader SceneLoader;

    void Start()
    {
        //Enable main camera.
        mainCamera.enabled = true;
        secondCamera.enabled = false;

        //Set text to story.
        characterText.text = "Can you find the number 17?";

        //Make Character text visible at start.
        ShowUI();

        //Hides the Character text after 3 seconds.
        Invoke(nameof(HideUI), 5);

        //Set the color to match the active game object.
        ojectiveText.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        CharacterTexts();
        FadeIn();

        Debug.Log("SecondsPassed" + SecondsPassed);
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

        //This is how long the text displays before disappearing (10 seconds).
        if (SecondsPassed >= 5)
        {
            HideUI();
            SecondsPassed = 0;
            TimerOn = false;
        }
    }

    //Show UI boolean (true)
    public void ShowUI()
    {
        fadeIn = true;
    }

    //Hide UI boolean (true)
    public void HideUI()
    {
        fadeOut = true;
    }

    //Called from collision script attached to van and activates on impact.
    public void NextLevel()
    {
        //increase level, turn on timer and show UI.
        currentLevel++;
        TimerOn = true;
        ShowUI();
    }

    public void CharacterTexts()
    {
        //Text based on level player is on.
        if (currentLevel == 17)
        {
            //Set text to second objective
            characterText.text = "Can you find the number 17?";
            //Objective UI changes to match the objective.
            ojectiveText.text = "17";
            ojectiveText.color = Color.magenta;
        }

        if (currentLevel == 18)
        {
            //Award the first star
            Star1.SetActive(true);
            AddStar16();
            characterText.text = "Can you find the number 18?";

            //Objective UI changes to match the objective.
            ojectiveText.text = "18";
            ojectiveText.color = Color.black;
        }

        if (currentLevel == 19)
        {
            Star2.SetActive(true);
            AddStar17();
            characterText.text = "Can you find the number 19?";

            //Objective UI changes to match the objective.
            ojectiveText.text = "19";
            ojectiveText.color = Color.blue;
        }

        if (currentLevel == 20)
        {
            characterText.text = "Can you find the number 20?";

            //Objective UI changes to match the objective.
            ojectiveText.text = "20";
            ojectiveText.color = Color.blue;
        }

        if (currentLevel == 21)
        {
            mainCamera.enabled = false;
            secondCamera.enabled = true;
            Star3.SetActive(true);
            AddStar18();

            //Objective UI changes to match the objective.d
            triggerTree.SetTrigger();

            characterText.text = "Well done! We have finished all the levels!";

            // Needs to call coroutine for fade in
            if (SecondsPassed >= 4f)
            {
                GetComponent<WhatLevelScript>().ResetLevel();
                SceneLoader.ReturnToLevelSelect();
            }
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

    //If Player crashes in to wrong object, show text as wrong object.
    public void DisplayWrongObjectText()
    {
        ShowUI();
        TimerOn = true;
        characterText.text = "Oops! Try again.";
    }

    public void AddStar16()
    {
        if (GameSession.starCount == 15)
        {
            GameSession.starCount = 16;
        }
    }

    public void AddStar17()
    {
        if (GameSession.starCount == 16)
        {
            GameSession.starCount = 17;
        }
    }

    public void AddStar18()
    {
        if (GameSession.starCount == 17)
        {
            GameSession.starCount = 18;
        }
    }
}
