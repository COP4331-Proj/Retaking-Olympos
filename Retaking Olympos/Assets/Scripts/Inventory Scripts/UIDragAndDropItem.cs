using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Allows for item to be dragged and dropped
public class UIDragAndDropItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    RectTransform rectTransform;
    Canvas canvas;
    CanvasGroup canvasGroup;
    Item item;
    // Create instance of drag and drop item so we can remember what item is being dragged
    public static UIDragAndDropItem instance;

    public UIInventory uIInventory;
    public UIEquiptment uIEquiptment;
    [SerializeField] UIInventoryControler uIInventoryControler;

    bool dragable = true;
    bool beingDragged = false;

    private void Awake()
    {
        instance = this;
        uIEquiptment = GetComponentInParent<UIEquiptment>();
        // Sets items equiped to not be dragable 
        if (transform.Find("isNotDragable") != null) 
        {
            dragable = false;
        }

        if (uIInventoryControler == null) 
        {
            uIInventoryControler = GameObject.FindObjectOfType<UIInventoryControler>();
        }
        rectTransform = GetComponent<RectTransform>();
        canvas = FindObjectOfType<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // When mouse button is released
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        beingDragged = false;
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
            // Hitbox is not exactly alligned with sprite, if the user clicks on the very edge of item, event data is null
            if (eventData.pointerCurrentRaycast.gameObject == null)
            {
                return;
            }

            item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemClickable>().item;
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
            // unequip Item
            // if right click on item in inventory, unequip it and add a copy to the inventory
            GetComponent<ItemClickable>().onRightClick = () =>
            {
                Item item = new Item();
                item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemClickable>().item;

                if (!item.isShop)
                {
                    uIEquiptment.playerInformation.playerInventory.AddItem(new Item { itemName = item.itemName, amount = 1 });
                    uIEquiptment.gladiatorEquiptment.Unequip(item, uIEquiptment.gladiatorIndex);
                    Destroy(gameObject);
                }
            };
        }
    }

    // While being dragged
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        beingDragged = true;
        if (dragable)
        {
            // This * 0.9f should cancel out the canvas scale factor but it doesnt and makes the item correctly follow the mouse
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor * 0.9f;
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

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemClickable>().item;
        if (!beingDragged && dragable)
        {
            
            uIInventoryControler.ShowToolTip(transform.position, item);

        }
        else if (item.isShop) 
        {
            uIInventoryControler.ShowToolTip(transform.position, item);
        }
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        uIInventoryControler.HideToolTip();
    }
}
