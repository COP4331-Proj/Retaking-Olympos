using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    static String previousClass;

    public void Resume()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene(previousClass);
    }

    public void ShowPauseMenu(string callingClass)
    {
        previousClass = callingClass;

        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Pause Menu");
    }

    public void ShowOptionsMenu()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SettingsMenu>();
        gameObject.GetComponent<SettingsMenu>().ShowSettingsMenu("Pause Menu");
    }

    public void QuitGame()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().QuitGame();
    }
}
