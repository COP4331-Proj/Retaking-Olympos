using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GladiatorPicker : MonoBehaviour
{
    public HoldPlayerInformation holdPlayerInformation;
    List<Gladiator> gladiatorList;
    [SerializeField] TextMeshProUGUI nameText;
    int gladiatorIndex = 0;

    void Start()
    {
        holdPlayerInformation.index = 0;
        gladiatorList = holdPlayerInformation.gladiatorList;
        if (nameText == null) 
        {
            nameText = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TextMeshProUGUI>();
        }
        RefreshStats();
    }

    
    void Update()
    {
        
    }

    void RefreshStats() 
    {
        if (nameText != null) 
        {
            nameText.text = gladiatorList[gladiatorIndex].GetName().ToString();
        }
    }

    public void IncrementGladiatorIndex()
    {
        gladiatorIndex = (gladiatorIndex + 1) % gladiatorList.Count;
        holdPlayerInformation.index = gladiatorIndex;
        RefreshStats();
    }

    public void DecrementGladiatorIndex()
    {
        gladiatorIndex = (gladiatorIndex - 1) % gladiatorList.Count;
        if (gladiatorIndex < 0)
        {
            gladiatorIndex += gladiatorList.Count;
        }
        holdPlayerInformation.index = gladiatorIndex;
        RefreshStats();
    }
}
