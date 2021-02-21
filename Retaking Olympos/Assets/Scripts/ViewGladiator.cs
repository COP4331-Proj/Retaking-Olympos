using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ViewGladiator: MonoBehaviour
{
    List<Gladiator> gladiatorList = new List<Gladiator>();
    [SerializeField] int gladiatorIndex = 0;

    private void Start()
    {
        createNewGladiator("Caesar", 3, 100, 100, 6, 14);
        createNewGladiator("Bob", 4, 120, 120, 10, 12);
    }

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
