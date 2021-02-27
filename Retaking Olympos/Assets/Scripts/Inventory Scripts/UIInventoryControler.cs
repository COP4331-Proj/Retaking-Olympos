using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Helper class to create a UIInventory object and not have it destroyed on scene load
public class UIInventoryControler : MonoBehaviour
{
    public HoldPlayerInventory holdPlayerInventory;
    public UIInventory uIInventory;
    public UIEquiptment uIEquiptment;
    public PlayerEquipment playerEquipment;
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
        gladiatorEquiptment.playerEquipment = playerEquipment;
        uIInventory.SetInventory(holdPlayerInventory.playerInventory);
        uIEquiptment.SetEquipment(gladiatorEquiptment);
    }


}
