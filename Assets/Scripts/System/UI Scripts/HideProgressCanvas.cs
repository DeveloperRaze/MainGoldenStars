using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideProgressCanvas : MonoBehaviour
{
    [SerializeField] Canvas NumberTreeUI;
    [SerializeField] Canvas LetterTreeUI;
    [SerializeField] GameObject PurpleBackdrop;
    [SerializeField] GameObject GreenBackdrop;

    // Start is called before the first frame update
    void Start()
    {
        NumberTreeUI.enabled = true;
        LetterTreeUI.enabled = false;
        PurpleBackdrop.SetActive(false);
    }

    public void ShowNumberUI()
    {
        NumberTreeUI.enabled = true;
        LetterTreeUI.enabled = false;

        PurpleBackdrop.SetActive(false);
        GreenBackdrop.SetActive(true);
    }

    public void ShowLetterUI()
    {
        NumberTreeUI.enabled = false;
        LetterTreeUI.enabled = true;

        PurpleBackdrop.SetActive(true);
        GreenBackdrop.SetActive(false);
    }
}
