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

        if (PlayerPrefs.HasKey("GameSceneIsLoaded"))
            setupEnemyGladiator();

        if (!PlayerPrefs.HasKey("EnemyIsInArena") && PlayerPrefs.HasKey("GameSceneIsLoaded"))
        {
            SaveEnemyGladiatorData();
            PlayerPrefs.SetInt("EnemyIsInArena", 1);
        }

        if (PlayerPrefs.HasKey("FightStatus") && PlayerPrefs.GetInt("FightStatus") != 1)
        {
            if (PlayerPrefs.HasKey("enemySetUp") && PlayerPrefs.HasKey("GameSceneIsLoaded"))
            {
                takeDamage(PlayerPrefs.GetInt("enemyDamageTaken"));
            }
        }

        if (PlayerPrefs.HasKey("enemySetUp"))
            transform.position = new Vector2(PlayerPrefs.GetFloat("enemyXPosition"), PlayerPrefs.GetFloat("enemyYPosition"));

        PlayerPrefs.SetInt("FightStatus", 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Pressing space will modify size of bars
        healthBar.setHealth(currentHealth);

        // Create PlayerPref stuff for enemy position
        if (PlayerPrefs.HasKey("GameSceneIsLoaded"))
        {
            PlayerPrefs.SetFloat("enemyXPosition", this.transform.position.x);
            PlayerPrefs.SetFloat("enemyYPosition", this.transform.position.y);
        }
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
                case "Cassius":
                    PlayerPrefs.SetInt("CassiusBeat", 1);
                    break;
                case "Marcus":
                    PlayerPrefs.SetInt("MarcusBeat", 1);
                    break;
                case "Silvanus":
                    PlayerPrefs.SetInt("SilvanusBeat", 1);
                    break;
                case "Verus":
                    PlayerPrefs.SetInt("VerusBeat", 1);
                    break;
                case "Tetraites":
                    PlayerPrefs.SetInt("TetraitesBeat", 1);
                    break;
            }
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<SceneLoader>();
            gameObject.GetComponent<SceneLoader>().GoToScene("Victory Scene");

            // If the enemy dies, we need to reset both player and enemy gladiators for the next fight
            if (PlayerPrefs.HasKey("GameSceneIsLoaded"))
            {
                PlayerPrefs.DeleteKey("enemySetUp");
                PlayerPrefs.DeleteKey("playerSetUp");
                PlayerPrefs.DeleteKey("PlayerIsInArena");
                PlayerPrefs.DeleteKey("EnemyIsInArena");
            }
        }

        PlayerPrefs.SetInt("enemyDamageTaken", enemy.GetHealth() - currentHealth);
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
            enemy = new Gladiator(PlayerPrefs.GetString("enemyName"), PlayerPrefs.GetInt("enemyLevel"), PlayerPrefs.GetInt("enemyHealth"),
                PlayerPrefs.GetInt("enemyStamina"), PlayerPrefs.GetInt("enemyPower"),
                PlayerPrefs.GetInt("enemyDefense"));
        }
        else
        {
            switch (PlayerPrefs.GetString("CurrentEnemy"))
            {
                case "Carpophorus":
                    // Thracian
                    Tharcian Carpophorus = new Tharcian("Carpophorus", 1);
                    enemy = new Gladiator(Carpophorus.GetName(), Carpophorus.GetLevel(), Carpophorus.GetHealth(), Carpophorus.GetStamina(), Carpophorus.GetPower(), Carpophorus.GetDefense());
                    break;
                case "Commodus":
                    // Samnite
                    Samnite Commodus = new Samnite("Commodus", 4);
                    enemy = new Gladiator(Commodus.GetName(), Commodus.GetLevel(), Commodus.GetHealth(), Commodus.GetStamina(), Commodus.GetPower(), Commodus.GetDefense());
                    break;
                case "Crixus":
                    // Secutor
                    Secutor Crixus = new Secutor("Crixus", 5);
                    enemy = new Gladiator(Crixus.GetName(), Crixus.GetLevel(), Crixus.GetHealth(), Crixus.GetStamina(), Crixus.GetPower(), Crixus.GetDefense());
                    break;
                case "Flamma":
                    // Murmillo
                    Murmillo Flamma = new Murmillo("Flamma", 6);
                    enemy = new Gladiator(Flamma.GetName(), Flamma.GetLevel(), Flamma.GetHealth(), Flamma.GetStamina(), Flamma.GetPower(), Flamma.GetDefense());
                    break;
                case "Spartacus":
                    // Dimachaerus
                    Dimachaerus Spartacus = new Dimachaerus("Spartacus", 10);
                    enemy = new Gladiator(Spartacus.GetName(), Spartacus.GetLevel(), Spartacus.GetHealth(), Spartacus.GetStamina(), Spartacus.GetPower(), Spartacus.GetDefense());
                    break;
                case "Cassius":
                    // Thracian
                    Tharcian Cassius = new Tharcian("Cassius", 2);
                    enemy = new Gladiator(Cassius.GetName(), Cassius.GetLevel(), Cassius.GetHealth(), Cassius.GetStamina(), Cassius.GetPower(), Cassius.GetDefense());
                    break;
                case "Marcus":
                    // Samnite
                    Samnite Marcus = new Samnite("Marcus", 4);
                    enemy = new Gladiator(Marcus.GetName(), Marcus.GetLevel(), Marcus.GetHealth(), Marcus.GetStamina(), Marcus.GetPower(), Marcus.GetDefense());
                    break;
                case "Silvanus":
                    // Secutor
                    Secutor Silvanus = new Secutor("Silvanus", 5);
                    enemy = new Gladiator(Silvanus.GetName(), Silvanus.GetLevel(), Silvanus.GetHealth(), Silvanus.GetStamina(), Silvanus.GetPower(), Silvanus.GetDefense());
                    break;
                case "Verus":
                    // Murmillo
                    Murmillo Verus = new Murmillo("Verus", 6);
                    enemy = new Gladiator(Verus.GetName(), Verus.GetLevel(), Verus.GetHealth(), Verus.GetStamina(), Verus.GetPower(), Verus.GetDefense());
                    break;
                case "Tetraites":
                    // Dimachaerus
                    Dimachaerus Tetraites = new Dimachaerus("Tetraites", 10);
                    enemy = new Gladiator(Tetraites.GetName(), Tetraites.GetLevel(), Tetraites.GetHealth(), Tetraites.GetStamina(), Tetraites.GetPower(), Tetraites.GetDefense());
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
        PlayerPrefs.SetInt("enemyDamageTaken", PlayerPrefs.GetInt("enemyHealth") - currentHealth);

        // Load the position
        PlayerPrefs.SetFloat("enemyXPosition", data.xPos);
        PlayerPrefs.SetFloat("enemyYPosition", data.yPos);
    }

    public void ConditionalEnemySave()
    {
        if (PlayerPrefs.HasKey("EnemyIsInArena"))
        {
            SaveEnemyGladiatorData();
        }
        Debug.Log(PlayerPrefs.HasKey("EnemyIsInArena"));
    }

    public void ConditionalEnemyLoad()
    {
        if (PlayerPrefs.HasKey("EnemyIsInArena"))
            LoadEnemyGladiatorData();
    }
}
