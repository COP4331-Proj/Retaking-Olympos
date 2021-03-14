using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samnite : Gladiator
{
    // The constructor sets up the stats based on the level
    // The health, stamina, power, and defense are set to 0 (as a dummy value) when the class is instantiated
    // These stats are then corrected in the body of the constructor for readability
    // The base stats will be changed if they are unbalanced
    public Samnite(string name, int level)
        : base(name, level, 0, 0, 0, 0)
    {
        SetClass("Samnite");
        UpdateStats();
    }

    // (level * 25) + 75 is the average stat that most classes will have
    // Samnite is an all-rounder. Therefore, all of the stats should be pretty average
    private void UpdateStats()
    {
        SetHealth((GetLevel() * 25) + 75);
        SetStamina((GetLevel() * 25) + 75);
        SetPower((GetLevel() * 25) + 75);
        SetDefense((GetLevel() * 25) + 75);
        SetCost((GetLevel() * 25) + 75);
        return;
    }

    public void LevelUp()
    {
        SetLevel(GetLevel() + 1);
        UpdateStats();
    }
}
