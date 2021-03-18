using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseGladiator : MonoBehaviour
{
    public HoldPlayerInformation holdPlayerInformation;
    public ViewGladiator viewGladiator;
    static bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectsOfType<PurchaseGladiator>().Length > 1)
        {
            Destroy(gameObject);
        }
        else 
        {
            DontDestroyOnLoad(gameObject);
        }
        if (viewGladiator == null)
        {
            viewGladiator = FindObjectOfType<ViewGladiator>();
        }
        if (holdPlayerInformation.shopGladiatorList.Count == 0 && flag)
        {
            flag = false;
            viewGladiator.createNewShopGladiator("Cicero", 7, "Samnite");
            viewGladiator.createNewShopGladiator("Sulla", 1, "Murmillo");
            viewGladiator.createNewShopGladiator("Pompey", 3, "Dimachaerus");
        }
        
    }

}
