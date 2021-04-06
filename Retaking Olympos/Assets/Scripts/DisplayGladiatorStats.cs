using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayGladiatorStats : MonoBehaviour
{
    List<Gladiator> gladiatorList;
    [SerializeField] int gladiatorIndex = 0;

    // Text fields for all 6 gladiator attributes 
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI staminaText;
    [SerializeField] TextMeshProUGUI powerText;
    [SerializeField] TextMeshProUGUI defenseText;
    [SerializeField] TextMeshProUGUI classText;
    [SerializeField] Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        gladiatorIndex = 0;
        gladiatorList = GetComponent<ViewGladiator>().GetGladiatorList();
        RefreshStats();
    }

    // TODO make this faster using events like inventory updates
    // Currently in update for updating stats when weapon equiped
    private void Update()
    {
        RefreshStats();
    }

    // Refreshes text fields with new gladiators stats
    public void RefreshStats() 
    {
        if (gladiatorList.Count == 0) 
        {
            Debug.Log("HERE");
        }
        gladiatorList = GetComponent<ViewGladiator>().GetGladiatorList();
        nameText.text = gladiatorList[gladiatorIndex].GetName().ToString();
        levelText.text = gladiatorList[gladiatorIndex].GetLevel().ToString();
        healthText.text = gladiatorList[gladiatorIndex].GetHealth().ToString();
        staminaText.text = gladiatorList[gladiatorIndex].GetStamina().ToString();
        powerText.text = gladiatorList[gladiatorIndex].GetPower().ToString();
        defenseText.text = gladiatorList[gladiatorIndex].GetDefense().ToString();
        classText.text = gladiatorList[gladiatorIndex].GetClass().ToString();

        buttonText.text = "Train for " + (gladiatorList[gladiatorIndex].GetCost() * 2).ToString() + " g";
    }

    public void IncrementGladiatorIndex() 
    {
        gladiatorIndex = (gladiatorIndex + 1) % gladiatorList.Count;
        RefreshStats();
    }

    public void DecrementGladiatorIndex()
    {
        gladiatorIndex = (gladiatorIndex - 1) % gladiatorList.Count;
        if (gladiatorIndex < 0) 
        {
            gladiatorIndex += gladiatorList.Count;
        }
        RefreshStats();
    }
}
