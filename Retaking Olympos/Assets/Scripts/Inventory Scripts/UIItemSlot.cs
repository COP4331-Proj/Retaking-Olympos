using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Script attatched to item slots
public class UIItemSlot : MonoBehaviour, IDropHandler
{
    // When item is dropped on slot, snap it to the middle
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null) 
        {
            
        }
    }


}
