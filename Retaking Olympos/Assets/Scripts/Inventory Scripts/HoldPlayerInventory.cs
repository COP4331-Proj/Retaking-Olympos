using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scriptable object to hold a player inventory object
// Scriptable object allows data to be held between scenes
[CreateAssetMenu(fileName = "PlayerInventory", menuName = "Inventories")]
public class HoldPlayerInventory : ScriptableObject
{

    public PlayerInventory playerInventory = new PlayerInventory();


}
