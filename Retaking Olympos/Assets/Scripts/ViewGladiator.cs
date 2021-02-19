using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewGladiator : MonoBehaviour
{
    List<Gladiator> gladiatorList = new List<Gladiator>();

    // Start is called before the first frame update
    void Start()
    {
        createNewGladiator("Caesar", 3, 100, 100, 6, 14);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gladiatorList[0].GetHealth());
    }

    void createNewGladiator(string name, int level, int health, int stamina, int power, int defense)
    {
        Gladiator gladiator;
        gladiator = new Gladiator(name, level, health, stamina, power, defense);
        gladiatorList.Add(gladiator);
    }
}
