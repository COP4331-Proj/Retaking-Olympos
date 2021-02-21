using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Better name for this class would be along the line of main gladiator controler
// Dont want to rename until I make sure it wont mess anyone else up
public class ViewGladiator: MonoBehaviour
{
    List<Gladiator> gladiatorList = new List<Gladiator>();
    [SerializeField] int gladiatorIndex = 0;

    // Creates two dummy gladiators to show the system working
    private void Start()
    {
        createNewGladiator("Caesar", 3, 100, 100, 6, 14);
        createNewGladiator("Bob", 4, 120, 120, 10, 12);
    }

    // Creates new gladiator, returns it, and addes it to the gladiator list
    public Gladiator createNewGladiator(string name, int level, int health, int stamina, int power, int defense)
    {
        Gladiator gladiator;
        gladiator = new Gladiator(name, level, health, stamina, power, defense);
        gladiatorList.Add(gladiator);
        return gladiator;
    }

    public List<Gladiator> GetGladiatorList() 
    {
        return gladiatorList;
    }

}
