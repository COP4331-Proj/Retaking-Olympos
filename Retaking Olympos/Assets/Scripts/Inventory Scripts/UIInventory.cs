using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Class used to interface Inventory object and unity engine / UI
public class UIInventory : MonoBehaviour
{
    public PlayerInventory inventory;
    // Position of the template for an item in the inventory,
    // and the empty game object to hold the clones of it
    Transform itemContainer;
    Transform itemTemplate;


    private void Awake()
    {

        itemContainer = transform.Find("itemContainer");
        itemTemplate = transform.Find("itemTemplate");

    }
    // Set local reference of inventory and add it to the event system
    public void SetInventory(PlayerInventory inventory) 
    {

        
        this.inventory = inventory;
        inventory.UpdateItemList += Inventory_UpdateItemList;
        if (inventory.GetItemList().Count == 0)
        {
            inventory.PopulateWithItems();
        }
        RefreshInventory();
    }
    // On the event, refresh the inventory visuals
    private void Inventory_UpdateItemList(object sender, EventArgs e)
    {
        RefreshInventory();
    }

    public void RefreshInventory() 
    {
        // Refind itemContainer and itemTemplate
        itemContainer = transform.Find("itemContainer");
        itemTemplate = transform.Find("itemTemplate");

        // Delete all item icons except for the template
        foreach (Transform child in itemContainer)
        {
            if (child == itemTemplate)
            {
                continue;
            }
            else 
            {
                Destroy(child.gameObject);
            }

        }

        int xPos = 0;
        int yPos = 0;
        float itemSlotSize = 45f;
        // For each item in the inventory
        foreach (Item item in inventory.GetItemList()) 
        {
            // Create new copy from itemTemplate under itemContainer
            RectTransform itemSlotRectTransform = Instantiate(itemTemplate, itemContainer).GetComponent<RectTransform>();
            // Sets object to be active, template which is copied is hidden
            itemSlotRectTransform.gameObject.SetActive(true);
            
            // On right click
            itemSlotRectTransform.GetComponent<ItemGameObject>().onRightClick = () =>
            {
                
                inventory.RemoveItem(item);
            };

            // On left click
            itemSlotRectTransform.GetComponent<ItemGameObject>().onLeftClick = () =>
            {
            };

            // Get position of next item slot by multiplying its number by the size of the slot in pixels
            itemSlotRectTransform.anchoredPosition = new Vector2(xPos * itemSlotSize, yPos * itemSlotSize);

            itemSlotRectTransform.gameObject.GetComponent<ItemGameObject>().item = item;

            // Set sprite to item sprite
            Image spriteImage = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            spriteImage.sprite = item.GetSprite();
            // Set text displaying amount
            TextMeshProUGUI amountText = itemSlotRectTransform.Find("amountText").GetComponent<TextMeshProUGUI>();
            
            if (item.amount > 1)
            {
                amountText.SetText(item.amount.ToString());
            }
            
            else 
            {
                amountText.SetText("");
            }

            // Increment position in the inventory to the right
            xPos++;
            // if we are at the right edge, reset and move down a row
            if (xPos > 3) 
            {
                xPos = 0;
                yPos--;
            }
            
        }
    }
    // Nessicary to unsubscribe from event to prevent broken references when reloading scene
    private void OnDestroy()
    {
        inventory.UpdateItemList -= Inventory_UpdateItemList;
    }
}
