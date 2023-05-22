using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    //Animator that creates the transition effect
    public Animator transition;

    //Current scene index in build settings
    int currentSceneIndex;

    //Effect transition time is 3 seconds. 
    public float transitionTime = 3f;
    //UI menu buttons.
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject PlayButton;
    [SerializeField] GameObject PauseText;

    //Removes unassigned ref errors from first scene
    public void Start()
    {
        if (PauseButton != null)
        {
            return;
        }
    }

    //Reload Game
    public void ReloadGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    //Pause Game
    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseText.SetActive(true);
        PlayButton.SetActive(true);
    }

    //Resume Game
    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseText.SetActive(false);
        PlayButton.SetActive(false);
        PauseButton.SetActive(true);
    }

    //Quit Game
    public void QuitGame()
    {
        print("quit");
        Application.Quit();
    }

    //Next Scene - To the number tree scene 1. 
    public void NextScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void NumberTreeScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    //Takes player to Letter tree scene 1 once number tree has been completed. 
    public void LetterTreeScene()
    {
        StartCoroutine(LetterTree(SceneManager.GetActiveScene().buildIndex + 1));
    }

    //Return to level select mid-game.
    public void ReturnToLevelSelect()
    {
        StartCoroutine(ReturnHome(SceneManager.GetActiveScene().buildIndex + 1));
    }

    // to load the next scene
    IEnumerator LoadLevel(int levelIndex)
    {
        //Play animation effect
        transition.SetTrigger("Start");

        //Wait for animation to stop
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(levelIndex);
    }

    // to go to Letter tree scene 1
    IEnumerator LetterTree(int levelIndex)
    {
        
        //Play animation effect
        transition.SetTrigger("Start");

        //Wait for animation to stop
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(8);
    }

    // to return to home
    IEnumerator ReturnHome(int levelIndex)
    {

        //Play animation effect
        transition.SetTrigger("Start");

        //Wait for animation to stop
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(1);
    }
}

