using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to arrow buttons that change index of list when pressed
// Passed through UIInventory controler to get list, then passed to UIEquipment to update visuals
public class EquipmentIndex : MonoBehaviour
{
    public UIInventoryControler uIInventoryControler;
    public void IncrementEquipmentIndex()
    {
        uIInventoryControler.IncrementEquipmentIndex();
    }

    public void DecrementEquipmentIndex()
    {
        uIInventoryControler.DecrementEquipmentIndex();
    }
}
