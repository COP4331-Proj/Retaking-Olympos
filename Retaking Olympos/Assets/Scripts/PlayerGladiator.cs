using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGladiator : MonoBehaviour
{
    public int currentHealth;
    public int currentStamina;
    public Gladiator player = new Gladiator("Player", 1, 100, 100, 6, 14);
    
    public HealthBar healthBar;
    public StaminaBar staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = player.GetHealth();
        healthBar.setMaxHealth(player.GetHealth());
        currentStamina = player.GetStamina();
        staminaBar.setMaxStamina(player.GetStamina());
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
    }

    // Method to test health bar change
    void takeDamage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;

        healthBar.setHealth(currentHealth);
    }

    // Method to test stamina bar change
    void useSkill(int stamina)
    {
        if (currentStamina <= 0)
            return;

        currentStamina -= stamina;

        staminaBar.setStamina(currentStamina);
    }
}
