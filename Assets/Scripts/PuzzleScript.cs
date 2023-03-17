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

    public FaderScript faderScript;

    //Character text UI on the left side of screen.
    public Canvas CharacterCanvas;
    //Home, pause button, level star count top right corner of screen.
    public Canvas UICanvas;

    //Current level player is on
    public float currentLevel = 1.0f;
    float secondsPassed = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //Set text to story 1.
        characterText.text = "Can you find the number 2?";
    }

    // Update is called once per frame
    void Update()
    {
        //Consider late update/Fixed update? what is cheaper in terms of cost.
        CharacterTexts();
    }

    public void NextLevel()
    {
        currentLevel++;
        //show current level in console
        Debug.Log("This is working");
    }

    public void CharacterTexts()
    {

        if (currentLevel == 2)
        {
            characterText.text = "Can you find the number 3?";
            characterUIGroup.GetComponent<FaderScript>().ShowUI();

            StartCoroutine(hideUI());

        }

        if (currentLevel == 3)
        {
            characterText.text = "Can you find the number 4?";
            characterUIGroup.GetComponent<FaderScript>().ShowUI();
            StartCoroutine(hideUI());
        }
    }

    IEnumerator hideUI()
    {
        yield return new WaitForSeconds(3);
        faderScript.fadeIn = false;
        faderScript.fadeOut = true;
    }

    //Level 1-1

    //If 1 is destroyed, get a star
    //If 1 is completed, set complete
    //If 1 is completed, move to next objective

    //Change text instruction
}
