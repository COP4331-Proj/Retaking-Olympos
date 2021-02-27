using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
public class UIEquipmentSlots : MonoBehaviour, IDropHandler
{
    //Event for when item is dropped
    public event EventHandler<OnItemDroppedEventArgs> OnItemDropped;

    public class OnItemDroppedEventArgs : EventArgs 
    {
        public Item item;
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        
        Item item = UIDragAndDropItem.instance.GetItem();
        OnItemDropped?.Invoke(this, new OnItemDroppedEventArgs { item = item });
        UIDragAndDropItem.instance.SetItem(item);
    }
}
