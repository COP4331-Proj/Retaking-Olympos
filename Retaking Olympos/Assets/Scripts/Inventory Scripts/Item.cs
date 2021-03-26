using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Definition of what an item object entails
public class Item
{
    // 1 = Thracian
    // 2 = Samnite
    // 3 = Secutor
    // 4 = Murmillo
    // 5 = Dimachaerus

    public enum ItemName 
    {
        Sword,
        Helmet,
        Chestplate,
        Pants,
        Boots,
        Sword2,
        Helmet2,
        Boots2,
        Sword3,
        Helmet3,
        Chestplate3,
        Pants3,
        Boots3,
        Sword4,
        Helmet4,
        Chestplate4,
        Pants4,
        Boots4,
        Sword5,
        Helmet5,
        Chestplate5,
        Pants5,
        Boots5,
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
            case ItemName.Sword2:
                {
                    return ItemAssets.Instance.swordSprite2;
                }
            case ItemName.Helmet2:
                {
                    return ItemAssets.Instance.helmetSprite2;
                }
            case ItemName.Boots2:
                {
                    return ItemAssets.Instance.bootsSprite2;
                }
            case ItemName.Sword3:
                {
                    return ItemAssets.Instance.swordSprite3;
                }
            case ItemName.Helmet3:
                {
                    return ItemAssets.Instance.helmetSprite3;
                }
            case ItemName.Chestplate3:
                {
                    return ItemAssets.Instance.chestplateSprite3;
                }
            case ItemName.Pants3:
                {
                    return ItemAssets.Instance.pantsSprite3;
                }
            case ItemName.Boots3:
                {
                    return ItemAssets.Instance.bootsSprite3;
                }
            case ItemName.Sword4:
                {
                    return ItemAssets.Instance.swordSprite4;
                }
            case ItemName.Helmet4:
                {
                    return ItemAssets.Instance.helmetSprite4;
                }
            case ItemName.Chestplate4:
                {
                    return ItemAssets.Instance.chestplateSprite4;
                }
            case ItemName.Pants4:
                {
                    return ItemAssets.Instance.pantsSprite4;
                }
            case ItemName.Boots4:
                {
                    return ItemAssets.Instance.bootsSprite4;
                }
            case ItemName.Sword5:
                {
                    return ItemAssets.Instance.swordSprite5;
                }
            case ItemName.Helmet5:
                {
                    return ItemAssets.Instance.helmetSprite5;
                }
            case ItemName.Chestplate5:
                {
                    return ItemAssets.Instance.chestplateSprite5;
                }
            case ItemName.Pants5:
                {
                    return ItemAssets.Instance.pantsSprite5;
                }
            case ItemName.Boots5:
                {
                    return ItemAssets.Instance.bootsSprite5;
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
            case ItemName.Sword2:
                return GladiatorEquiptment.SlotName.Sword;
            case ItemName.Helmet2:
                return GladiatorEquiptment.SlotName.Helmet;
            case ItemName.Boots2:
                return GladiatorEquiptment.SlotName.Boots;
            case ItemName.Sword3:
                return GladiatorEquiptment.SlotName.Sword;
            case ItemName.Helmet3:
                return GladiatorEquiptment.SlotName.Helmet;
            case ItemName.Chestplate3:
                return GladiatorEquiptment.SlotName.Chestplate;
            case ItemName.Pants3:
                return GladiatorEquiptment.SlotName.Pants;
            case ItemName.Boots3:
                return GladiatorEquiptment.SlotName.Boots;
            case ItemName.Sword4:
                return GladiatorEquiptment.SlotName.Sword;
            case ItemName.Helmet4:
                return GladiatorEquiptment.SlotName.Helmet;
            case ItemName.Chestplate4:
                return GladiatorEquiptment.SlotName.Chestplate;
            case ItemName.Pants4:
                return GladiatorEquiptment.SlotName.Pants;
            case ItemName.Boots4:
                return GladiatorEquiptment.SlotName.Boots;
            case ItemName.Sword5:
                return GladiatorEquiptment.SlotName.Sword;
            case ItemName.Helmet5:
                return GladiatorEquiptment.SlotName.Helmet;
            case ItemName.Chestplate5:
                return GladiatorEquiptment.SlotName.Chestplate;
            case ItemName.Pants5:
                return GladiatorEquiptment.SlotName.Pants;
            case ItemName.Boots5:
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
            case ItemName.Sword2:
                {
                    return 7;
                }
            case ItemName.Sword3:
                {
                    return 4;
                }
            case ItemName.Sword4:
                {
                    return 4;
                }
            case ItemName.Sword5:
                {
                    return 9;
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
            case ItemName.Helmet2:
                {
                    return 6;
                }
            case ItemName.Boots2:
                {
                    return 6;
                }
            case ItemName.Helmet3:
                {
                    return 5;
                }
            case ItemName.Chestplate3:
                {
                    return 9;
                }
            case ItemName.Pants3:
                {
                    return 5;
                }
            case ItemName.Boots3:
                {
                    return 2;
                }
            case ItemName.Helmet4:
                {
                    return 6;
                }
            case ItemName.Chestplate4:
                {
                    return 10;
                }
            case ItemName.Pants4:
                {
                    return 8;
                }
            case ItemName.Boots4:
                {
                    return 6;
                }
            case ItemName.Helmet5:
                {
                    return 4;
                }
            case ItemName.Chestplate5:
                {
                    return 6;
                }
            case ItemName.Pants5:
                {
                    return 5;
                }
            case ItemName.Boots5:
                {
                    return 4;
                }
            default:
                return 0;
        }
    }

