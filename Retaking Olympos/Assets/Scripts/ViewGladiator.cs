using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewGladiator
{
    List<Gladiator> gladiatorList = new List<Gladiator>();

    public void createNewGladiator(string name, int level, int health, int stamina, int power, int defense)
    {
        Gladiator gladiator;
        gladiator = new Gladiator(name, level, health, stamina, power, defense);
        gladiatorList.Add(gladiator);
    }

    public List<Gladiator> GetGladiatorList() 
    {
        return gladiatorList;
    }
}
