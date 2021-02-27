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
    public UIInventory uIInventory;
    public static UIDragAndDropItem instance;
    public UIEquiptment uIEquiptment;
    bool dragable = true;


    private void Awake()
    {
        instance = this;
        uIEquiptment = GetComponentInParent<UIEquiptment>();
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

            //uIInventory.inventory.RemoveItem(instance.item);

            uIInventory.RefreshInventory();
            Destroy(gameObject);
        }
    }
    
    // When mouse is pressed and moved a little amount
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {

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

            GetComponent<ItemGameObject>().onRightClick = () =>
            {
                Item item = new Item();
                item = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<ItemGameObject>().item;

                uIEquiptment.holdPlayerInventory.playerInventory.AddItem(new Item { itemName = item.itemName, amount = 1 });
                uIEquiptment.gladiatorEquiptment.Unequip(item);
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

    private void Update()
    {

        
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
