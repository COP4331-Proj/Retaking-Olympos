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
    public ToolTipControler toolTipControler;
    [SerializeField] UIInventoryControler uIInventoryControler;

    bool dragable = true;
    bool beingDragged = false;


    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

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
        toolTipControler = FindObjectOfType<ToolTipControler>();
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
            // Prevents a null ref error when left clicking equipped items
            if (!item.isShop) 
            {
                GetComponent<ItemClickable>().onLeftClick = () =>
                {
                    // Do nothing
                };
            }
            }
        else 
        {
            // Check for double click
            clicked++;

            if (clicked == 1) 
            {
                clicktime = Time.time;
            }
            // Double click detected
            if (clicked > 1 && Time.time - clicktime < clickdelay)
            {
                
                clicked = 0;
                clicktime = 0;
                item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemClickable>().item;
                instance.SetItem(item);
                if (uIEquiptment == null)
                {
                    uIEquiptment = FindObjectOfType<UIEquiptment>();
                }
                uIEquiptment.gladiatorEquiptment.testEquip(item.GetSlotName(), item, uIEquiptment.gladiatorIndex);
            }
            else if (clicked > 2 || Time.time - clicktime > 1) 
            {
                clicked = 0;
            }
                
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


    // When a pointer hovers over the item
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemClickable>().item;

        // If item isnt currently being dragged and is able to be dragged, i.e. is in the players inventory
        // This excludes tooltips for equipped items and items being moved
        if (!beingDragged && dragable)
        {

            toolTipControler.ShowToolTip(transform.position, item);

        }
        // also show tooltip for items in the shop
        else if (item.isShop) 
        {
            toolTipControler.ShowToolTip(transform.position, item);
        }


    }

    // When pointer leaves the item
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        toolTipControler.HideToolTip();
    }


}
