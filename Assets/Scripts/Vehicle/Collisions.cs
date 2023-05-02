using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public float currentLevel = 1.0f;

    public Puzzlescript2 Script2;
    public PuzzleScript3 Script3;
    public SpawnObject Spawner;
    private bool InstantiateBool;

    public void Start()
    {
        GetComponent<Puzzlescript2>();
        currentLevel = GetComponent<Puzzlescript2>().currentLevel;
        InstantiateBool = false;
    }

    public void Update()
    {
        //Debug code for fun to instantiate objects.
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Spawner.InstantiateObjects();
        }
    }

    //Detect collisions between the GameObjects with Colliders attached
    public void OnCollisionEnter(Collision collision)
    {
        //Level 1-1 (Change to 1)
        //Check for a match with the specified name on any GameObject that collides with Vehicle

        // If gameobject != "1"...

        if (collision.gameObject.name == "1(Clone)" && currentLevel == 1)
        {
            //If correct object was destroyed then move to next object.
            //Increase level by 1
            //Destroy correct gameObject.

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "2(Clone)" && currentLevel == 1)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 2 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 1;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "3(Clone)" && currentLevel == 1)
        {
            //If Instantiate is true (to limit event to one occurance)
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            //Set text component
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            //Destroy object

            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 1-2
        if (collision.gameObject.name == "1(Clone)" && currentLevel == 2)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 0;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "2(Clone)" && currentLevel == 2)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "3(Clone)" && currentLevel == 2)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 1-3
        if (collision.gameObject.name == "1(Clone)" && currentLevel == 3)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 0;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "2(Clone)" && currentLevel == 3)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 1;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }
 
        if (collision.gameObject.name == "3(Clone)" && currentLevel == 3)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        // Level 1-4

        if (collision.gameObject.name == "4(Clone)" && currentLevel == 4)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "5(Clone)" && currentLevel == 4)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 4;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "6(Clone)" && currentLevel == 4)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 5;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 1-5
        if (collision.gameObject.name == "4(Clone)" && currentLevel == 5)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 3;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "5(Clone)" && currentLevel == 5)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "6(Clone)" && currentLevel == 5)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 5;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 1-6
        if (collision.gameObject.name == "4(Clone)" && currentLevel == 6)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 3;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "5(Clone)" && currentLevel == 6)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 4;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "6(Clone)" && currentLevel == 6)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        // Level 1-7
        if (collision.gameObject.name == "7(Clone)" && currentLevel == 7)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "8(Clone)" && currentLevel == 7)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
            if (InstantiateBool == true)
            {
                Spawner.Items = 7;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "9(Clone)" && currentLevel == 7)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
            if (InstantiateBool == true)
            {
                Spawner.Items = 8;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "10(Clone)" && currentLevel == 7)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
            if (InstantiateBool == true)
            {
                Spawner.Items = 9;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-8
        if (collision.gameObject.name == "7(Clone)" && currentLevel == 8)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
            if (InstantiateBool == true)
            {
                Spawner.Items = 6;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "8(Clone)" && currentLevel == 8)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "9(Clone)" && currentLevel == 8)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 8;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "10(Clone)" && currentLevel == 8)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
            if (InstantiateBool == true)
            {
                Spawner.Items = 9;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-9
        if (collision.gameObject.name == "7(Clone)" && currentLevel == 9)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 6;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "8(Clone)" && currentLevel == 9)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 7;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "9(Clone)" && currentLevel == 9)
        {
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "10(Clone)" && currentLevel == 9)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);
            if (InstantiateBool == true)
            {
                Spawner.Items = 9;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-10
        if (collision.gameObject.name == "7(Clone)" && currentLevel == 10)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 6;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "8(Clone)" && currentLevel == 10)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 7;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "9(Clone)" && currentLevel == 10)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<PuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 8;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "10(Clone)" && currentLevel == 10)
        {
            //  Either end scene or continue to 1-11?
            //If correct object was destroyed then move to next object.
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");

            GetComponent<PuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }
    }
}
