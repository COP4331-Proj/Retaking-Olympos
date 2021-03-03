using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class SellBox : MonoBehaviour
{
    SellSlot sellBox;
    [SerializeField] HoldPlayerGold playerGold;
    [SerializeField] HoldPlayerInventory playerInventory;
    private void Awake()
    {
        sellBox = transform.Find("SellBox").GetComponent<SellSlot>();
        sellBox.OnItemDropped += sellBox_OnItemDropped;
    }

    private void sellBox_OnItemDropped(object sender, SellSlot.OnItemDroppedEventArgs e)
    {

        if (!e.item.isShop) 
        {
            playerGold.gold += e.item.GetSellPrice();
            playerInventory.playerInventory.RemoveItem(e.item);
        }
    }
}
