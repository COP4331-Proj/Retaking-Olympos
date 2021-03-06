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
        if (goldText != null) 
        {
            goldText.text = playerInformation.gold.ToString();
        }
    }
}
