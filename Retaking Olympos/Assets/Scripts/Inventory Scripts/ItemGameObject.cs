using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ItemGameObject : MonoBehaviour, IPointerClickHandler 
{
    public Action onLeftClick;
    public Action onRightClick;

    void Awake()
    {
    }

    void Update()
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        onLeftClick();
    }
}
