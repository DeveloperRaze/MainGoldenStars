using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideProgressCanvas : MonoBehaviour
{
    [SerializeField] Canvas NumberTreeUI;
    [SerializeField] Canvas LetterTreeUI;


    // Start is called before the first frame update
    void Start()
    {
        NumberTreeUI.enabled = true;
        LetterTreeUI.enabled = false;
    }

    public void ShowNumberUI()
    {
        NumberTreeUI.enabled = true;
        LetterTreeUI.enabled = false;
    }

    public void ShowLetterUI()
    {
        LetterTreeUI.enabled = true;
        NumberTreeUI.enabled = false;
    }
}
