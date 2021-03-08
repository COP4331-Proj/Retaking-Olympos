using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGladiator : MonoBehaviour
{
    public static int currentHealth;
    public HealthBar healthBar;
    public Gladiator enemy;
    private float difficulty = 1f;

    // Start is called before the first frame update
    void Start()
    {
        difficulty = PlayerPrefs.HasKey("DifficultyPreference") ? PlayerPrefs.GetFloat("DifficultyPreference") : 1f;
        setupEnemyGladiator();
    }

    // Update is called once per frame
    void Update()
    {
        // Pressing space will modify size of bars
        healthBar.setHealth(currentHealth);
    }

    // Method to test health bar change
    public void takeDamage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }

    public void setupEnemyGladiator()
    {
        enemy = new Gladiator("Enemy", 1, (int)(100 * difficulty), 100, 6, 14);
        currentHealth = enemy.GetHealth();
        if (healthBar != null) 
        {
            healthBar.setMaxHealth(enemy.GetHealth());
        }
    }
}
