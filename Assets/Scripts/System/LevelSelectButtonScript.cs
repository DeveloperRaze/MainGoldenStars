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
        LevelSelectCanvas.enabled = true;
        SceneLoader.PauseGame();
    }

    public void HideCanvas()
    {
        LevelSelectCanvas.enabled = false;
        SceneLoader.ResumeGame();

    }
}
