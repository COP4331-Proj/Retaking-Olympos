using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("GameSceneIsLoaded", 1);
    }

    void OnDestroy()
    {
        PlayerPrefs.DeleteKey("GameSceneIsLoaded");
    }
}
