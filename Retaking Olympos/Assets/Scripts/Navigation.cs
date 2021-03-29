using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    private static String currentClass;
    private static bool firstLaunch = false;
    public void GoBack()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        currentClass = SceneManager.GetActiveScene().name;

        if (currentClass == "Shop")
        {
            gameObject.GetComponent<SceneLoader>().GoToScene("View Gladiator");
        }
        else if (currentClass == "FightChooser")
        {
            gameObject.GetComponent<SceneLoader>().GoToScene("Main Scene");
        }
        else if (currentClass == "Main Scene")
        {
            gameObject.GetComponent<SceneLoader>().GoToScene("Title Screen");
        }
    }

    public void StartGame()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        // Static boolean used for demo, player prefs in built game wont clear -Nathan
/*        if (!PlayerPrefs.HasKey("FirstLaunch")) 
        {
        
        }*/
        if (!firstLaunch)
        {
            firstLaunch = true;
            gameObject.GetComponent<SceneLoader>().GoToScene("Welcome");
            PlayerPrefs.SetInt("FirstLaunch", 1);
        }
        else
        {
            gameObject.GetComponent<SceneLoader>().GoToScene("Main Scene");
        }
    }

    public void Continue()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Main Scene");
    }
}
