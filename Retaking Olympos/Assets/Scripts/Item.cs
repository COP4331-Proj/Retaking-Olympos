using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemName 
    {
        Sword,
        Helmet,
        Chestplate,
        Pants,
        Boots,
    }

    public ItemName itemName;
    public int cost;    
}
