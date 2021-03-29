using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject sceneloader;
    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetInt("VerusBeat") == 1)
        {
            if (PlayerPrefs.GetInt("TetraitesBeat") == 1)
            {
                if (PlayerPrefs.GetInt("SilvanusBeat") == 1)
                {
                    if (PlayerPrefs.GetInt("MarcusBeat") == 1)
                    {
                        if (PlayerPrefs.GetInt("CassiusBeat") == 1)
                        {
                            if (PlayerPrefs.GetInt("SpartacusBeat") == 1)
                            {
                                if (PlayerPrefs.GetInt("FlammaBeat") == 1)
                                {
                                    if (PlayerPrefs.GetInt("CrixusBeat") == 1)
                                    {
                                        if (PlayerPrefs.GetInt("CommodusBeat") == 1)
                                        {
                                            if (PlayerPrefs.GetInt("CarpophorusBeat") == 1)
                                            {
                                                if (sceneloader != null) 
                                                {
                                                    sceneloader.GetComponent<SceneLoader>().GoToScene("End Game");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }

}
