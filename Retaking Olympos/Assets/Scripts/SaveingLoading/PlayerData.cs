using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level, power, defense;
    public int health, stamina;
    public string playerClass;
    public float[] position;

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
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
