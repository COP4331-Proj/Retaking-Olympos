using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopControler : MonoBehaviour
{
    public UIInventory uIInventory;
    public HoldPlayerInformation holdPlayerInformation;
    void Start()
    {

        // load the inventory and equipment from scriptable objects
        uIInventory.SetInventory(holdPlayerInformation.shopInventory, false);

    }
}
