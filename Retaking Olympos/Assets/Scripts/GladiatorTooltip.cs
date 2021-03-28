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
    private Gladiator cassius;
    private Gladiator marcus;
    private Gladiator silvanus;
    private Gladiator verus;
    private Gladiator tetraites;
    private Button currButton;

    // Start is called before the first frame update
    void Start()
    {
        Tharcian CarpophorusTemp = new Tharcian("Carpophorus", 1);
        carpophorus = new Gladiator(CarpophorusTemp.GetName(), CarpophorusTemp.GetLevel(), CarpophorusTemp.GetHealth(), CarpophorusTemp.GetStamina(), CarpophorusTemp.GetPower(), CarpophorusTemp.GetDefense());
        Samnite CommodusTemp = new Samnite("Commodus", 4);
        commodus = new Gladiator(CommodusTemp.GetName(), CommodusTemp.GetLevel(), CommodusTemp.GetHealth(), CommodusTemp.GetStamina(), CommodusTemp.GetPower(), CommodusTemp.GetDefense());
        Secutor CrixusTemp = new Secutor("Crixus", 5);
        crixus = new Gladiator(CrixusTemp.GetName(), CrixusTemp.GetLevel(), CrixusTemp.GetHealth(), CrixusTemp.GetStamina(), CrixusTemp.GetPower(), CrixusTemp.GetDefense());
        Murmillo FlammaTemp = new Murmillo("Flamma", 6);
        flamma = new Gladiator(FlammaTemp.GetName(), FlammaTemp.GetLevel(), FlammaTemp.GetHealth(), FlammaTemp.GetStamina(), FlammaTemp.GetPower(), FlammaTemp.GetDefense());
        Dimachaerus SpartacusTemp = new Dimachaerus("Spartacus", 10);
        spartacus = new Gladiator(SpartacusTemp.GetName(), SpartacusTemp.GetLevel(), SpartacusTemp.GetHealth(), SpartacusTemp.GetStamina(), SpartacusTemp.GetPower(), SpartacusTemp.GetDefense());

        Tharcian CassiusTemp = new Tharcian("Cassius", 2);
        cassius = new Gladiator(CassiusTemp.GetName(), CassiusTemp.GetLevel(), CassiusTemp.GetHealth(), CassiusTemp.GetStamina(), CassiusTemp.GetPower(), CassiusTemp.GetDefense());
        Samnite MarcusTemp = new Samnite("Marcus", 4);
        marcus = new Gladiator(MarcusTemp.GetName(), MarcusTemp.GetLevel(), MarcusTemp.GetHealth(), MarcusTemp.GetStamina(), MarcusTemp.GetPower(), MarcusTemp.GetDefense());
        Secutor SilvanusTemp = new Secutor("Silvanus", 5);
        silvanus = new Gladiator(SilvanusTemp.GetName(), SilvanusTemp.GetLevel(), SilvanusTemp.GetHealth(), SilvanusTemp.GetStamina(), SilvanusTemp.GetPower(), SilvanusTemp.GetDefense());
        Murmillo VerusTemp = new Murmillo("Verus", 6);
        verus = new Gladiator(VerusTemp.GetName(), VerusTemp.GetLevel(), VerusTemp.GetHealth(), VerusTemp.GetStamina(), VerusTemp.GetPower(), VerusTemp.GetDefense());
        Dimachaerus TetraitesTemp = new Dimachaerus("Tetraites", 10);
        tetraites = new Gladiator(TetraitesTemp.GetName(), TetraitesTemp.GetLevel(), TetraitesTemp.GetHealth(), TetraitesTemp.GetStamina(), TetraitesTemp.GetPower(), TetraitesTemp.GetDefense());

        /*        carpophorus = new Gladiator("Carpophorus", 1, 100, 100, 17, 8);
                crixus = new Gladiator("Commodus", 4, 150, 100, 24, 18);
                commodus = new Gladiator("Crixus", 5, 110, 100, 28, 25);
                flamma = new Gladiator("Flamma", 6, 200, 100, 21, 34);
                spartacus = new Gladiator("Spartacus", 10, 300, 100, 76, 24);*/
    }

    // When a pointer hovers over the item
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        Gladiator currGladiator = null;
        currButton = eventData.pointerCurrentRaycast.gameObject.transform.parent.gameObject.GetComponent<Button>();
        
        switch (currButton.name)
        {
            case "Carpophorus Button":
                Debug.Log("NOT HERE");
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
            case "Cassius Button":
                Debug.Log("HERE");
                currGladiator = cassius;
                break;
            case "Marcus Button":
                currGladiator = marcus;
                break;
            case "Silvanus Button":
                currGladiator = silvanus;
                break;
            case "Verus Button":
                currGladiator = verus;
                break;
            case "Tetraites Button":
                currGladiator = tetraites;
                break;
        }

        if (currGladiator == null)
        {
            Debug.Log("Null");
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
