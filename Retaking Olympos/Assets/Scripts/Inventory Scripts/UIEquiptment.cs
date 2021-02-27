using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIEquiptment : MonoBehaviour
{
    UIEquipmentSlots helmetSlot;
    UIEquipmentSlots chestSlot;
    UIEquipmentSlots legsSlot;
    UIEquipmentSlots bootsSlot;
    UIEquipmentSlots weaponSlot;

    public GladiatorEquiptment gladiatorEquiptment;
    public HoldPlayerInventory holdPlayerInventory;
    Transform itemContainer;
    Transform itemTemplate;

    private void Awake()
    {

        itemContainer = transform.Find("itemContainerEquipment");
        itemTemplate = transform.Find("itemTemplate");

        helmetSlot = transform.Find("Helmet Slot").GetComponent<UIEquipmentSlots>();
        chestSlot = transform.Find("Chest Slot").GetComponent<UIEquipmentSlots>();
        legsSlot = transform.Find("Legs Slot").GetComponent<UIEquipmentSlots>();
        bootsSlot = transform.Find("Boots Slot").GetComponent<UIEquipmentSlots>();
        weaponSlot = transform.Find("Weapon Slot").GetComponent<UIEquipmentSlots>();

        weaponSlot.OnItemDropped += weaponSlot_OnItemDropped;
        helmetSlot.OnItemDropped += helmetSlot_OnItemDropped;
        chestSlot.OnItemDropped += chestSlot_OnItemDropped;
        legsSlot.OnItemDropped += legsSlot_OnItemDropped;
        bootsSlot.OnItemDropped += bootsSlot_OnItemDropped;
    }

    private void bootsSlot_OnItemDropped(object sender, UIEquipmentSlots.OnItemDroppedEventArgs e)
    {

        gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Boots, e.item);
        UpdateItem();
    }

    private void legsSlot_OnItemDropped(object sender, UIEquipmentSlots.OnItemDroppedEventArgs e)
    {

        gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Pants, e.item);
        UpdateItem();
    }

    private void chestSlot_OnItemDropped(object sender, UIEquipmentSlots.OnItemDroppedEventArgs e)
    {

        gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Chestplate, e.item);
        UpdateItem();
    }

    private void helmetSlot_OnItemDropped(object sender, UIEquipmentSlots.OnItemDroppedEventArgs e)
    {

        gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Helmet, e.item);
        UpdateItem();
    }

    private void weaponSlot_OnItemDropped(object sender, UIEquipmentSlots.OnItemDroppedEventArgs e)
    {

        gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, e.item);
        UpdateItem();
        
    }

    public void SetEquipment(GladiatorEquiptment gladiatorEquiptment) 
    {
        this.gladiatorEquiptment = gladiatorEquiptment;
        UpdateItem();

        gladiatorEquiptment.onEquipmentChange += CharacterEquipment_OnEquipmentChange;
    }

    private void CharacterEquipment_OnEquipmentChange(object sender, EventArgs e)
    {
        
        UpdateItem();
    }

    private void UpdateItem() 
    {
        itemContainer = transform.Find("itemContainerEquipment");
        itemTemplate = transform.Find("itemTemplate");

        foreach (Transform child in itemContainer) 
        {
            Destroy(child.gameObject);
        }

        Item weapon = gladiatorEquiptment.GetWeapon();
        if (weapon != null)
        {
            Transform itemTransform = Instantiate(itemTemplate, itemContainer);
            itemTransform.gameObject.SetActive(true);

            Image spriteImage = itemTransform.Find("Image").GetComponent<Image>();
            spriteImage.sprite = weapon.GetSprite();

            TextMeshProUGUI amountText = itemTransform.Find("amountText").GetComponent<TextMeshProUGUI>();
            amountText.SetText("");

            itemTransform.GetComponent<RectTransform>().anchoredPosition = weaponSlot.GetComponent<RectTransform>().anchoredPosition;
            UIDragAndDropItem uiItem = itemTransform.GetComponent<UIDragAndDropItem>();

            uiItem.SetItem(weapon);
            itemTransform.gameObject.GetComponent<ItemGameObject>().item = weapon;
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }
        else 
        {
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }

        Item chestplate = gladiatorEquiptment.GetChestplate();
        if (chestplate != null)
        {
            Transform itemTransform = Instantiate(itemTemplate, itemContainer);
            itemTransform.gameObject.SetActive(true);

            Image spriteImage = itemTransform.Find("Image").GetComponent<Image>();
            spriteImage.sprite = chestplate.GetSprite();

            TextMeshProUGUI amountText = itemTransform.Find("amountText").GetComponent<TextMeshProUGUI>();
            amountText.SetText("");

            itemTransform.GetComponent<RectTransform>().anchoredPosition = chestSlot.GetComponent<RectTransform>().anchoredPosition;
            UIDragAndDropItem uiItem = itemTransform.GetComponent<UIDragAndDropItem>();

            uiItem.SetItem(chestplate);
            itemTransform.gameObject.GetComponent<ItemGameObject>().item = chestplate;
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }
        else
        {
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }

        Item helmet = gladiatorEquiptment.GetHelmet();
        if (helmet != null)
        {
            Transform itemTransform = Instantiate(itemTemplate, itemContainer);
            itemTransform.gameObject.SetActive(true);

            Image spriteImage = itemTransform.Find("Image").GetComponent<Image>();
            spriteImage.sprite = helmet.GetSprite();

            TextMeshProUGUI amountText = itemTransform.Find("amountText").GetComponent<TextMeshProUGUI>();
            amountText.SetText("");

            itemTransform.GetComponent<RectTransform>().anchoredPosition = helmetSlot.GetComponent<RectTransform>().anchoredPosition;
            UIDragAndDropItem uiItem = itemTransform.GetComponent<UIDragAndDropItem>();

            uiItem.SetItem(helmet);
            itemTransform.gameObject.GetComponent<ItemGameObject>().item = helmet;
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }
        else
        {
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }

        Item legs = gladiatorEquiptment.GetLegs();
        if (legs != null)
        {
            Transform itemTransform = Instantiate(itemTemplate, itemContainer);
            itemTransform.gameObject.SetActive(true);

            Image spriteImage = itemTransform.Find("Image").GetComponent<Image>();
            spriteImage.sprite = legs.GetSprite();

            TextMeshProUGUI amountText = itemTransform.Find("amountText").GetComponent<TextMeshProUGUI>();
            amountText.SetText("");

            itemTransform.GetComponent<RectTransform>().anchoredPosition = legsSlot.GetComponent<RectTransform>().anchoredPosition;
            UIDragAndDropItem uiItem = itemTransform.GetComponent<UIDragAndDropItem>();

            uiItem.SetItem(legs);
            itemTransform.gameObject.GetComponent<ItemGameObject>().item = legs;
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }
        else
        {
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }

        Item boots = gladiatorEquiptment.GetBoots();
        if (boots != null)
        {
            Transform itemTransform = Instantiate(itemTemplate, itemContainer);
            itemTransform.gameObject.SetActive(true);

            Image spriteImage = itemTransform.Find("Image").GetComponent<Image>();
            spriteImage.sprite = boots.GetSprite();

            TextMeshProUGUI amountText = itemTransform.Find("amountText").GetComponent<TextMeshProUGUI>();
            amountText.SetText("");

            itemTransform.GetComponent<RectTransform>().anchoredPosition = bootsSlot.GetComponent<RectTransform>().anchoredPosition;
            UIDragAndDropItem uiItem = itemTransform.GetComponent<UIDragAndDropItem>();

            uiItem.SetItem(boots);
            itemTransform.gameObject.GetComponent<ItemGameObject>().item = boots;
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }
        else
        {
            //weaponSlot.transform.Find("defaultImage").gameObject.SetActive(false);
        }
    }
}
