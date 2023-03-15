using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuzzleScript : MonoBehaviour
{
    //If vehicle has tipped or inactive    
    [SerializeField] private TextMeshProUGUI characterText;
    [SerializeField] private TextMeshProUGUI ojectiveText;

    //Character text UI on the left side of screen.
    public Canvas CharacterCanvas;

    public float currentLevel = 1.0f;

    //Home, pause button, level star count top right corner of screen.
    public Canvas UICanvas;

    // Start is called before the first frame update
    void Start()
    {
        //Set text to story 1.
    }

    // Update is called once per frame
    void Update()
    {
        //Consider late update/Fixed update? what is cheaper in terms of cost.
    }

    public void nextLevel()
    {
        currentLevel++;
    }

    public void CharacterTexts()
    {
        if (currentLevel == 1)
        {
            characterText.text = "Can you find the number 1?";
        }

        if (currentLevel == 2)
        {
            characterText.text = "Can you find the number 2?";
        }

        if (currentLevel == 3)
        {
            characterText.text = "Can you find the number 3?";
        }
    }


    //Level 1-1

    //If 1 is destroyed, get a star
    //If 1 is completed, set complete
    //If 1 is completed, move to next objective

    //Change text instruction
}
