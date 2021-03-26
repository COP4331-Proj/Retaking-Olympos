using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimachaerus : Gladiator
{
    // The constructor sets up the stats based on the level
    // The health, stamina, power, and defense are set to 0 (as a dummy value) when the class is instantiated
    // These stats are then corrected in the body of the constructor for readability
    // The base stats will be changed if they are unbalanced
    public Dimachaerus(string name, int level)
        : base(name, level, 0, 0, 0, 0)
    {
        // (level * 25) + 75 is the average stat that most classes will have
        // Dimachaerus has two swords, and is skilled in close quarters combat. However, it's lightly armored.
        // Therefore, it should be a glass cannon, meaning it has high power, but low defense and health.
        SetClass("Dimachaerus");
        UpdateStats();
    }

    private void UpdateStats()
    {
        SetHealth((GetLevel() * 15) + 65);
        SetStamina((GetLevel() * 25) + 75);
        SetPower((GetLevel() * 6) + 16);
        SetDefense((GetLevel() * 2) + 4);
        SetCost((GetLevel() * 25) + 75);
        return;
    }

    public void LevelUp()
    {
        SetLevel(GetLevel() + 1);
        UpdateStats();
    }
}
