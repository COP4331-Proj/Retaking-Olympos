using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DisplayGold : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] HoldPlayerGold playerGold;

    private void Update()
    {
        if (goldText != null) 
        {
            goldText.text = playerGold.gold.ToString();
        }
    }
}
