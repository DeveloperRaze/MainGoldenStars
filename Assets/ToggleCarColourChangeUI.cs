using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCarColourChangeUI : MonoBehaviour
{
    public  Canvas ColourCanvas;
    public  Button ShowColours;
    public  Button HideColours;


    // Start is called before the first frame update
    void Start()
    {
        ColourCanvas.enabled = false;
        HideColours.image.enabled = false;
        ShowColours.image.enabled = true;
    }

    public void ShowCarColours()
    {
        ColourCanvas.enabled = true;
        HideColours.image.enabled = true;
        ShowColours.image.enabled = false;
    }

    public void HideCarColours()
    {
        HideColours.image.enabled = false;
        ShowColours.image.enabled = true;
        ColourCanvas.enabled = false;
    }
}
