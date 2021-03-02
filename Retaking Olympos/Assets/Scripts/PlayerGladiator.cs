using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGladiator : MonoBehaviour
{
    public static int currentHealth;
    public static int currentStamina;
    public Gladiator player = new Gladiator("Player", 1, 100, 100, 6, 14);
    
    public HealthBar healthBar;
    public StaminaBar staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        setupPlayerGladiator();
    }

    // Update is called once per frame
    void Update()
    {
        // Pressing space will modify size of bars
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(10);
            useSkill(10);
        }
        healthBar.setHealth(currentHealth);
        staminaBar.setStamina(currentStamina);
    }

    // Method to test health bar change
    public void takeDamage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;
    }

    // Method to test stamina bar change
    void useSkill(int stamina)
    {
        if (currentStamina <= 0)
            return;

        currentStamina -= stamina;
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }


    public void setupPlayerGladiator()
    {
        currentHealth = player.GetHealth();
        healthBar.setMaxHealth(player.GetHealth());
        currentStamina = player.GetStamina();
        staminaBar.setMaxStamina(player.GetStamina());
    }
}
