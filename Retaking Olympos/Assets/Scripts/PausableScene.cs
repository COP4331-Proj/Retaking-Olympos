using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausableScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<PauseMenu>();
            gameObject.GetComponent<PauseMenu>().ShowPauseMenu(SceneManager.GetActiveScene().name);
        }
    }
}
