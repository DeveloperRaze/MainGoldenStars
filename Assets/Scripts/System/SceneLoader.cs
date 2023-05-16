using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // I need to work out how to load Level select scene regardless of what scene the player is on. 
    //Animator that creates the transition effect
    public Animator transition;
    //Current scene index in build settings
    int currentSceneIndex;
    //Effect transition time
    public float transitionTime = 3f;
    //UI menu buttons.
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject PlayButton;
    [SerializeField] GameObject PauseText;

    //Reload Gamew
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

    // Triggers for Orchard 1 & 2.
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("ObjectiveCompleted");
        NextScene();
    }
    //Next Scene
    public void NextScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    //
    public void ReturnToLevelSelect()
    {
        SceneManager.LoadScene("2 Level selection");
    }

    // to delay the next scene, start Coroutine
    IEnumerator LoadLevel(int levelIndex)
    {
        //Play animation effect
        transition.SetTrigger("Start");

        //Wait for animation to stop
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(levelIndex);
    }
}

