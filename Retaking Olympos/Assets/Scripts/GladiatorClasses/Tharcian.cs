using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tharcian : Gladiator
{
    // The constructor sets up the stats based on the level
    // The health, stamina, power, and defense are set to 0 (as a dummy value) when the class is instantiated
    // These stats are then corrected in the body of the constructor for readability
    // The base stats will be changed if they are unbalanced
    public Tharcian(string name, int level)
        :base(name, level, 0, 0, 0, 0)
    {
        SetClass("Tharcian");
        UpdateStats();
    }

    // (level * 25) + 75 is the average stat that most classes will have
    // Tharcian is agile. Therefore, its stamina will be above average for more sprinting power.
    private void UpdateStats()
    {
        SetHealth((GetLevel() * 25) + 75);
        SetStamina((GetLevel() * 40) + 80);
        SetPower((GetLevel() * 5) + 12);
        SetDefense((GetLevel() * 2) + 6);
        SetCost((GetLevel() * 25) + 75);
        return;
    }

    public void LevelUp()
    {
        SetLevel(GetLevel() + 1);
        UpdateStats();
    }
}
