using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Scriptable object to hold a the shop inventory
// Scriptable object allows data to be held between scenes
[CreateAssetMenu(fileName = "ShopInventory", menuName = "Shop")]
public class HoldShopInventory : ScriptableObject
{
    public PlayerInventory shopInventory = new PlayerInventory();
}
