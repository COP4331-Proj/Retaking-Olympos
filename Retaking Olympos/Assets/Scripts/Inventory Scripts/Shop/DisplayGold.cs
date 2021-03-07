using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DisplayGold : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public HoldPlayerInformation playerInformation;

    private void Update()
    {
        // If gold text exists, update it with the players gold
        if (goldText != null) 
        {
            goldText.text = playerInformation.gold.ToString();
        }
    }
}
