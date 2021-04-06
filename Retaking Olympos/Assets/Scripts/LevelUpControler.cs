using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpControler : MonoBehaviour
{
    public ViewGladiator viewGladiator;
    // Start is called before the first frame update
    void Start()
    {
        if (viewGladiator == null) 
        {
            viewGladiator = FindObjectOfType<ViewGladiator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLevel() 
    {
        Gladiator gladiator = viewGladiator.GetGladiatorList()[viewGladiator.holdPlayerInformation.index];
        if (viewGladiator.holdPlayerInformation.gold - gladiator.GetCost() > 0)
        {
            viewGladiator.holdPlayerInformation.gold -= gladiator.GetCost();
            gladiator.LevelUpGladiator();
        }
    }
}
