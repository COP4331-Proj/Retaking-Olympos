using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Definition of what an item object entails
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
    public int amount;
    public int plusPower = 0;
    public int plusDefense = 0;
    // Returns the sprite of the item
    public Sprite GetSprite()
    {
        switch (itemName) 
        {
            case ItemName.Sword:
                {
                    return ItemAssets.Instance.swordSprite;
                }
            case ItemName.Helmet:
                {
                    return ItemAssets.Instance.helmetSprite;
                }
            case ItemName.Chestplate:
                {
                    return ItemAssets.Instance.chestplateSprite;
                }
            case ItemName.Pants:
                {
                    return ItemAssets.Instance.pantsSprite;
                }
            case ItemName.Boots:
                {
                    return ItemAssets.Instance.bootsSprite;
                }
            default:
                return null;
        }
    }
    public GladiatorEquiptment.SlotName GetSlotName()
    {
        switch (itemName) 
        {
            default:
            case ItemName.Sword:
                return GladiatorEquiptment.SlotName.Sword;
            case ItemName.Helmet:
                return GladiatorEquiptment.SlotName.Helmet;
            case ItemName.Chestplate:
                return GladiatorEquiptment.SlotName.Chestplate;
            case ItemName.Pants:
                return GladiatorEquiptment.SlotName.Pants;
            case ItemName.Boots:
                return GladiatorEquiptment.SlotName.Boots;
        }
    }

    public int GetPower()
    {
        switch (itemName)
        {
            case ItemName.Sword:
                {
                    return 5;
                }
            case ItemName.Helmet:
                {
                    return 0;
                }
            case ItemName.Chestplate:
                {
                    return 0;
                }
            case ItemName.Pants:
                {
                    return 0;
                }
            case ItemName.Boots:
                {
                    return 0;
                }
            default:
                return 0;
        }
    }

    public int GetDefense()
    {
        switch (itemName)
        {
            case ItemName.Sword:
                {
                    return 0;
                }
            case ItemName.Helmet:
                {
                    return 5;
                }
            case ItemName.Chestplate:
                {
                    return 8;
                }
            case ItemName.Pants:
                {
                    return 7;
                }
            case ItemName.Boots:
                {
                    return 4;
                }
            default:
                return 0;
        }
    }
}
