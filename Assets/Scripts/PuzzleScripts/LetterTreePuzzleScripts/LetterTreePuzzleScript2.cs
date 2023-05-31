using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterTreePuzzleScript2 : MonoBehaviour
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
    public float currentLevel = 6;
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
        GetComponent<GameSession>();

        currentLevel = 6;

        //Set text to story.
        characterText.text = "Can you find the letter F?";

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
        if (currentLevel == 7f)
        {
            //Award the first star
            Star1.SetActive(true);
            AddStar19();

            //Set text to second objective
            characterText.text = "Can you find the letter G?";
            //Objective UI changes to match the objective.
            ojectiveText.text = "G";
            ojectiveText.color = Color.yellow;
        }

        if (currentLevel == 8f)
        {
            characterText.text = "Can you find the letter H?";
            //Objective UI changes to match the objective.
            ojectiveText.text = "H";
            ojectiveText.color = Color.blue;
        }

        if (currentLevel == 9f)
        {
            Star2.SetActive(true);
            AddStar20();
            characterText.text = "Can you find the letter I?";

            //Objective UI changes to match the objective.
            ojectiveText.text = "I";
            ojectiveText.color = Color.blue;
        }

        if (currentLevel == 10f)
        {
            characterText.text = "Can you find the letter J?";
            //Objective UI changes to match the objective.
            ojectiveText.text = "J";
            ojectiveText.color = Color.blue;
        }

        if (currentLevel == 11f)
        {
            Star3.SetActive(true);
            AddStar21();

            mainCamera.enabled = false;
            secondCamera.enabled = true;
            characterText.text = "That's all 5 letters found. Let's go to the next level.";

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
        if (GameSessionHandler.starCount == 21)
        {
            GameSessionHandler.starCount = 22;
        }
    }

    public void AddStar20()
    {
        if (GameSessionHandler.starCount == 22)
        {
            GameSessionHandler.starCount = 23;
        }
    }

    public void AddStar21()
    {
        if (GameSessionHandler.starCount == 23)
        {
            GameSessionHandler.starCount = 24;
        }
    }
}
