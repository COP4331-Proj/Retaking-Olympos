using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

// Declares actions that an item icon can have performed on it, used in UIInventory
public class ItemGameObject : MonoBehaviour, IPointerClickHandler 
{
    public Action onLeftClick;
    public Action onRightClick;
    public Item item;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == 0)
        {
            
            onLeftClick();
        }
        else
        {
            onRightClick();
        }
    }
}
