using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyData
{
    public int health;
    public float xPos, yPos;

    public EnemyData(EnemyGladiator enemy)
    {
        // Store the enemy gladiator's health
        // More stats will be added here if they are added to the Enemy Gladiator's class
        health = EnemyGladiator.currentHealth;

        // Store the enemy gladiator's position
        xPos = PlayerPrefs.GetFloat("enemyXPosition");
        yPos = PlayerPrefs.GetFloat("enemyYPosition");
    }
}