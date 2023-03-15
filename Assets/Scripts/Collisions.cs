using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Level 1-1 (Change to 1)
        //Check for a match with the specified name on any GameObject that collides with your GameObject

        if (collision.gameObject.name == "2")
        {
            //If the GameObject's name matches, destroy object with delay.

            Destroy(collision.gameObject);

            //If correct object was destroyed then move to next object.
        }

        //Level 1-2 (change to 2)

        if (collision.gameObject.name == "3")
        {
            GetComponent<PuzzleScript>().nextLevel();
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.name == "3")
        {
            GetComponent<PuzzleScript>().nextLevel();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "4")
        {
            GetComponent<PuzzleScript>().nextLevel();
            Destroy(collision.gameObject);        
        }
    }
}
