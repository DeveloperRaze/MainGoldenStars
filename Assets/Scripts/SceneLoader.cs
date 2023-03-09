using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    int currentSceneIndex;
    public float transitionTime = 3f;

    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject PlayButton;

    [SerializeField] GameObject PauseText;


    public void ReloadGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseText.SetActive(true);
        PlayButton.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseText.SetActive(false);
        PlayButton.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void QuitGame()
    {
        print("quit");
        Application.Quit();
    }

    // Triggers for Orchard 1 & 2.
    private void OnTriggerEnter(Collider other)
    {
        NextScene();
    }

    public void NextScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    // to delay the next scene, start Coroutine

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait for animation to stop
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(levelIndex);
    }

}

