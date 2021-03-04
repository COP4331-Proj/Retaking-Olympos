using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Helper class to create a UIInventory object and not have it destroyed on scene load
public class UIInventoryControler : MonoBehaviour
{
    public HoldPlayerInformation playerInformation;
    public UIInventory uIInventory;
    public UIEquiptment uIEquiptment;
    
    public GladiatorEquiptment gladiatorEquiptment;

    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectsOfType<UIInventoryControler>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        // load the inventory and equipment from scriptable objects
        
        gladiatorEquiptment.playerInformation = playerInformation;
        uIInventory.SetInventory(playerInformation.playerInventory, true);
        if (uIEquiptment != null) 
        {
            uIEquiptment.SetEquipment(gladiatorEquiptment);
        }
    }


    // Pass along the list of gladiators when modifying index
    public void IncrementEquipmentIndex() 
    {
        uIEquiptment.IncrementEquipmentIndex(playerInformation);
    }

    public void DecrementEquipmentIndex()
    {
        uIEquiptment.DecrementEquipmentIndex(playerInformation);
    }
}
