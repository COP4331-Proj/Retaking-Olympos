using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragAndDropItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rectTransform;
    Canvas canvas;
    CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = FindObjectOfType<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("3");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;


    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("2");
        canvasGroup.alpha = .5f;
        canvasGroup.blocksRaycasts = false;
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("1");
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; 
    }

}
