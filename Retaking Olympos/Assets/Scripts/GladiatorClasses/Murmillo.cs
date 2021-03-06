using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murmillo : Gladiator
{
    // The constructor sets up the stats based on the level
    // The health, stamina, power, and defense are set to 0 (as a dummy value) when the class is instantiated
    // These stats are then corrected in the body of the constructor for readability
    // The base stats will be changed if they are unbalanced
    public Murmillo(string name, int level)
        : base(name, level, 0, 0, 0, 0)
    {
        // (level * 25) + 75 is the average stat that most classes will have
        // Murmillo has a large sword but is susceptible to agile attacks. Therefore, its power level will be
        // above average, but will have below average stamina to since it can't keep up with the more agile classes
        SetClass("Murmillo");
        SetHealth((level * 25) + 75);
        SetStamina((level * 15) + 65);
        SetPower((level * 35) + 75);
        SetDefense((level * 25) + 75);
    }
}
