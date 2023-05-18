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
        //Hide level progress canvas at start
        MenuCanvas.SetActive(false);
    }

    public void ShowCanvas()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPress");
        MenuCanvas.SetActive(true);
        SceneLoader.PauseGame(); // This calls an error because it pauses the game but asks PauseGame to set the pause text and play button active,
                                 // when it is not present in this scene.
    }

    public void HideCanvas()
    {
        MenuCanvas.SetActive(false);

        FindObjectOfType<AudioManager>().Play("ExitButton");
        SceneLoader.ResumeGame();// This calls an error because it pauses the game but asks ResumeGame to set the Pause button active,
                                 // when it is not present in this scene.
    }
}
