using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectButtonScript : MonoBehaviour
{
    public GameObject LevelSelectButton;
    public Canvas LevelSelectCanvas;
    public SceneLoader SceneLoader;


    private void Start()
    {
        LevelSelectCanvas.enabled = false;
    }

    public void ShowCanvas()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPress");
        LevelSelectCanvas.enabled = true;
        SceneLoader.PauseGame();
    }

    public void HideCanvas()
    {
        FindObjectOfType<AudioManager>().Play("ExitButton");
        LevelSelectCanvas.enabled = false;
        SceneLoader.ResumeGame();
    }
}
