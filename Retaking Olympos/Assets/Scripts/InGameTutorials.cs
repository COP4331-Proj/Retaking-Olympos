using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameTutorials : MonoBehaviour
{
    private static bool seenShop = false;
    private static bool seenViewGladiator = false;
    public void GotoShop()
    {

        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        if (seenShop)
        {
            gameObject.GetComponent<SceneLoader>().GoToScene("Shop");
        }
        else
        {
            seenShop = true;
            gameObject.GetComponent<SceneLoader>().GoToScene("ShopTutorial");
        }
    }

    public void GotoView()
    {

        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        if (seenViewGladiator)
        {
            gameObject.GetComponent<SceneLoader>().GoToScene("View Gladiator");
        }
        else
        {
            seenViewGladiator = true;
            gameObject.GetComponent<SceneLoader>().GoToScene("ViewTutorial");
        }

    }

    public void ContinueToShop()
    {
        seenShop = true;
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Shop");
    }

    public void ContinueToView()
    {
        seenViewGladiator = true;
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("View Gladiators");
    }
}
