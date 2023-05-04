using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectButtonScript : MonoBehaviour
{
    public GameObject LevelSelectButton;
    public Canvas LevelSelectCanvas;
    public SceneLoader SceneLoader;
    public GameObject MenuCanvas;


    private void Start()
    {
        MenuCanvas.SetActive(false);
    }

    public void ShowCanvas()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPress");
        MenuCanvas.SetActive(true);
        SceneLoader.PauseGame();
    }

    public void HideCanvas()
    {
        MenuCanvas.SetActive(false);

        FindObjectOfType<AudioManager>().Play("ExitButton");
        SceneLoader.ResumeGame();


    }
}
