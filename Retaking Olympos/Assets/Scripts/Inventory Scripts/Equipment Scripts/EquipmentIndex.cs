using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
