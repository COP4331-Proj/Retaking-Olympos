using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DisplayGold : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] HoldPlayerInformation playerInformation;

    private void Update()
    {
        if (goldText != null) 
        {
            goldText.text = playerInformation.gold.ToString();
        }
    }
}
