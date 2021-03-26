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
        carpophorus = new Gladiator("Carpophorus", 1, 100, 100, 17, 8);
        crixus = new Gladiator("Commodus", 4, 150, 100, 24, 18);
        commodus = new Gladiator("Crixus", 5, 110, 100, 28, 25);
        flamma = new Gladiator("Flamma", 6, 200, 100, 21, 34);
        spartacus = new Gladiator("Spartacus", 10, 300, 100, 76, 24);
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
