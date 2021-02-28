using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Better name for this class would be along the line of main gladiator controler
// Dont want to rename until I make sure it wont mess anyone else up
public class ViewGladiator: MonoBehaviour
{
    public HoldGladiatorList holdGladiatorList;
    public HoldPlayerEquipment playerEquipment;
    // Creates two dummy gladiators to show the system working
    private void Start()
    {
        if (holdGladiatorList.gladiatorList.Count == 0) 
        {
            createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            createNewGladiator("Bob", 4, 120, 120, 10, 12);
        }
        
    }

    // Creates new gladiator, returns it, and addes it to the gladiator list
    public Gladiator createNewGladiator(string name, int level, int health, int stamina, int power, int defense)
    {
        Gladiator gladiator;
        gladiator = new Gladiator(name, level, health, stamina, power, defense);
        holdGladiatorList.gladiatorList.Add(gladiator);
        playerEquipment.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
        return gladiator;
    }

    public List<Gladiator> GetGladiatorList() 
    {
        return holdGladiatorList.gladiatorList;
    }

}
