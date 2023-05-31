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

    private bool FirstTutorial = true;
    private bool SecondTutorial = false;

    public void Start()
    {
        //Make Character text visible at start.
        if (FirstTutorial == true)
        {
            ShowUI();
            ojectiveText.text = "Press the UP button to go forwards.";
        }

        //Hides the Character text after 4 seconds.
        Invoke(nameof(HideUI), 4);
    }

    public void ShowUI()
    {
        fadeIn = true;
    }

    public void HideUI()
    {
        fadeOut = true;
    }

    public void Update()
    {
        FadeIn();
        Invoke(nameof(ShowSecondTutorial), 6);
        Invoke(nameof(HideSecondTutorial), 10);
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

    public void ShowSecondTutorial()
    {
        FirstTutorial = false;
        SecondTutorial = true;


        if (SecondTutorial == true)
        {
            ShowUI();
            ojectiveText.text = "Press the DOWN button to stop.";
        }
    }

    private void HideSecondTutorial()
    {
        fadeIn = false;
        HideUI();
        SecondTutorial = false;
        Invoke(nameof(DestroyFader), 5);
    }

    private void DestroyFader()
    {
        Destroy(this);
    }
}
