using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private float currentLevel = 1.0f;

    //Detect collisions between the GameObjects with Colliders attached
    public void OnCollisionEnter(Collision collision)
    {
        //Level 1-1 (Change to 1)
        //Check for a match with the specified name on any GameObject that collides with your GameObject

        if (collision.gameObject.name == "2(Clone)" && currentLevel == 1)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "3(Clone)" && currentLevel == 1)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "4(Clone)" && currentLevel == 1)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

        }

        // Level 1-2

        if (collision.gameObject.name == "2(Clone)" && currentLevel == 2)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "3(Clone)" && currentLevel == 2)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "4(Clone)" && currentLevel == 2)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        // Level 1-3

        if (collision.gameObject.name == "2(Clone)" && currentLevel == 3)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "3(Clone)" && currentLevel == 2)
        {
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "4(Clone)" && currentLevel == 2)
        {
            //If correct object was destroyed then move to next object.
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }
    }
}
