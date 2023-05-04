using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideProgressCanvas : MonoBehaviour
{
    [SerializeField] Canvas NumberTreeUI;
    [SerializeField] Canvas LetterTreeUI;

    [SerializeField] Canvas LetterTreeCanvas;
    [SerializeField] Canvas NumberTreeCanvas;


    // Start is called before the first frame update
    void Start()
    {
        NumberTreeUI.enabled = true;
        LetterTreeUI.enabled = false;

        NumberTreeCanvas.enabled = true;
        LetterTreeCanvas.enabled = false;

    }

    public void ShowNumberUI()
    {
        NumberTreeUI.enabled = true;
        LetterTreeUI.enabled = false;

        NumberTreeCanvas.enabled = true;
        LetterTreeCanvas.enabled = false;
    }

    public void ShowLetterUI()
    {
        NumberTreeUI.enabled = false;
        LetterTreeUI.enabled = true;

        LetterTreeCanvas.enabled = true;
        NumberTreeCanvas.enabled = false;
    }
}
