using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public float currentLevel = 1.0f;

    public Puzzlescript2 Script2;
    public PuzzleScript3 Script3;

    public void Start()
    {
        GetComponent<Puzzlescript2>();
        currentLevel = GetComponent<Puzzlescript2>().currentLevel;
    }

    //Detect collisions between the GameObjects with Colliders attached
    public void OnCollisionEnter(Collision collision)
    {
        //Level 1-1 (Change to 1)
        //Check for a match with the specified name on any GameObject that collides with Vehicle

        // If gameobject != "1"...

        if (collision.gameObject.name == "1" && currentLevel == 1)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "2" && currentLevel == 1)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "3" && currentLevel == 1)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        // Level 1-2
        if (collision.gameObject.name == "1" && currentLevel == 2)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "2" && currentLevel == 2)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "3" && currentLevel == 2)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        // Level 1-3
        if (collision.gameObject.name == "1" && currentLevel == 3)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "2" && currentLevel == 3)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        //This will finish level 1-1, moving on to level 1-2. 
        if (collision.gameObject.name == "3" && currentLevel == 3)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        // Level 1-4

        if (collision.gameObject.name == "4" && currentLevel == 4)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<Puzzlescript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "5" && currentLevel == 4)
        {
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "6" && currentLevel == 4)
        {
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        // Level 1-5
        if (collision.gameObject.name == "4" && currentLevel == 5)
        {
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "5" && currentLevel == 5)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<Puzzlescript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "6" && currentLevel == 5)
        {
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        // Level 1-6
        if (collision.gameObject.name == "4" && currentLevel == 6)
        {
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "5" && currentLevel == 6)
        {
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "6" && currentLevel == 6)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<Puzzlescript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        // Level 1-7
        if (collision.gameObject.name == "7" && currentLevel == 7)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "8" && currentLevel == 7)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "9" && currentLevel == 7)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "10" && currentLevel == 7)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        //Level 1-8
        if (collision.gameObject.name == "7" && currentLevel == 8)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "8" && currentLevel == 8)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "9" && currentLevel == 8)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "10" && currentLevel == 8)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        //Level 1-9
        if (collision.gameObject.name == "7" && currentLevel == 9)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "8" && currentLevel == 9)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "9" && currentLevel == 9)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "10" && currentLevel == 9)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        //Level 1-10
        if (collision.gameObject.name == "7" && currentLevel == 10)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "8" && currentLevel == 10)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "9" && currentLevel == 10)
        {
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "10" && currentLevel == 10)
        {
            //  Either end scene or continue to 1-11?
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }
    }
}
