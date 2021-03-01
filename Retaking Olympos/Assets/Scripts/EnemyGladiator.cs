using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGladiator : MonoBehaviour
{
    public static int currentHealth;
    public Gladiator enemy = new Gladiator("Enemy", 1, 100, 100, 6, 14);

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        setupEnemyGladiator();
    }

    // Update is called once per frame
    void Update()
    {
        // Pressing space will modify size of bars
    }

    // Method to test health bar change
    public void takeDamage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;

        healthBar.setHealth(currentHealth);
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }

    public void setupEnemyGladiator()
    {
        currentHealth = enemy.GetHealth();
        healthBar.setMaxHealth(enemy.GetHealth());
    }
}
