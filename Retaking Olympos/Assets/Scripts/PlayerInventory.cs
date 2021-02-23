using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    public List<Item> itemList;

    public PlayerInventory() 
    {
        itemList = new List<Item>();
    }

    public void AddItem(Item item) 
    {
        itemList.Add(item);
    }
}
