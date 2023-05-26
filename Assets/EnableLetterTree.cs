using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLetterTree : MonoBehaviour
{

    [SerializeField] GameObject LetterTreeFence;
    [SerializeField] GameObject LetterTreeSign;

    // Start is called before the first frame update
    void Start()
    {
        LetterTreeSign.SetActive(false);
    }

    //Here we can call a method to enable the sign and disable the barrier. 

    public void LetterTreeEnable()
    {
        LetterTreeSign.SetActive(true);
        Destroy(LetterTreeFence);
    }
}
