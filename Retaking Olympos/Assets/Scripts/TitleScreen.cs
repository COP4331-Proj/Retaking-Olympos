using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadOptionsMenu()
    {
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SettingsMenu>();
        gameObject.GetComponent<SettingsMenu>().ShowSettingsMenu("Title Screen");
    }
}
