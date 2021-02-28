using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Helper class to create a UIInventory object and not have it destroyed on scene load
public class UIInventoryControler : MonoBehaviour
{
    public HoldPlayerInventory holdPlayerInventory;
    public HoldGladiatorList gladiatorList;
    public UIInventory uIInventory;
    public UIEquiptment uIEquiptment;
    public HoldPlayerEquipment playerEquipment;
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
        
        gladiatorEquiptment.playerEquipment = playerEquipment;
        uIInventory.SetInventory(holdPlayerInventory.playerInventory);
        uIEquiptment.SetEquipment(gladiatorEquiptment);
    }


    public void IncrementEquipmentIndex() 
    {
        uIEquiptment.IncrementEquipmentIndex(gladiatorList);
    }

    public void DecrementEquipmentIndex()
    {
        uIEquiptment.DecrementEquipmentIndex(gladiatorList);
    }
}
