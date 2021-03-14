using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGladiator : MonoBehaviour
{
    public static int currentHealth;
    public EnemyBar healthBar;
    public Gladiator enemy;
    private float difficulty = 1f;

    // Start is called before the first frame update
    void Start()
    {
        difficulty = PlayerPrefs.HasKey("DifficultyPreference") ? PlayerPrefs.GetFloat("DifficultyPreference") : 1f;

        setupEnemyGladiator();

        if (PlayerPrefs.HasKey("enemySetUp"))
        {
            takeDamage(PlayerPrefs.GetInt("enemyDamageTaken"));
            transform.position = new Vector2(PlayerPrefs.GetFloat("enemyXPosition"), PlayerPrefs.GetFloat("enemyYPosition"));
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Pressing space will modify size of bars
        healthBar.setHealth(currentHealth);

        // Create PlayerPref stuff for enemy position
        PlayerPrefs.SetFloat("enemyXPosition", this.transform.position.x);
        PlayerPrefs.SetFloat("enemyYPosition", this.transform.position.y);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("enemySetUp");
    }

    // Method to test health bar change
    public void takeDamage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;
        PlayerPrefs.SetInt("enemyDamageTaken", (int)(100 * difficulty) - currentHealth);
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }

    public void setupEnemyGladiator()
    {
        if (!PlayerPrefs.HasKey("enemySetUp"))
            enemy = new Gladiator("Enemy", 1, (int)(100 * difficulty), 100, 6, 14);
        else
            enemy = new Gladiator("Enemy", PlayerPrefs.GetInt("enemyLevel"), PlayerPrefs.GetInt("enemyHealth"), 
                                  PlayerPrefs.GetInt("enemyStamina"), PlayerPrefs.GetInt("enemyPower"), PlayerPrefs.GetInt("enemyDefense"));

        currentHealth = enemy.GetHealth();
        if (healthBar != null) 
        {
            healthBar.setMaxHealth(enemy.GetHealth());
        }

        // Set up PlayerPref stuff so that the enemy gladiator doesn't reset when switching to the pause menu
        PlayerPrefs.SetInt("enemyHealth", enemy.GetHealth());
        PlayerPrefs.SetInt("enemyStamina", enemy.GetStamina());
        PlayerPrefs.SetInt("enemyLevel", enemy.GetLevel());
        PlayerPrefs.SetInt("enemyPower", enemy.GetPower());
        PlayerPrefs.SetInt("enemyDefense", enemy.GetDefense());
        PlayerPrefs.SetString("enemyClass", enemy.GetClass());

        // Set up PlayerPref stuff for enemy gladiator positions
        if (!PlayerPrefs.HasKey("enemySetUp"))
        {
            PlayerPrefs.SetFloat("enemyXPosition", this.transform.position.x);
            PlayerPrefs.SetFloat("enemyYPosition", this.transform.position.y);
        }

        // Create PlayerPref data to keep track of how much damage was taken
        if (!PlayerPrefs.HasKey("enemySetUp"))
            PlayerPrefs.SetInt("enemyDamageTaken", 0);

        PlayerPrefs.SetInt("enemySetUp", 1);
    }
}
