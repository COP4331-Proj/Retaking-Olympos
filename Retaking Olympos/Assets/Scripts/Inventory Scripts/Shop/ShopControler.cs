using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopControler : MonoBehaviour
{
    public UIInventory uIInventory;
    public HoldShopInventory holdShopInventory;
    void Start()
    {
        if (FindObjectsOfType<UIInventoryControler>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        // load the inventory and equipment from scriptable objects
        uIInventory.SetInventory(holdShopInventory.shopInventory, false);

    }
}
