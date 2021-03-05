using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Helper class to create a UIInventory object and not have it destroyed on scene load
public class UIInventoryControler : MonoBehaviour
{
    public HoldPlayerInformation playerInformation;
    public UIInventory uIInventory;
    public UIEquiptment uIEquiptment;
    public GameObject toolTip;
    public GladiatorEquiptment gladiatorEquiptment;

    // Start is called before the first frame update
    void Start()
    {

        // load the inventory and equipment from scriptable objects
        
        gladiatorEquiptment.playerInformation = playerInformation;
        uIInventory.SetInventory(playerInformation.playerInventory, true);
        if (uIEquiptment != null) 
        {
            uIEquiptment.SetEquipment(gladiatorEquiptment);
        }


    }

    public void ShowToolTip(Vector3 position, Item item)
    {
        if (toolTip == null)
        {
            toolTip = GameObject.FindWithTag("ToolTip");
        }
        toolTip.SetActive(true);
        
        toolTip.transform.position = position;
        toolTip.GetComponentInChildren<TextMeshProUGUI>().text = item.GetDescription();
    }

    public void HideToolTip()
    {
        if (toolTip == null)
        {
            toolTip = GameObject.FindWithTag("ToolTip");
        }
        toolTip.SetActive(false);
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
