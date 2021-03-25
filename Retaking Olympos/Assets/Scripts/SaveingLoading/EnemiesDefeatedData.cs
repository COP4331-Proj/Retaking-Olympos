using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemiesDefeatedData
{
    public int CarpophorusBeat, CommodusBeat, CrixusBeat, FlammaBeat, SpartacusBeat;

    public EnemiesDefeatedData()
    {
        CarpophorusBeat = PlayerPrefs.GetInt("CarpophorusBeat");
        CommodusBeat = PlayerPrefs.GetInt("CommodusBeat");
        CrixusBeat = PlayerPrefs.GetInt("CrixusBeat");
        FlammaBeat = PlayerPrefs.GetInt("FlammaBeat");
        SpartacusBeat = PlayerPrefs.GetInt("SpartacusBeat");
    }
}