using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingGold : MonoBehaviour
{
    public HoldPlayerInformation player;
    static bool flag = true;
    private void Start()
    {
        if (player.gold <= 0 && flag)
        {
            flag = false;
            player.gold += 300;
        }
    }
}
