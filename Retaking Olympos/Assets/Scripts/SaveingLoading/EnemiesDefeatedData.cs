using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemiesDefeatedData
{
    public int CarpophorusBeat, CommodusBeat, CrixusBeat, FlammaBeat, SpartacusBeat, CassiusBeat, MarcusBeat, SilvanusBeat, VerusBeat, TetraitesBeat;

    public EnemiesDefeatedData()
    {
        CarpophorusBeat = PlayerPrefs.GetInt("CarpophorusBeat");
        CommodusBeat = PlayerPrefs.GetInt("CommodusBeat");
        CrixusBeat = PlayerPrefs.GetInt("CrixusBeat");
        FlammaBeat = PlayerPrefs.GetInt("FlammaBeat");
        SpartacusBeat = PlayerPrefs.GetInt("SpartacusBeat");

        CassiusBeat = PlayerPrefs.GetInt("CassiusBeat");
        MarcusBeat = PlayerPrefs.GetInt("MarcusBeat");
        SilvanusBeat = PlayerPrefs.GetInt("SilvanusBeat");
        VerusBeat = PlayerPrefs.GetInt("VerusBeat");
        TetraitesBeat = PlayerPrefs.GetInt("TetraitesBeat");
    }
}