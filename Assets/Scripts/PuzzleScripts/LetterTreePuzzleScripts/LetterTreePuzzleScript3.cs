using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterTreePuzzleScript3 : MonoBehaviour
{
    [SerializeField] private CanvasGroup characterUIGroup;
    [SerializeField] private CanvasGroup ObjectiveUIGroup;

    // In-Level Stars awarded to player.
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
    public float currentLevel = 11;
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

    public float transitionTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //Enable main camera.
        mainCamera.enabled = true;
        secondCamera.enabled = false;

        currentLevel = 11;


        //Set text to story.
        characterText.text = "Can you find the letter K?";

        //Make Character text visible at start.
        ShowUI();

        //Hides the Character text after 3 seconds.
        Invoke(nameof(HideUI), 5);

        //Set the color to match the active game object.
        ojectiveText.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        CharacterTexts();
        FadeIn();

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
        if (currentLevel == 12)
        {
            //Award the first star
            Star1.SetActive(true);
            AddStar19();

            //Set text to second objective
            characterText.text = "Can you find the letter L?";
            //Objective UI changes to match the objective.
            ojectiveText.text = "L";
            ojectiveText.color = Color.green;
        }

        if (currentLevel == 13)
        {
            characterText.text = "Can you find the letter M?";
            //Objective UI changes to match the objective.
            ojectiveText.text = "M";
            ojectiveText.color = Color.red;
        }

        if (currentLevel == 14)
        {
            Star2.SetActive(true);
            AddStar20();
            characterText.text = "Can you find the letter N?";

            //Objective UI changes to match the objective.
            ojectiveText.text = "N";
            ojectiveText.color = Color.yellow;
        }

        if (currentLevel == 15)
        {
            characterText.text = "Can you find the letter O?";
            //Objective UI changes to match the objective.
            ojectiveText.text = "O";
            ojectiveText.color = Color.blue;
        }

        if (currentLevel == 16)
        {
            Star3.SetActive(true);
            AddStar21();

            mainCamera.enabled = false;
            secondCamera.enabled = true;
            characterText.text = "Well done! Let's go to the next level.";

            triggerTree.SetTrigger();

            if (SecondsPassed >= 4f)
            {
                SceneLoader.NextScene();
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

    public void AddStar19()
    {
        if (GameSessionHandler.starCount == 24)
        {
            GameSessionHandler.starCount = 25;
        }
    }

    public void AddStar20()
    {
        if (GameSessionHandler.starCount == 25)
        {
            GameSessionHandler.starCount = 26;
        }
    }

    public void AddStar21()
    {
        if (GameSessionHandler.starCount == 26)
        {
            GameSessionHandler.starCount = 27;
        }
    }
}