using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Better name for this class would be along the line of main gladiator controler
// Dont want to rename until I make sure it wont mess anyone else up
public class ViewGladiator: MonoBehaviour
{
    public HoldPlayerInformation holdPlayerInformation;
    // Creates two dummy gladiators to show the system working
    private void Start()
    {
        if (holdPlayerInformation.gladiatorList.Count == 0) 
        {
            /*            createNewGladiator("Caesar", 3, 100, 100, 6, 14);
                        createNewGladiator("Bob", 4, 120, 120, 10, 12);*/
            createNewGladiator("Caesar", 3, 0);
            createNewGladiator("Bob", 4, 1);
        }
    }

    // Creates new gladiator, returns it, and addes it to the gladiator list
    public Gladiator createNewGladiator(string name, int level, int health, int stamina, int power, int defense)
    {
        Gladiator gladiator;
        gladiator = new Gladiator(name, level, health, stamina, power, defense);
        holdPlayerInformation.gladiatorList.Add(gladiator);
        holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
        return gladiator;
    }
    public Gladiator createNewGladiator(string name, int level, int gladiatorClass)
    {
        holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
        switch (gladiatorClass)
        {
            default:
                break;
            case 0:
                Tharcian tharcian = new Tharcian(name, level);
                tharcian.SetClass("Thracian");
                holdPlayerInformation.gladiatorList.Add(tharcian);
                return tharcian;
            case 1:
                Secutor secutor = new Secutor(name, level);
                secutor.SetClass("Secutor");
                holdPlayerInformation.gladiatorList.Add(secutor);
                return secutor;
            case 2:
                Samnite samnite = new Samnite(name, level);
                samnite.SetClass("Samnite");
                holdPlayerInformation.gladiatorList.Add(samnite);
                return samnite;
            case 3:
                Murmillo murmillo = new Murmillo(name, level);
                murmillo.SetClass("Murmillo");
                holdPlayerInformation.gladiatorList.Add(murmillo);
                return murmillo;
            case 4:
                Dimachaerus dimachaerus = new Dimachaerus(name, level);
                dimachaerus.SetClass("Dimachaerus");
                holdPlayerInformation.gladiatorList.Add(dimachaerus);
                return dimachaerus;
        }
        
        return null;
    }
    public Gladiator createNewShopGladiator(string name, int level, int health, int stamina, int power, int defense)
    {
        Gladiator gladiator;
        gladiator = new Gladiator(name, level, health, stamina, power, defense);
        holdPlayerInformation.shopGladiatorList.Add(gladiator);
        return gladiator;
    }
    public Gladiator createNewShopGladiator(string name, int level, int gladiatorClass)
    {
        
        switch (gladiatorClass) 
        {
            default:
                break;
            case 0:
                Tharcian tharcian = new Tharcian(name, level);
                holdPlayerInformation.shopGladiatorList.Add(tharcian);
                return tharcian;
            case 1:
                Secutor secutor = new Secutor(name, level);
                holdPlayerInformation.shopGladiatorList.Add(secutor);
                return secutor;
            case 2:
                Samnite samnite = new Samnite(name, level);
                holdPlayerInformation.shopGladiatorList.Add(samnite);
                return samnite;
            case 3:
                Murmillo murmillo = new Murmillo(name, level);
                holdPlayerInformation.shopGladiatorList.Add(murmillo);
                return murmillo;
            case 4:
                Dimachaerus dimachaerus = new Dimachaerus(name, level);
                holdPlayerInformation.shopGladiatorList.Add(dimachaerus);
                return dimachaerus;
        }
        
        return null;
    }
    public List<Gladiator> GetGladiatorList() 
    {
        return holdPlayerInformation.gladiatorList;
    }

}
