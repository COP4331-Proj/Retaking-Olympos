using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator
{
    private string gladiatorName;
    private int level;
    private int health;
    private int stamina;
    private int power;
    private int defense;

    private float difficulty =
        PlayerPrefs.HasKey("DifficultyPreference") ? PlayerPrefs.GetFloat("DifficultyPreference") : 0f;

    // Gladiator constructor
    public Gladiator(string name, int level, int health, int stamina, int power, int defense) 
    {
        this.gladiatorName = name;
        this.level = level;
        this.health = (int)(health * difficulty);
        this.stamina = stamina;
        this.power = power;
        this.defense = defense;
    }

    // Getter and setters for gladiator stats
    public string GetName() 
    {
        return this.gladiatorName;
    }
    public void SetName(string name)
    {
        this.gladiatorName = name;
    }

    public int GetLevel()
    {
        return this.level;
    }
    public void SetLevel(int level)
    {
        this.level = level;
    }
    public int GetHealth()
    {
        return this.health;
    }
    public void SetHealth(int health)
    {
        this.health = health;
    }
    public int GetStamina()
    {
        return this.stamina;
    }
    public void SetStamina(int stamina)
    {
        this.stamina = stamina;
    }
    public int GetPower()
    {
        return this.power;
    }
    public void SetPower(int power)
    {
        this.power = power;
    }
    public int GetDefense()
    {
        return this.defense;
    }
    public void SetDefense(int defense)
    {
        this.defense = defense;
    }
}
