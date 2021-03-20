using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GladiatorEquiptment : MonoBehaviour
{
    public UIEquiptment uIEquiptment;
    public HoldPlayerInformation playerInformation;
    public event EventHandler onEquipmentChange;
    public UIInventory uIInventory;

    public enum SlotName
    {
        Sword,
        Helmet,
        Chestplate,
        Pants,
        Boots,
    }

    // Getters for item slots
    public Item GetWeapon(int equipmentIndex)
    {
        
        return playerInformation.individualGladiatorEquipment[equipmentIndex].weapon;
    }
    public Item GetHelmet(int equipmentIndex)
    {
        return playerInformation.individualGladiatorEquipment[equipmentIndex].helmet;
    }
    public Item GetChestplate(int equipmentIndex)
    {
        return playerInformation.individualGladiatorEquipment[equipmentIndex].chestplate;
    }
    public Item GetLegs(int equipmentIndex)
    {
        return playerInformation.individualGladiatorEquipment[equipmentIndex].legs;
    }
    public Item GetBoots(int equipmentIndex)
    {
        return playerInformation.individualGladiatorEquipment[equipmentIndex].boots;
    }

    // Setters for item slots, called by test equip
    private void SetWeapon(Item weapon, int equipmentIndex)
    {
        if (weapon == null)
        {
            Item item = new Item { itemName = Item.ItemName.Sword };
            playerInformation.gladiatorList[equipmentIndex].SetPower(playerInformation.gladiatorList[equipmentIndex].GetPower() - item.GetPower());
        }
        else
        {
            playerInformation.gladiatorList[equipmentIndex].SetPower(playerInformation.gladiatorList[equipmentIndex].GetPower() + weapon.GetPower());
        }
        playerInformation.individualGladiatorEquipment[equipmentIndex].weapon = weapon;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetHelmet(Item helmet, int equipmentIndex)
    {
        if (helmet == null)
        {
            Item item = new Item { itemName = Item.ItemName.Helmet };
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else
        {
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() + helmet.GetDefense());
        }
        playerInformation.individualGladiatorEquipment[equipmentIndex].helmet = helmet;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetChestplate(Item chestplate, int equipmentIndex)
    {
        if (chestplate == null)
        {
            Item item = new Item { itemName = Item.ItemName.Chestplate };
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else
        {
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() + chestplate.GetDefense());
        }
        playerInformation.individualGladiatorEquipment[equipmentIndex].chestplate = chestplate;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetLegs(Item legs, int equipmentIndex)
    {
        if (legs == null)
        {
            Item item = new Item { itemName = Item.ItemName.Pants };
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else
        {
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() + legs.GetDefense());
        }
        playerInformation.individualGladiatorEquipment[equipmentIndex].legs = legs;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetBoots(Item boots, int equipmentIndex)
    {
        if (boots == null)
        {
            Item item = new Item { itemName = Item.ItemName.Boots };
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else 
        {
            playerInformation.gladiatorList[equipmentIndex].SetDefense(playerInformation.gladiatorList[equipmentIndex].GetDefense() + boots.GetDefense());
        }
        playerInformation.individualGladiatorEquipment[equipmentIndex].boots = boots;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }

    // Takes an item and equips it if it was dragged on the proper slot
    public int testEquip(SlotName slotName, Item item, int equipmentIndex) 
    {
        switch (slotName) 
        {
            case SlotName.Sword:
                if (GetWeapon(equipmentIndex) != null) 
                {
                    return -1;
                }
                break;
            case SlotName.Helmet:
                if (GetHelmet(equipmentIndex) != null)
                {
                    return -1;
                }
                break;
            case SlotName.Chestplate:
                if (GetChestplate(equipmentIndex) != null)
                {
                    return -1;
                }
                break;
            case SlotName.Pants:
                if (GetLegs(equipmentIndex) != null)
                {
                    return -1;
                }
                break;
            case SlotName.Boots:
                if (GetBoots(equipmentIndex) != null)
                {
                    return -1;
                }
                break;
            default:
                break;
        }

        if (slotName == item.GetSlotName()) 
        {
            if (item.getClass() == playerInformation.gladiatorList[equipmentIndex].GetClass()) 
            {
                uIInventory.inventory.RemoveItem(item);
                switch (slotName)
                {
                    default:
                    case SlotName.Sword:
                        SetWeapon(item, equipmentIndex);
                        break;
                    case SlotName.Helmet:
                        SetHelmet(item, equipmentIndex);
                        break;
                    case SlotName.Chestplate:
                        SetChestplate(item, equipmentIndex);
                        break;
                    case SlotName.Pants:
                        SetLegs(item, equipmentIndex);
                        break;
                    case SlotName.Boots:
                        SetBoots(item, equipmentIndex);
                        break;
                }
            }
        }
        return 0;
    }
    // Unequips an item by setting it to null
    public void Unequip(Item item, int equipmentIndex) 
    {
        switch (item.itemName) 
        {
            default:
            case Item.ItemName.Sword:
                SetWeapon(null, equipmentIndex);
                break;
            case Item.ItemName.Helmet:
                SetHelmet(null, equipmentIndex);
                break;
            case Item.ItemName.Chestplate:
                SetChestplate(null, equipmentIndex);
                break;
            case Item.ItemName.Pants:
                SetLegs(null, equipmentIndex);
                break;
            case Item.ItemName.Boots:
                SetBoots(null, equipmentIndex);
                break;
        }
    }
}
