using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secutor : Gladiator
{
    // The constructor sets up the stats based on the level
    // The health, stamina, power, and defense are set to 0 (as a dummy value) when the class is instantiated
    // These stats are then corrected in the body of the constructor for readability
    // The base stats will be changed if they are unbalanced
    public Secutor(string name, int level)
        : base(name, level, 0, 0, 0, 0)
    { 
        SetClass("Secutor");
        UpdateStats();
    }

    // (level * 25) + 75 is the average stat that most classes will have
    // Secutor has heavy armor. Therefore, it'll have less stamina than normal, but will have really high defense and health
    private void UpdateStats()
    {
        SetHealth((GetLevel() * 30) + 75);
        SetStamina((GetLevel() * 15) + 65);
        SetPower((GetLevel() * 4) + 8);
        SetDefense((GetLevel() * 3) + 10);
        SetCost((GetLevel() * 25) + 75);
        return;
    }

    public void LevelUp()
    {
        SetLevel(GetLevel() + 1);
        UpdateStats();
    }
}
