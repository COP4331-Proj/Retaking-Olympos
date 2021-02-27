using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GladiatorEquiptment : MonoBehaviour
{
    public UIEquiptment uIEquiptment;
    public PlayerEquipment playerEquipment;
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

    private void Awake()
    {

    }

    public Item GetWeapon()
    {
        return playerEquipment.individualGladiatorEquipment.weapon;
    }
    public Item GetHelmet()
    {
        return playerEquipment.individualGladiatorEquipment.helmet;
    }
    public Item GetChestplate()
    {
        return playerEquipment.individualGladiatorEquipment.chestplate;
    }
    public Item GetLegs()
    {
        return playerEquipment.individualGladiatorEquipment.legs;
    }
    public Item GetBoots()
    {
        return playerEquipment.individualGladiatorEquipment.boots;
    }

    private void SetWeapon(Item weapon)
    {
        playerEquipment.individualGladiatorEquipment.weapon = weapon;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetHelmet(Item helmet)
    {
        playerEquipment.individualGladiatorEquipment.helmet = helmet;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetChestplate(Item chestplate)
    {
        playerEquipment.individualGladiatorEquipment.chestplate = chestplate;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetLegs(Item legs)
    {
        playerEquipment.individualGladiatorEquipment.legs = legs;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }
    private void SetBoots(Item boots)
    {
        playerEquipment.individualGladiatorEquipment.boots = boots;
        uIEquiptment.SetEquipment(this);
        onEquipmentChange?.Invoke(this, EventArgs.Empty);
    }

    public void testEquip(SlotName slotName, Item item) 
    {
        if (slotName == item.GetSlotName()) 
        {
            uIInventory.inventory.RemoveItem(item);
            switch (slotName) 
            {
                default:
                case SlotName.Sword:
                    SetWeapon(item);
                    break;
                case SlotName.Helmet:
                    SetHelmet(item);
                    break;
                case SlotName.Chestplate:
                    SetChestplate(item);
                    break;
                case SlotName.Pants:
                    SetLegs(item);
                    break;
                case SlotName.Boots:
                    SetBoots(item);
                    break;
            }
        }
    }

    public void Unequip(Item item) 
    {
        switch (item.itemName) 
        {
            default:
            case Item.ItemName.Sword:
                SetWeapon(null);
                break;
            case Item.ItemName.Helmet:
                SetHelmet(null);
                break;
            case Item.ItemName.Chestplate:
                SetChestplate(null);
                break;
            case Item.ItemName.Pants:
                SetLegs(null);
                break;
            case Item.ItemName.Boots:
                SetBoots(null);
                break;
        }
    }
}
