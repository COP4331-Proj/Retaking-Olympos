using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    private static String currentClass;

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
}
