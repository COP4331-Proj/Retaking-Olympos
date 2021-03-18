using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGladiator : MonoBehaviour
{
    public static int currentHealth, currentStamina, currentLevel;
    public static int currentPower, currentDefense;
    public static string playerClass;
    public Gladiator player = new Gladiator("Player", 1, 100, 100, 6, 14);
    
    public HealthBar healthBar;
    public StaminaBar staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("isSetUp"))
            QuickLoadPlayerGladiator();
        setupPlayerGladiator();

        if (PlayerPrefs.HasKey("isSetUp"))
        {
            takeDamage(PlayerPrefs.GetInt("damageTaken"));
            useSkill(PlayerPrefs.GetInt("staminaUsed"));
            transform.position = new Vector2(PlayerPrefs.GetFloat("playerXPosition"), PlayerPrefs.GetFloat("playerYPosition"));
        }
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
        PlayerPrefs.SetInt("staminaUsed", (100 - currentStamina));

        PlayerPrefs.SetFloat("playerXPosition", this.transform.position.x);
        PlayerPrefs.SetFloat("playerYPosition", this.transform.position.y);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("isSetUp");
    }

    // Method to test health bar change
    public void takeDamage(int damage)
    {
        if (currentHealth <= 0)
            return;

        currentHealth -= damage;
        PlayerPrefs.SetInt("damageTaken", (100 - currentHealth));
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
        // Sets up the health bar and stamina bar
        currentHealth = player.GetHealth();
        healthBar.setMaxHealth(player.GetHealth());
        currentStamina = player.GetStamina();
        staminaBar.setMaxStamina(player.GetStamina());

        // Set up the rest of the stats
        currentLevel = player.GetLevel();
        currentPower = player.GetPower();
        currentDefense = player.GetDefense();
        playerClass = player.GetClass();

        // Set up PlayerPref stuff so that the player gladiator doesn't reset when switching to the pause menu
        PlayerPrefs.SetInt("healthValue", currentHealth);
        PlayerPrefs.SetInt("staminaValue", currentStamina);
        PlayerPrefs.SetInt("level", currentLevel);
        PlayerPrefs.SetInt("power", currentPower);
        PlayerPrefs.SetInt("defense", currentDefense);
        PlayerPrefs.SetString("playerClass", playerClass);

        // Create PlayerPref data to keep track of how much damage was taken and stamina was used and player position
        if (!PlayerPrefs.HasKey("isSetUp"))
        {
            PlayerPrefs.SetInt("damageTaken", 0);
            PlayerPrefs.SetInt("staminaUsed", 0);

            PlayerPrefs.SetFloat("playerXPosition", this.transform.position.x);
            PlayerPrefs.SetFloat("playerYPosition", this.transform.position.y);
        }

        // Use a PlayerPref flag to let the PlayerGladiator class know if the PlayerGladiator is set up
        // The value doesn't actually matter because we can use PlayerPrefs.HasKey to check if the key is present
        PlayerPrefs.SetInt("isSetUp", 1);
    }

    // This function is for loading playerpref values
    public void QuickLoadPlayerGladiator()
    {
        player.SetHealth(PlayerPrefs.GetInt("healthValue"));
        player.SetStamina(PlayerPrefs.GetInt("staminaValue"));
        currentLevel = PlayerPrefs.GetInt("level");
        currentPower = PlayerPrefs.GetInt("power");
        currentDefense = PlayerPrefs.GetInt("defense");
        playerClass = PlayerPrefs.GetString("playerClass");
    }

    public void SavePlayerGladiatorData()
    {
        SaveManager.SavePlayerData(this);
    }

    public void LoadPlayerGladiatorData()
    {
        PlayerData data = SaveManager.LoadPlayerData();
        currentHealth = data.health;
        currentLevel = data.level;
        currentDefense = data.defense;
        currentStamina = data.stamina;
        currentPower = data.power;

        PlayerPrefs.SetInt("damageTaken", 100 - currentHealth);
        PlayerPrefs.SetInt("staminaUsed", 100 - currentStamina);
        PlayerPrefs.SetInt("level", currentLevel);
        PlayerPrefs.SetInt("power", currentPower);
        PlayerPrefs.SetInt("defense", currentDefense);
    }
}
