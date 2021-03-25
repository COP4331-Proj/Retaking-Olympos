using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMaker : MonoBehaviour
{
    public HoldPlayerInformation player;

    // Start is called before the first frame update
    void Start()
    {
        player.gold += 250;
    }
}