    public int GetSellPrice()
    {
        Item item = new Item { itemName = itemName, amount = 1 };
        return (int)(this.GetBuyPrice() * 0.5f);
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
            case ItemName.Sword2:
                {
                    return 200;
                }
            case ItemName.Helmet2:
                {
                    return 80;
                }
            case ItemName.Boots2:
                {
                    return 75;
                }
            case ItemName.Sword3:
                {
                    return 150;
                }
            case ItemName.Helmet3:
                {
                    return 85;
                }
            case ItemName.Chestplate3:
                {
                    return 120;
                }
            case ItemName.Pants3:
                {
                    return 95;
                }
            case ItemName.Boots3:
                {
                    return 60;
                }
            case ItemName.Sword4:
                {
                    return 110;
                }
            case ItemName.Helmet4:
                {
                    return 75;
                }
            case ItemName.Chestplate4:
                {
                    return 140;
                }
            case ItemName.Pants4:
                {
                    return 125;
                }
            case ItemName.Boots4:
                {
                    return 60;
                }
            case ItemName.Sword5:
                {
                    return 220;
                }
            case ItemName.Helmet5:
                {
                    return 75;
                }
            case ItemName.Chestplate5:
                {
                    return 90;
                }
            case ItemName.Pants5:
                {
                    return 75;
                }
            case ItemName.Boots5:
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
                    return "A Thracian's sword and shield \nPower + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Helmet:
                {
                    return "A Thracian's helmet \nDefense + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Chestplate:
                {
                    return "A Thracian's chestplate \nDefense + 8\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Pants:
                {
                    return "A Thracian's leggings \nDefense + 7\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Boots:
                {
                    return "A Thracian's footware \nDefense + 4\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Sword2:
                {
                    return "A Samnite's sword and shield \nPower + 7\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Helmet2:
                {
                    return "A Samnite's helmet \nDefense + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Boots2:
                {
                    return "A Samnite's footware \nDefense + 4\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Sword3:
                {
                    return "A Secutor's twin swords \nPower + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Helmet3:
                {
                    return "A Secutor's helmet \nDefense + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Chestplate3:
                {
                    return "A Secutor's chestplate \nDefense + 8\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Pants3:
                {
                    return "A Secutor's leggings \nDefense + 7\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Boots3:
                {
                    return "A Secutor's footware \nDefense + 4\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Sword4:
                {
                    return "A Murmillo's sword and shield \nPower + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Helmet4:
                {
                    return "A Murmillo's helmet \nDefense + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Chestplate4:
                {
                    return "A Murmillo's chestplate \nDefense + 8\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Pants4:
                {
                    return "A Murmillo's leggings \nDefense + 7\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Boots4:
                {
                    return "A Murmillo's footware \nDefense + 4\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Sword5:
                {
                    return "A Dimachaerus's twin swords \nPower + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Helmet5:
                {
                    return "A Dimachaerus's helmet \nDefense + 5\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Chestplate5:
                {
                    return "A Dimachaerus's chestplate \nDefense + 8\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Pants5:
                {
                    return "A Dimachaerus's leggings \nDefense + 7\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            case ItemName.Boots5:
                {
                    return "A Dimachaerus's footware \nDefense + 4\nSell Price " + GetSellPrice() + "\nBuy Price " + GetBuyPrice();
                }
            default:
                return "";
        }
    }

    public string getClass() 
    {
        
        switch (itemName) 
        {
            case ItemName.Sword:
            case ItemName.Helmet:
            case ItemName.Chestplate:
            case ItemName.Pants:
            case ItemName.Boots:
                return "Thracian";
            case ItemName.Sword2:
            case ItemName.Helmet2:
            case ItemName.Boots2:
                return "Samnite";
            case ItemName.Sword3:
            case ItemName.Helmet3:
            case ItemName.Chestplate3:
            case ItemName.Pants3:
            case ItemName.Boots3:
                return "Secutor";
            case ItemName.Sword4:
            case ItemName.Helmet4:
            case ItemName.Chestplate4:
            case ItemName.Pants4:
            case ItemName.Boots4:
                return "Murmillo";
            case ItemName.Sword5:
            case ItemName.Helmet5:
            case ItemName.Chestplate5:
            case ItemName.Pants5:
            case ItemName.Boots5:
                return "Dimachaerus";
            default:
                return "Error, you shouldnt ever see this!";
        }
    }

}
