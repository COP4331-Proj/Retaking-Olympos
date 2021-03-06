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
        // (level * 25) + 75 is the average stat that most classes will have
        // Secutor has heavy armor. Therefore, it'll have less stamina than normal, but will have really high defense and health
        SetClass("Secutor");
        SetHealth((level * 30) + 75);
        SetStamina((level * 15) + 65);
        SetPower((level * 25) + 75);
        SetDefense((level * 40) + 75);
    }
}
