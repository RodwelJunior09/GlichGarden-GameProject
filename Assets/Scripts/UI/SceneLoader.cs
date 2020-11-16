﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        var sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex == 0) StartCoroutine(LoadStartMenu());
    }

    public IEnumerator LoadStartMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("StartScreen");
    }

    public void StartScreen()
    {
        StartCoroutine(LoadStartMenu());
    }

    public void LoadOptionsScene()
    {
        SceneManager.LoadScene("OptionsScreen");
    }

    public void LoadGameOver()
    {
        StartCoroutine(LoadGameOverScreen());
    }

    public void LoadNextScene()
    {
        int currentIndexScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndexScene + 1);
    }

    private IEnumerator LoadGameOverScreen()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
