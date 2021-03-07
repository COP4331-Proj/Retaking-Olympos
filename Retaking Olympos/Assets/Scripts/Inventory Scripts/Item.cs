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
    public bool isShop = false;
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

    public int GetSellPrice()
    {
        switch (itemName)
        {
            case ItemName.Sword:
                {
                    return 100;
                }
            case ItemName.Helmet:
                {
                    return 50;
                }
            case ItemName.Chestplate:
                {
                    return 80;
                }
            case ItemName.Pants:
                {
                    return 70;
                }
            case ItemName.Boots:
                {
                    return 40;
                }
            default:
                return 0;
        }
    }

    public int GetBuyPrice()
    {
        switch (itemName)
        {
            case ItemName.Sword:
                {
                    return 150;
                }
            case ItemName.Helmet:
                {
                    return 75;
                }
            case ItemName.Chestplate:
                {
                    return 120;
                }
            case ItemName.Pants:
                {
                    return 105;
                }
            case ItemName.Boots:
                {
                    return 60;
                }
            default:
                return 0;
        }
    }

    public string GetDescription()
    {
        switch (itemName)
        {
            case ItemName.Sword:
                {
                    return "A Thracian's sword and shield \nPower + 5";
                }
            case ItemName.Helmet:
                {
                    return "A Thracian's helmet \nDefense + 5";
                }
            case ItemName.Chestplate:
                {
                    return "A Thracian's chestplate \nDefense + 8";
                }
            case ItemName.Pants:
                {
                    return "A Thracian's leggings \nDefense + 7";
                }
            case ItemName.Boots:
                {
                    return "A Thracian's footware \nDefense + 4";
                }
            default:
                return "";
        }
    }
}
