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

        if (PlayerPrefs.HasKey("FightStatus") && PlayerPrefs.GetInt("FightStatus") != 1)
        {
            if (PlayerPrefs.HasKey("enemySetUp"))
            {
                takeDamage(PlayerPrefs.GetInt("enemyDamageTaken"));
                transform.position = new Vector2(PlayerPrefs.GetFloat("enemyXPosition"),
                    PlayerPrefs.GetFloat("enemyYPosition"));
            }
        }

        PlayerPrefs.SetInt("FightStatus", 0);
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
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            // NUMBER ONE VICTORY ROYALE
            switch (PlayerPrefs.GetString("CurrentEnemy"))
            {
                case "Carpophorus":
                    PlayerPrefs.SetInt("CarpophorusBeat", 1);
                    break;
                case "Commodus":
                    PlayerPrefs.SetInt("CommodusBeat", 1);
                    break;
                case "Crixus":
                    PlayerPrefs.SetInt("CrixusBeat", 1);
                    break;
                case "Flamma":
                    PlayerPrefs.SetInt("FlammaBeat", 1);
                    break;
                case "Spartacus":
                    PlayerPrefs.SetInt("SpartacusBeat", 1);
                    break;
            }

            GameObject gameObject = new GameObject();
            gameObject.AddComponent<SceneLoader>();
            gameObject.GetComponent<SceneLoader>().GoToScene("FightChooser");
        }

        PlayerPrefs.SetInt("enemyDamageTaken", (int)(100 * difficulty) - currentHealth);
        PlayerPrefs.SetInt("FightStatus", 1);
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }

    public void setupEnemyGladiator()
    {
        if (!PlayerPrefs.HasKey("CurrentEnemy"))
        {
            if (PlayerPrefs.HasKey("enemySetUp"))
            {
                enemy = new Gladiator(PlayerPrefs.GetString("enemyName"), PlayerPrefs.GetInt("enemyLevel"), PlayerPrefs.GetInt("enemyHealth"),
                    PlayerPrefs.GetInt("enemyStamina"), PlayerPrefs.GetInt("enemyPower"),
                    PlayerPrefs.GetInt("enemyDefense"));
            }
        }
        else
        {
            switch (PlayerPrefs.GetString("CurrentEnemy"))
            {
                case "Carpophorus":
                    enemy = new Gladiator("Carpophorus", 1, 100, 100, 5, 5);
                    break;
                case "Commodus":
                    enemy = new Gladiator("Commodus", 4, 150, 100, 7, 7);
                    break;
                case "Crixus":
                    enemy = new Gladiator("Crixus", 2, 110, 100, 6, 6);
                    break;
                case "Flamma":
                    enemy = new Gladiator("Flamma", 6, 200, 100, 10, 8);
                    break;
                case "Spartacus":
                    enemy = new Gladiator("Spartacus", 10, 300, 100, 20, 10);
                    break;
            }
        }

        currentHealth = enemy.GetHealth();
        if (healthBar != null) 
        {
            healthBar.setMaxHealth(enemy.GetHealth());
        }

        // Set up PlayerPref stuff so that the enemy gladiator doesn't reset when switching to the pause menu
        PlayerPrefs.SetString("enemyName", enemy.GetName());
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

    public void SaveEnemyGladiatorData()
    {
        SaveManager.SaveEnemyData(this);
    }

    public void LoadEnemyGladiatorData()
    {
        // Load the stats
        EnemyData data = SaveManager.LoadEnemyData();
        currentHealth = data.health;

        // The save the stats to PlayerPrefs so that it doesn't disappear on switching off the pause menu
        PlayerPrefs.SetInt("enemyDamageTaken", (int)(100 * difficulty) - currentHealth);

        // Load the position
        transform.position = new Vector2(data.xPos, data.yPos);
    }
}
