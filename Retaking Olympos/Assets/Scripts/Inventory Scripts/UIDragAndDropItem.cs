using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Allows for item to be dragged and dropped
public class UIDragAndDropItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rectTransform;
    Canvas canvas;
    CanvasGroup canvasGroup;
    Item item;
    // Create instance of drag and drop item so we can remember what item is being dragged
    public static UIDragAndDropItem instance;

    public UIInventory uIInventory;
    public UIEquiptment uIEquiptment;

    bool dragable = true;


    private void Awake()
    {
        instance = this;
        uIEquiptment = GetComponentInParent<UIEquiptment>();
        // Sets items equiped to not be dragable 
        if (transform.Find("isNotDragable") != null) 
        {
            dragable = false;
        }

        rectTransform = GetComponent<RectTransform>();
        canvas = FindObjectOfType<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // When mouse button is released
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {

        if (dragable) 
        {
            canvasGroup.alpha = 1f;
            canvasGroup.blocksRaycasts = true;

            uIInventory.RefreshInventory();
            Destroy(gameObject);
        }
    }
    
    // When mouse is pressed and moved a little amount
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        // If dragable, set transparent and remember what item is being dragged
        if (dragable) 
        {
            Item item = new Item();
            item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemGameObject>().item;
            instance.SetItem(item);
            canvasGroup.alpha = .5f;
            canvasGroup.blocksRaycasts = true;
        }
    }
    // When mouse is pressed
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (!dragable)
        {
            // if right click on item in inventory, unequip it and add a copy to the inventory
            GetComponent<ItemGameObject>().onRightClick = () =>
            {
                Item item = new Item();
                item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemGameObject>().item;

                uIEquiptment.holdPlayerInventory.playerInventory.AddItem(new Item { itemName = item.itemName, amount = 1 });
                uIEquiptment.gladiatorEquiptment.Unequip(item, uIEquiptment.gladiatorIndex);
                Destroy(gameObject);
            };
        }
    }

    // While being dragged
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (dragable)
        {
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }
    
    public void SetItem(Item item)
    {
        
        this.item = item;
    }
    public Item GetItem()
    {
        return item;
    }
}
