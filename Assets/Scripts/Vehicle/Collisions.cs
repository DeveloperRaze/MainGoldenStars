using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int currentLevel = 1;
    public SpawnObject Spawner;
    private bool InstantiateBool;

    public void Start()
    {
        currentLevel = WhatLevelScript.whatLevel;
    }

    //Detect collisions between the Number Tree GameObjects with Colliders attached
    public void OnCollisionEnter(Collision collision)
    {
        //Level 1-1 Number tree count 1-10. (1-3
        //Check for a match with the specified name on any GameObject that collides with Vehicle

        // If gameobject != "1"...

        if (collision.gameObject.name == "1(Clone)" && currentLevel == 1)
        {
            //If correct object was destroyed then move to next object.
            //Increase level by 1
            //Destroy correct gameObject. 
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "2(Clone)" && currentLevel == 1)
        {
            FindObjectOfType<AudioManager>().Play("Oops");
            GetComponent<PuzzleScript>().DisplayWrongObjectText();

            InstantiateBool = true;
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
            FindObjectOfType<AudioManager>().Play("Oops");
            GetComponent<PuzzleScript>().DisplayWrongObjectText();

            InstantiateBool = true;
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 1-2 (2)
        if (collision.gameObject.name == "1(Clone)" && currentLevel == 2)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("Oops");
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
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "3(Clone)" && currentLevel == 2)
        {
            FindObjectOfType<AudioManager>().Play("Oops");
            InstantiateBool = true;
            GetComponent<PuzzleScript>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 1-3 (3)
        if (collision.gameObject.name == "1(Clone)" && currentLevel == 3)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("Oops");
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
            FindObjectOfType<AudioManager>().Play("Oops");
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
            
            GetComponent<PuzzleScript>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        // Level 1-4 (numbers 4-6) (4)

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

        // Level 1-5 (5)
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

        // Level 1-6 (6)
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

        // Level 1-7 (number 7-10) (7)
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

        //Level 1-8 (8)
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

        //Level 1-9 (9)
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

        //Level 1-10 (10)
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

        //Level 1-11 - (Numbers 11-13) (11)
        if (collision.gameObject.name == "11(Clone)" && currentLevel == 11)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript4>().NextLevel();

            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "12(Clone)" && currentLevel == 11)
        {
            GetComponent<Puzzlescript4>().DisplayWrongObjectText();
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            InstantiateBool = true;
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Debug.Log("Working");
                //Spawn number 12
                Spawner.Items = 11;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "13(Clone)" && currentLevel == 11)
        {
            GetComponent<Puzzlescript4>().DisplayWrongObjectText();
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn number 13
                Spawner.Items = 12;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-12 (12)
        if (collision.gameObject.name == "11(Clone)" && currentLevel == 12)
        {
            GetComponent<Puzzlescript4>().DisplayWrongObjectText();
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            InstantiateBool = true;
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Debug.Log("Working");
                //Spawn number 11
                Spawner.Items = 10;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "12(Clone)" && currentLevel == 12)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript4>().NextLevel();

            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "13(Clone)" && currentLevel == 12)
        {
            GetComponent<Puzzlescript4>().DisplayWrongObjectText();
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn number 13
                Spawner.Items = 12;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-13 (13)
        if (collision.gameObject.name == "11(Clone)" && currentLevel == 13)
        {
            GetComponent<Puzzlescript4>().DisplayWrongObjectText();
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            InstantiateBool = true;
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Debug.Log("Working");
                //Spawn number 11
                Spawner.Items = 10;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "12(Clone)" && currentLevel == 13)
        {
            GetComponent<Puzzlescript4>().DisplayWrongObjectText();
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn number 12
                Spawner.Items = 11;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "13(Clone)" && currentLevel == 13)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript4>().NextLevel();

            currentLevel++;
            Destroy(collision.gameObject);
        }


        //Level 1-14 (Numbers 14-16) (14)
        if (collision.gameObject.name == "14(Clone)" && currentLevel == 14)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript5>().NextLevel();

            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "15(Clone)" && currentLevel == 14)
        {
            GetComponent<Puzzlescript5>().DisplayWrongObjectText();
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            InstantiateBool = true;
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Debug.Log("Working");
                //Spawn number 15
                Spawner.Items = 14;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "16(Clone)" && currentLevel == 14)
        {
            GetComponent<Puzzlescript5>().DisplayWrongObjectText();
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn number 16
                Spawner.Items = 15;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-15 (15)
        if (collision.gameObject.name == "14(Clone)" && currentLevel == 15)
        {
            GetComponent<Puzzlescript5>().DisplayWrongObjectText();
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            InstantiateBool = true;
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Debug.Log("Working");
                //Spawn number 14
                Spawner.Items = 13;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "15(Clone)" && currentLevel == 15)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<Puzzlescript5>().NextLevel();

            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "16(Clone)" && currentLevel == 15)
        {
            GetComponent<Puzzlescript5>().DisplayWrongObjectText();
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn number 16
                Spawner.Items = 15;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-16 (16)
        if (collision.gameObject.name == "14(Clone)" && currentLevel == 16)
        {
            GetComponent<Puzzlescript5>().DisplayWrongObjectText();
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            InstantiateBool = true;
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Debug.Log("Working");
                //Spawn number 14
                Spawner.Items = 13;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "15(Clone)" && currentLevel == 16)
        {
            GetComponent<Puzzlescript5>().DisplayWrongObjectText();
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn number 15
                Spawner.Items = 14;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "16(Clone)" && currentLevel == 16)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            currentLevel++;
            Destroy(collision.gameObject);

            GetComponent<Puzzlescript5>().NextLevel();
        }


        //Level 1-17 (numbers 17-20) (17)
        if (collision.gameObject.name == "17(Clone)" && currentLevel == 17)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            currentLevel++;
            Destroy(collision.gameObject);
            GetComponent<Puzzlescript6>().NextLevel();
        }

        if (collision.gameObject.name == "18(Clone)" && currentLevel == 17)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 18
                Spawner.Items = 17;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "19(Clone)" && currentLevel == 17)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 19
                Spawner.Items = 18;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "20(Clone)" && currentLevel == 17)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 20
                Spawner.Items = 19;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        //Level 1-18 (18)
        if (collision.gameObject.name == "17(Clone)" && currentLevel == 18)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 17
                Spawner.Items = 16;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "18(Clone)" && currentLevel == 18)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            currentLevel++;
            Destroy(collision.gameObject);
            GetComponent<Puzzlescript6>().NextLevel();
        }

        if (collision.gameObject.name == "19(Clone)" && currentLevel == 18)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 19
                Spawner.Items = 18;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "20(Clone)" && currentLevel == 18)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 20
                Spawner.Items = 19;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        //Level 1-19 (19)
        if (collision.gameObject.name == "17(Clone)" && currentLevel == 19)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 17
                Spawner.Items = 16;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "18(Clone)" && currentLevel == 19)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 18
                Spawner.Items = 17;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "19(Clone)" && currentLevel == 19)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            currentLevel++;
            Destroy(collision.gameObject);
            GetComponent<Puzzlescript6>().NextLevel();
        }

        if (collision.gameObject.name == "20(Clone)" && currentLevel == 19)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 20
                Spawner.Items = 19;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        //Level 1-20 (20)
        if (collision.gameObject.name == "17(Clone)" && currentLevel == 20)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 17
                Spawner.Items = 16;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "18(Clone)" && currentLevel == 20)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 18
                Spawner.Items = 17;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "19(Clone)" && currentLevel == 20)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<Puzzlescript6>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                //Spawn 20
                Spawner.Items = 18;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "20(Clone)" && currentLevel == 20)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            currentLevel++;
            Destroy(collision.gameObject);
            GetComponent<Puzzlescript6>().NextLevel();
        }      




        // Level 2-1 (A-E) A
        if (collision.gameObject.name == "A(Clone)" && currentLevel == 1)
        {
            //If correct object was destroyed then move to next object.
            //Increase level by 1
            //Destroy correct gameObject.

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript1>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "B(Clone)" && currentLevel == 1)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 2 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 1;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "C(Clone)" && currentLevel == 1)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "D(Clone)" && currentLevel == 1)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 3;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "E(Clone)" && currentLevel == 1)
        {
            //If Instantiate is true (to limit event to one occurance)
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            //Set text component
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            //Destroy object

            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 4;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-2 (A-E) B
        if (collision.gameObject.name == "A(Clone)" && currentLevel == 2)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 2 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 0;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "B(Clone)" && currentLevel == 2)
        {
            //If correct object was destroyed then move to next object.
            //Increase level by 1
            //Destroy correct gameObject.

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript1>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "C(Clone)" && currentLevel == 2)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "D(Clone)" && currentLevel == 2)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 3;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "E(Clone)" && currentLevel == 2)
        {
            //If Instantiate is true (to limit event to one occurance)
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            //Set text component
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            //Destroy object

            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 4;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-3 (A-E) C
        if (collision.gameObject.name == "A(Clone)" && currentLevel == 3)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 2 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 0;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "B(Clone)" && currentLevel == 3)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 1;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "C(Clone)" && currentLevel == 3)
        {
            //If correct object was destroyed then move to next object.
            //Increase level by 1
            //Destroy correct gameObject.

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript1>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "D(Clone)" && currentLevel == 3)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 3;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "E(Clone)" && currentLevel == 3)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 4;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-4 (A-E) D
        if (collision.gameObject.name == "A(Clone)" && currentLevel == 4)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 2 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 0;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "B(Clone)" && currentLevel == 4)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 1;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "C(Clone)" && currentLevel == 4)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "D(Clone)" && currentLevel == 4)
        {
            //If correct object was destroyed then move to next object.
            //Increase level by 1
            //Destroy correct gameObject.

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript1>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "E(Clone)" && currentLevel == 4)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 4;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-5 (A-E) E
        if (collision.gameObject.name == "A(Clone)" && currentLevel == 5)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 0;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "B(Clone)" && currentLevel == 5)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 1;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "C(Clone)" && currentLevel == 5)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 2;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "D(Clone)" && currentLevel == 5)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript1>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            //If bool is true, spawn number 3 and set bool false
            if (InstantiateBool == true)
            {
                Spawner.Items = 3;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "E(Clone)" && currentLevel == 5)
        {
            //If correct object was destroyed then move to next object.
            //Increase level by 1
            //Destroy correct gameObject.

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript1>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }


        // Level 2-6 (F-J) F
        if (collision.gameObject.name == "F(Clone)" && currentLevel == 6)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "G(Clone)" && currentLevel == 6)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 6;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "H(Clone)" && currentLevel == 6)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 7;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "I(Clone)" && currentLevel == 6)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 8;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "J(Clone)" && currentLevel == 6)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 9;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-7 G
        if (collision.gameObject.name == "F(Clone)" && currentLevel == 7)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 5;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "G(Clone)" && currentLevel == 7)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "H(Clone)" && currentLevel == 7)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 7;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "I(Clone)" && currentLevel == 7)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 8;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "J(Clone)" && currentLevel == 7)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 9;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-8 H
        if (collision.gameObject.name == "F(Clone)" && currentLevel == 8)
        {

            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 5;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "G(Clone)" && currentLevel == 8)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 6;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "H(Clone)" && currentLevel == 8)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "I(Clone)" && currentLevel == 8)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 8;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "J(Clone)" && currentLevel == 8)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 9;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }        
        
        // Level 2-9 I
        if (collision.gameObject.name == "F(Clone)" && currentLevel == 9)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 5;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "G(Clone)" && currentLevel == 9)
        {

            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 6;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "H(Clone)" && currentLevel == 9)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 7;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "I(Clone)" && currentLevel == 9)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.name == "J(Clone)" && currentLevel == 9)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 9;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-10 J
        if (collision.gameObject.name == "F(Clone)" && currentLevel == 10)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 5;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "G(Clone)" && currentLevel == 10)
        {

            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 6;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "H(Clone)" && currentLevel == 10)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 7;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "I(Clone)" && currentLevel == 10)
        {

            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript2>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 8;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "J(Clone)" && currentLevel == 10)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript2>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        // Level 2-11 (K-O) K
        if (collision.gameObject.name == "K(Clone)" && currentLevel == 11)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "L(Clone)" && currentLevel == 11)
        {

            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 11;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "M(Clone)" && currentLevel == 11)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 12;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "N(Clone)" && currentLevel == 11)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 13;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "O(Clone)" && currentLevel == 11)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 14;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-12 (K-O) L
        if (collision.gameObject.name == "K(Clone)" && currentLevel == 12)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 10;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "L(Clone)" && currentLevel == 12)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "M(Clone)" && currentLevel == 12)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 12;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "N(Clone)" && currentLevel == 12)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 13;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "O(Clone)" && currentLevel == 12)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 14;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-13 (K-O) M
        if (collision.gameObject.name == "K(Clone)" && currentLevel == 13)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 10;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "L(Clone)" && currentLevel == 13)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 11;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "M(Clone)" && currentLevel == 13)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "N(Clone)" && currentLevel == 13)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 13;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "O(Clone)" && currentLevel == 13)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 14;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-14 (K-O) N
        if (collision.gameObject.name == "K(Clone)" && currentLevel == 14)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 10;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "L(Clone)" && currentLevel == 14)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 11;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "M(Clone)" && currentLevel == 14)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 12;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "N(Clone)" && currentLevel == 14)
        {

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "O(Clone)" && currentLevel == 14)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 14;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-15 (K-O) O
        if (collision.gameObject.name == "K(Clone)" && currentLevel == 15)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 10;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "L(Clone)" && currentLevel == 15)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 11;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "M(Clone)" && currentLevel == 15)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 12;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "N(Clone)" && currentLevel == 15)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript3>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 13;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        if (collision.gameObject.name == "O(Clone)" && currentLevel == 15)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript3>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }


        // Level 2-16 (P-T) P
        if (collision.gameObject.name == "P(Clone)" && currentLevel == 16)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript4>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Q(Clone)" && currentLevel == 16)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 16;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "R(Clone)" && currentLevel == 16)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 17;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "S(Clone)" && currentLevel == 16)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 18;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        if (collision.gameObject.name == "T(Clone)" && currentLevel == 16)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 19;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        // Level 2-17 (P-T) Q
        if (collision.gameObject.name == "P(Clone)" && currentLevel == 17)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 15;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Q(Clone)" && currentLevel == 17)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript4>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "R(Clone)" && currentLevel == 17)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 17;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "S(Clone)" && currentLevel == 17)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 18;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        if (collision.gameObject.name == "T(Clone)" && currentLevel == 17)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 19;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        // Level 2-18 (P-T) R
        if (collision.gameObject.name == "P(Clone)" && currentLevel == 18)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 15;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Q(Clone)" && currentLevel == 18)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 16;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "R(Clone)" && currentLevel == 18)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript4>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "S(Clone)" && currentLevel == 18)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 18;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        if (collision.gameObject.name == "T(Clone)" && currentLevel == 18)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 19;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-19 (P-T) S
        if (collision.gameObject.name == "P(Clone)" && currentLevel == 19)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 15;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Q(Clone)" && currentLevel == 19)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 16;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "R(Clone)" && currentLevel == 19)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 17;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "S(Clone)" && currentLevel == 19)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript4>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "T(Clone)" && currentLevel == 19)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 19;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-20 (P-T) T
        if (collision.gameObject.name == "P(Clone)" && currentLevel == 20)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 15;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Q(Clone)" && currentLevel == 20)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 16;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "R(Clone)" && currentLevel == 20)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 17;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "S(Clone)" && currentLevel == 20)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript4>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 18;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "T(Clone)" && currentLevel == 20)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript4>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        // Level 2-21 (U-Z) U
        if (collision.gameObject.name == "U(Clone)" && currentLevel == 21)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript5>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "V(Clone)" && currentLevel == 21)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 21;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "W(Clone)" && currentLevel == 21)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 22;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "X(Clone)" && currentLevel == 21)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 23;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Y(Clone)" && currentLevel == 21)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 24;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Z(Clone)" && currentLevel == 21)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 25;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-22 (U-Z) V
        if (collision.gameObject.name == "U(Clone)" && currentLevel == 22)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 20;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "V(Clone)" && currentLevel == 22)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript5>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "W(Clone)" && currentLevel == 22)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 22;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "X(Clone)" && currentLevel == 22)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 23;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Y(Clone)" && currentLevel == 22)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 24;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Z(Clone)" && currentLevel == 22)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 25;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-23 (U-Z) W
        if (collision.gameObject.name == "U(Clone)" && currentLevel == 23)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 20;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "V(Clone)" && currentLevel == 23)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 21;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }

        }

        if (collision.gameObject.name == "W(Clone)" && currentLevel == 23)
        {

            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript5>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.name == "X(Clone)" && currentLevel == 23)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 23;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Y(Clone)" && currentLevel == 23)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 24;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Z(Clone)" && currentLevel == 23)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 25;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-24 (U-Z) X
        if (collision.gameObject.name == "U(Clone)" && currentLevel == 24)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 20;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "V(Clone)" && currentLevel == 24)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 21;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "W(Clone)" && currentLevel == 24)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 22;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "X(Clone)" && currentLevel == 24)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript5>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Y(Clone)" && currentLevel == 24)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 24;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Z(Clone)" && currentLevel == 24)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 25;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-25 (U-Z) Y
        if (collision.gameObject.name == "U(Clone)" && currentLevel == 25)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 20;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "V(Clone)" && currentLevel == 25)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 21;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "W(Clone)" && currentLevel == 25)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 22;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "X(Clone)" && currentLevel == 25)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 23;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Y(Clone)" && currentLevel == 25)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript5>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Z(Clone)" && currentLevel == 25)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 25;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        // Level 2-26 (U-Z) Z
        if (collision.gameObject.name == "U(Clone)" && currentLevel == 26)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 20;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "V(Clone)" && currentLevel == 26)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();
            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 21;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "W(Clone)" && currentLevel == 26)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 22;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "X(Clone)" && currentLevel == 26)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 23;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }

        if (collision.gameObject.name == "Y(Clone)" && currentLevel == 26)
        {
            InstantiateBool = true;
            FindObjectOfType<AudioManager>().Play("WrongObjective");
            GetComponent<LetterTreePuzzleScript5>().DisplayWrongObjectText();

            Destroy(collision.gameObject);

            if (InstantiateBool == true)
            {
                Spawner.Items = 24;
                Spawner.InstantiateObjects();
                InstantiateBool = false;
            }
        }
           
        if (collision.gameObject.name == "Z(Clone)" && currentLevel == 26)
        {
            FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
            GetComponent<LetterTreePuzzleScript5>().NextLevel();
            currentLevel++;
            Destroy(collision.gameObject);

        }

    }
}

