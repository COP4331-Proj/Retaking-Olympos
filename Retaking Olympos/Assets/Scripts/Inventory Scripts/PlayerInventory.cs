using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    List<Item> itemList;

    public event EventHandler UpdateItemList;

    // An inventory holds a list of items
    public PlayerInventory() 
    {
        itemList = new List<Item>();

    }

    // Populate inventory with dummy items for testing
    public void PopulateWithItems() 
    {
        AddItem(new Item { itemName = Item.ItemName.Sword, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet,  amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Sword, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Helmet, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, amount = 1 });
        AddItem(new Item { itemName = Item.ItemName.Pants, amount = 1 });

        AddItem(new Item { itemName = Item.ItemName.Boots, amount = 4 });
    }

    internal void PopulateWithShopItems()
    {
        AddItem(new Item { itemName = Item.ItemName.Sword, amount = 1 , isShop = true});
        AddItem(new Item { itemName = Item.ItemName.Helmet, amount = 1, isShop = true });
        AddItem(new Item { itemName = Item.ItemName.Chestplate, amount = 1, isShop = true });
        AddItem(new Item { itemName = Item.ItemName.Pants, amount = 1, isShop = true });
    }

    // Add item to the inventory
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

    // Remove item from the inventory
    public void RemoveItem(Item item) 
    {
            // Loop through each item in the list
            Item itemInInventory = null;
            foreach (Item inventoryItem in itemList)
            {
                // If item is found, decrease its amount
                if (inventoryItem.itemName == item.itemName)
                {
                    itemInInventory = inventoryItem;
                    inventoryItem.amount -= 1;
                }
            }
            // If amount is 0, remove it
            if (itemInInventory != null && itemInInventory.amount <= 0)
            {
                itemList.Remove(item);
            }
        // Update list using unity event manager
        UpdateItemList?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemList() 
    {
        return itemList;
    }
}
