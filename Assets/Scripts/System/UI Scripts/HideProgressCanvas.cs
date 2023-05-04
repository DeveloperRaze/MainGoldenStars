using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideProgressCanvas : MonoBehaviour
{
    [SerializeField] Canvas NumberTreeUI;
    [SerializeField] Canvas LetterTreeUI;
    [SerializeField] Canvas MaterialChange;


    // Start is called before the first frame update
    void Start()
    {
        NumberTreeUI.enabled = true;
        LetterTreeUI.enabled = false;
        MaterialChange.enabled = false;
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

    public void ShowCarColour()
    {
        MaterialChange.enabled = true;
    }
    public void HideCarColour()
    {
        if (MaterialChange.enabled == true)
        {
            MaterialChange.enabled = false;
        }
    }
}
