using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gold", menuName = "Gold")]
public class HoldPlayerGold : ScriptableObject
{
    [SerializeField] private int baseGold = 0;            
    public int gold;

    private void OnEnable()
    {
        gold = baseGold;
    }


}
