using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public void btn_options(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
