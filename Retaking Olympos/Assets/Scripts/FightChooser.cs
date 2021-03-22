using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FightChooser : MonoBehaviour
{
    public Button carpophorusButton;
    public Button crixusButton;
    public Button commodusButton;
    public Button flammaButton;
    public Button spartacusButton;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("CarpophorusBeat") == 1)
        {
            carpophorusButton.interactable = false;
        }
        if (PlayerPrefs.GetInt("CommodusBeat") == 1)
        {
            commodusButton.interactable = false;
        }
        if (PlayerPrefs.GetInt("CrixusBeat") == 1)
        {
            crixusButton.interactable = false;
        }
        if (PlayerPrefs.GetInt("FlammaBeat") == 1)
        {
            flammaButton.interactable = false;
        }
        if (PlayerPrefs.GetInt("SpartacusBeat") == 1)
        {
            spartacusButton.interactable = false;
        }
    }

    public void carpophorusClick()
    {
        PlayerPrefs.SetString("CurrentEnemy", "Carpophorus");
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Game");
    }

    public void crixusClick()
    {
        PlayerPrefs.SetString("CurrentEnemy", "Crixus");
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Game");
    }

    public void commodusClick()
    {
        PlayerPrefs.SetString("CurrentEnemy", "Commodus");
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Game");
    }

    public void flammaClick()
    {
        PlayerPrefs.SetString("CurrentEnemy", "Flamma");
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Game");
    }

    public void spartacusClick()
    {
        PlayerPrefs.SetString("CurrentEnemy", "Spartacus");
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Game");
    }
}
