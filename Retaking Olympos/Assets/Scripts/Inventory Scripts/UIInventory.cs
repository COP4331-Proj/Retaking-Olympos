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
    public HoldPlayerInformation playerInformation;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] sounds;

    private void Awake()
    {
        
        itemContainer = transform.Find("itemContainer");
        itemTemplate = transform.Find("itemTemplate");
    }
    // Set local reference of inventory and add it to the event system
    // true if this is a player inventory, false if shop inventory
    public void SetInventory(PlayerInventory inventory, bool playerOrShop) 
    {
        this.inventory = inventory;
        inventory.UpdateItemList += Inventory_UpdateItemList;
        if (inventory.GetItemList().Count == 0 )
        {
            if (playerOrShop)
            {
                //inventory.PopulateWithItems();

            }
            else 
            {
                inventory.PopulateWithShopItems();
            }
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
            itemSlotRectTransform.GetComponent<ItemClickable>().onRightClick = () =>
            {
                // If item is in inventory, remove
                if (!item.isShop)
                {
                    if (sounds!= null) 
                    {
                        audioSource.PlayOneShot(sounds[0]);
                    }
                    playerInformation.gold += item.GetSellPrice();
                    inventory.RemoveItem(item);
                }
            };

            // On left click
            itemSlotRectTransform.GetComponent<ItemClickable>().onLeftClick = () =>
            {
                if (item.isShop)
                {
                    TestBuy(item);
                }
                else 
                {

                }
            };

            // Get position of next item slot by multiplying its number by the size of the slot in pixels
            itemSlotRectTransform.anchoredPosition = new Vector2(xPos * itemSlotSize, yPos * itemSlotSize);

            itemSlotRectTransform.gameObject.GetComponent<ItemClickable>().item = item;

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

    // Check if the player has enough money to buy the item
    private void TestBuy(Item item)
    {
        
        if (item.GetBuyPrice() < playerInformation.gold) 
        {
            audioSource.PlayOneShot(sounds[1]);
            playerInformation.gold -= item.GetBuyPrice();
            playerInformation.playerInventory.AddItem(new Item {itemName = item.itemName, amount = 1, isShop = false });
        }
    }



    // Nessicary to unsubscribe from event to prevent broken references when reloading scene
    private void OnDestroy()
    {
        if (inventory != null) 
        {
            inventory.UpdateItemList -= Inventory_UpdateItemList;
        }
    }
}
