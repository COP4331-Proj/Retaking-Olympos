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
}
