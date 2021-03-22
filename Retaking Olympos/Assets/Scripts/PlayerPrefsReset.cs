using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class resets the PlayerPrefs that needs to be reset when the game quits
public class PlayerPrefsReset : MonoBehaviour
{
    // Start is called before the first frame update
    void OnApplicationQuit()
    {
        // The player and enemy gladiators shouldn't be already set up 
        // when the game opens, so these flags must be reset
        PlayerPrefs.DeleteKey("enemySetUp");
        PlayerPrefs.DeleteKey("playerSetUp");

        // Reset the progress of the enemies defeated
        PlayerPrefs.SetInt("CarpophorusBeat", 0);
        PlayerPrefs.SetInt("CommodusBeat", 0);
        PlayerPrefs.SetInt("CrixusBeat", 0);
        PlayerPrefs.SetInt("FlammaBeat", 0);
        PlayerPrefs.SetInt("SpartacusBeat", 0);

        // Reset the damage taken
        PlayerPrefs.SetInt("enemyDamageTaken", 0);
    }
}
