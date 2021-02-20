using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayGladiatorStats : MonoBehaviour
{
    List<Gladiator> gladiatorList;
    int gladiatorIndex = 0;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI staminaText;
    [SerializeField] TextMeshProUGUI powerText;
    [SerializeField] TextMeshProUGUI defenseText;

    // Start is called before the first frame update
    void Start()
    {
        ViewGladiator viewGladiator = new ViewGladiator();
        viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
        viewGladiator.createNewGladiator("Bob", 3, 100, 100, 6, 14);
        gladiatorList = viewGladiator.GetGladiatorList();
    }

    // Update is called once per frame
    void Update()
    {
        RefreshStats();
    }

    public void RefreshStats() 
    {
        nameText.text = gladiatorList[gladiatorIndex].GetName().ToString();
        levelText.text = gladiatorList[gladiatorIndex].GetLevel().ToString();
        healthText.text = gladiatorList[gladiatorIndex].GetHealth().ToString();
        staminaText.text = gladiatorList[gladiatorIndex].GetStamina().ToString();
        powerText.text = gladiatorList[gladiatorIndex].GetPower().ToString();
        defenseText.text = gladiatorList[gladiatorIndex].GetDefense().ToString();
    }

}
