using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryControler : MonoBehaviour
{
    public HoldPlayerInventory holdPlayerInventory;
    public UIInventory uIInventory;

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

        uIInventory.SetInventory(holdPlayerInventory.playerInventory);
    }


}
