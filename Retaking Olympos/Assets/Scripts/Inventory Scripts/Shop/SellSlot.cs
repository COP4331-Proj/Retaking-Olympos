using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class SellSlot : MonoBehaviour, IDropHandler
{
    public event EventHandler<OnItemDroppedEventArgs> OnItemDropped;

    public class OnItemDroppedEventArgs : EventArgs
    {
        public Item item;
    }

    // When item is dripped, pass along the slot that it was passed on and the item from UIDragAndDropItem.instance
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        
        Item item = UIDragAndDropItem.instance.GetItem();
        OnItemDropped?.Invoke(this, new OnItemDroppedEventArgs { item = item });
        UIDragAndDropItem.instance.SetItem(item);
    }
}
