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
    [SerializeField] private CanvasGroup ObjectiveUIGroup;

    [SerializeField] private GameObject Star1;
    [SerializeField] private GameObject Star2;
    [SerializeField] private GameObject Star3;

    [SerializeField] private TextMeshProUGUI characterText;
    [SerializeField] private TextMeshProUGUI ojectiveText;

    [SerializeField] public bool fadeIn = false;
    [SerializeField] public bool fadeOut = false;

    public TriggerTree triggerTree;

    public Camera mainCamera;
    public Camera secondCamera;

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

    public Color textColor;


    // Start is called before the first frame update
    void Start()
    {
        //Enable main camera.
        mainCamera.enabled = true;
        secondCamera.enabled = false;

        //Set text to story
        characterText.text = "Can you find the number 1?";

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

        //This is how long the text displays before disappearing (10 seconds) .
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
        if (currentLevel == 2f)
        {
            //Award the first star
            Star1.SetActive(true);
            //Set text to second objective
            characterText.text = "Can you find the number 2?";
            ojectiveText.text = "2";
            ojectiveText.color = Color.yellow;

        }

        if (currentLevel == 3f)
        {
            Star2.SetActive(true);
            characterText.text = "Can you find the number 3?";
            ojectiveText.text = "3";
            ojectiveText.color = Color.blue;

        }

        if (currentLevel == 4f)
        {
            mainCamera.enabled = false;
            secondCamera.enabled = true;

            triggerTree.SetTrigger();
            Star3.SetActive(true);
            characterText.text = "Well done! Let's go to the next level.";
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

        characterText.text = "Oops! Try again.";

    }

    //Level 1-1

    //If 1 is destroyed, get a star
    //If 1 is completed, set complete
    //If 1 is completed, move to next objective

    //Change text instruction
}
