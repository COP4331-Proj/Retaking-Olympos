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
    public int amount;

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
}
