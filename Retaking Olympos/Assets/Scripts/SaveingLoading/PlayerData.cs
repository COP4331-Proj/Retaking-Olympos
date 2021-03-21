using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level, power, defense;
    public int health, stamina;
    public float xPos, yPos;
    public string playerClass;

    public PlayerData (PlayerGladiator player)
    {
        // Store the player gladiator's stats
        health = PlayerGladiator.currentHealth;
        stamina = PlayerGladiator.currentStamina;
        level = PlayerGladiator.currentLevel;
        playerClass = PlayerGladiator.playerClass;
        power = PlayerGladiator.currentPower;
        defense = PlayerGladiator.currentDefense;

        // Store the player gladiator's position
        xPos = PlayerPrefs.GetFloat("playerXPosition");
        yPos = PlayerPrefs.GetFloat("playerYPosition");
    }
}
