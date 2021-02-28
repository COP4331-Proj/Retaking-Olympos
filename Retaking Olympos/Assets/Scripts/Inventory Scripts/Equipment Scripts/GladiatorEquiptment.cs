using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GladiatorEquiptment : MonoBehaviour
{
    public UIEquiptment uIEquiptment;
    public HoldPlayerEquipment playerEquipment;
    public event EventHandler onEquipmentChange;
    public UIInventory uIInventory;
    public HoldGladiatorList holdGladiatorList;

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
        
        return playerEquipment.individualGladiatorEquipment[equipmentIndex].weapon;
    }
    public Item GetHelmet(int equipmentIndex)
    {
        return playerEquipment.individualGladiatorEquipment[equipmentIndex].helmet;
    }
    public Item GetChestplate(int equipmentIndex)
    {
        return playerEquipment.individualGladiatorEquipment[equipmentIndex].chestplate;
    }
    public Item GetLegs(int equipmentIndex)
    {
        return playerEquipment.individualGladiatorEquipment[equipmentIndex].legs;
    }
    public Item GetBoots(int equipmentIndex)
    {
        return playerEquipment.individualGladiatorEquipment[equipmentIndex].boots;
    }

    // Setters for item slots, called by test equip
    private void SetWeapon(Item weapon, int equipmentIndex)
    {
        if (weapon == null)
        {
            Item item = new Item { itemName = Item.ItemName.Sword };
            holdGladiatorList.gladiatorList[equipmentIndex].SetPower(holdGladiatorList.gladiatorList[equipmentIndex].GetPower() - item.GetPower());
        }
        else
        {
            holdGladiatorList.gladiatorList[equipmentIndex].SetPower(holdGladiatorList.gladiatorList[equipmentIndex].GetPower() + weapon.GetPower());
        }
        playerEquipment.individualGladiatorEquipment[equipmentIndex].weapon = weapon;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetHelmet(Item helmet, int equipmentIndex)
    {
        if (helmet == null)
        {
            Item item = new Item { itemName = Item.ItemName.Helmet };
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else
        {
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() + helmet.GetDefense());
        }
        playerEquipment.individualGladiatorEquipment[equipmentIndex].helmet = helmet;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetChestplate(Item chestplate, int equipmentIndex)
    {
        if (chestplate == null)
        {
            Item item = new Item { itemName = Item.ItemName.Chestplate };
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else
        {
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() + chestplate.GetDefense());
        }
        playerEquipment.individualGladiatorEquipment[equipmentIndex].chestplate = chestplate;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetLegs(Item legs, int equipmentIndex)
    {
        if (legs == null)
        {
            Item item = new Item { itemName = Item.ItemName.Pants };
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else
        {
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() + legs.GetDefense());
        }
        playerEquipment.individualGladiatorEquipment[equipmentIndex].legs = legs;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetBoots(Item boots, int equipmentIndex)
    {
        if (boots == null)
        {
            Item item = new Item { itemName = Item.ItemName.Boots };
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() - item.GetDefense());
        }
        else 
        {
            holdGladiatorList.gladiatorList[equipmentIndex].SetDefense(holdGladiatorList.gladiatorList[equipmentIndex].GetDefense() + boots.GetDefense());
        }
        playerEquipment.individualGladiatorEquipment[equipmentIndex].boots = boots;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }

    // Takes an item and equips it if it was dragged on the proper slot
    public void testEquip(SlotName slotName, Item item, int equipmentIndex) 
    {
        if (slotName == item.GetSlotName()) 
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
