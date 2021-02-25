using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    List<Item> itemList;

    public event EventHandler UpdateItemList;

    public PlayerInventory() 
    {
        itemList = new List<Item>();


    }

    public void PopulateWithItems() 
    {
        AddItem(new Item { itemName = Item.ItemName.Sword, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, cost = 500, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, cost = 500, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, cost = 500, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, cost = 500, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, cost = 500, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, cost = 500, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Boots, cost = 500, amount = 4 });
    }

    public void AddItem(Item item) 
    {
            bool itemFoundInInventory = false;
            foreach (Item inventoryItem in itemList) 
            {
                if (inventoryItem.itemName == item.itemName) 
                {
                    itemFoundInInventory = true;
                    inventoryItem.amount += item.amount;
                }
            }
            if (!itemFoundInInventory) 
            {
                itemList.Add(item);
            }
        UpdateItemList?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveItem(Item item) 
    {
            Item itemInInventory = null;
            foreach (Item inventoryItem in itemList)
            {
                if (inventoryItem.itemName == item.itemName)
                {
                    itemInInventory = inventoryItem;
                    inventoryItem.amount -= 1;
                }
            }
            if (itemInInventory != null && itemInInventory.amount <= 0)
            {
                itemList.Remove(item);
            }
        UpdateItemList?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemList() 
    {
        return itemList;
    }
}
