using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GladiatorTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ToolTipControler toolTipControler;
    private Gladiator carpophorus;
    private Gladiator crixus;
    private Gladiator commodus;
    private Gladiator flamma;
    private Gladiator spartacus;
    private Button currButton;

    // Start is called before the first frame update
    void Start()
    {
        carpophorus = new Gladiator("Carpophorus", 1, 100, 100, 5, 5);
        crixus = new Gladiator("Crixus", 2, 110, 100, 6, 6);
        commodus = new Gladiator("Commodus", 4, 150, 100, 7, 7);
        flamma = new Gladiator("Flamma", 6, 200, 100, 10, 8);
        spartacus = new Gladiator("Spartacus", 10, 300, 100, 20, 10);
    }

    // When a pointer hovers over the item
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        Gladiator currGladiator = null;
        currButton = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<Button>();

        switch (currButton.name)
        {
            case "Carpophorus Button":
                currGladiator = carpophorus;
                break;
            case "Crixus Button":
                currGladiator = crixus;
                break;
            case "Commodus Button":
                currGladiator = commodus;
                break;
            case "Flamma Button":
                currGladiator = flamma;
                break;
            case "Spartacus Button":
                currGladiator = spartacus;
                break;
        }

        if (currGladiator == null)
        {
            return;
        }

        toolTipControler.ShowToolTip(transform.position, currGladiator);
    }

    // When pointer leaves the item
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        toolTipControler.HideToolTip();
    }
}
