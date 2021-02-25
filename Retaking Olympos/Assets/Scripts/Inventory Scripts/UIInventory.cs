using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIInventory : MonoBehaviour
{
    public PlayerInventory inventory;
    Transform itemSlotContainer;
    Transform itemSlotTemplate;

    private void Start()
    {
        if (inventory.GetItemList().Count == 0)
        {
            inventory.PopulateWithItems();
        }
    }

    private void Awake()
    {


        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = transform.Find("itemSlotTemplate");

    }
    public void SetInventory(PlayerInventory inventory) 
    {
        this.inventory = inventory;

        inventory.UpdateItemList += Inventory_UpdateItemList;

        RefreshInventory();
    }
    private void Inventory_UpdateItemList(object sender, EventArgs e)
    {
        RefreshInventory();
    }
    public void RefreshInventory() 
    {

        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = transform.Find("itemSlotTemplate");
        if (itemSlotContainer == null)
        {
            Debug.Log("Scream");
        }
        foreach (Transform child in itemSlotContainer)
        {
            if (child == itemSlotTemplate)
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
        foreach (Item item in inventory.GetItemList()) 
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            itemSlotRectTransform.GetComponent<ItemGameObject>().onRightClick = () =>
            {

            };

            itemSlotRectTransform.GetComponent<ItemGameObject>().onLeftClick = () =>
            {
                inventory.RemoveItem(item);
            };

            itemSlotRectTransform.anchoredPosition = new Vector2(xPos * itemSlotSize, yPos * itemSlotSize);
            
            Image spriteImage = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            spriteImage.sprite = item.GetSprite();
            TextMeshProUGUI amountText = itemSlotRectTransform.Find("amountText").GetComponent<TextMeshProUGUI>();
            
            if (item.amount > 1)
            {
                amountText.SetText(item.amount.ToString());
            }
            
            else 
            {
                amountText.SetText("");
            }

            xPos++;
            if (xPos > 3) 
            {
                xPos = 0;
                yPos--;
            }
        }
    }
    private void OnDestroy()
    {
        inventory.UpdateItemList -= Inventory_UpdateItemList;
    }
}
