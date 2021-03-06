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
        // (level * 25) + 75 is the average stat that most classes will have
        // Samnite is an all-rounder. Therefore, all of the stats should be pretty average
        SetClass("Samnite");
        SetHealth((level * 25) + 75);
        SetStamina((level * 25) + 75);
        SetPower((level * 25) + 75);
        SetDefense((level * 25) + 75);
    }
}
