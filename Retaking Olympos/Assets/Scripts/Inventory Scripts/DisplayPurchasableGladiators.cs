using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPurchasableGladiators : MonoBehaviour
{
    public HoldPlayerInformation holdPlayerInformation;
    public ViewGladiator viewGladiator;
    public List<Gladiator> gladiatorList;

    public int purchaseableGladiatorIndex = 0;
    // Text fields for all 6 gladiator attributes 
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI staminaText;
    [SerializeField] TextMeshProUGUI powerText;
    [SerializeField] TextMeshProUGUI defenseText;
    [SerializeField] TextMeshProUGUI classText;
    [SerializeField] TextMeshProUGUI costText;
    [SerializeField] TextMeshProUGUI soldOutText;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] sounds;
    private void Start()
    {
        
        gladiatorList = holdPlayerInformation.shopGladiatorList;
    }
    private void Awake()
    {
        gladiatorList = holdPlayerInformation.shopGladiatorList;
    }
    // TODO make this faster using events like inventory updates
    // Currently in update for updating stats when weapon equiped
    private void Update()
    {
        if (holdPlayerInformation.shopGladiatorList.Count > 0)
        {
            RefreshStats();
        }
        else 
        {
            hideObjects();
        }
    }
    private void hideObjects() 
    {
        nameText.gameObject.SetActive(false);
        levelText.gameObject.SetActive(false);
        healthText.gameObject.SetActive(false);
        staminaText.gameObject.SetActive(false);
        powerText.gameObject.SetActive(false);
        defenseText.gameObject.SetActive(false);
        classText.gameObject.SetActive(false);
        costText.gameObject.SetActive(false);
        soldOutText.gameObject.SetActive(true);
    }

    // Refreshes text fields with new gladiators stats
    public void RefreshStats()
    {

        nameText.text = gladiatorList[purchaseableGladiatorIndex].GetName().ToString();
        levelText.text = gladiatorList[purchaseableGladiatorIndex].GetLevel().ToString();
        healthText.text = gladiatorList[purchaseableGladiatorIndex].GetHealth().ToString();
        staminaText.text = gladiatorList[purchaseableGladiatorIndex].GetStamina().ToString();
        powerText.text = gladiatorList[purchaseableGladiatorIndex].GetPower().ToString();
        defenseText.text = gladiatorList[purchaseableGladiatorIndex].GetDefense().ToString();
        classText.text = gladiatorList[purchaseableGladiatorIndex].GetClass().ToString();
        costText.text = gladiatorList[purchaseableGladiatorIndex].GetCost().ToString();
    }

    public void IncrementGladiatorIndex()
    {
        if (gladiatorList.Count > 0) 
        {
            purchaseableGladiatorIndex = (purchaseableGladiatorIndex + 1) % gladiatorList.Count;
            RefreshStats();
        }

    }

    public void DecrementGladiatorIndex()
    {
        if (gladiatorList.Count > 0)
        {
            purchaseableGladiatorIndex = (purchaseableGladiatorIndex - 1) % gladiatorList.Count;
            if (purchaseableGladiatorIndex < 0)
            {
                purchaseableGladiatorIndex += gladiatorList.Count;
            }
            RefreshStats();
        }

    }

    public void buyGladiator() 
    {
        
        if (gladiatorList.Count > 0) 
        {
            Gladiator gladiator = holdPlayerInformation.shopGladiatorList[purchaseableGladiatorIndex];
            if (gladiator.GetCost() <= holdPlayerInformation.gold) 
            {
                holdPlayerInformation.gold -= gladiator.GetCost();
                holdPlayerInformation.shopGladiatorList.RemoveAt(purchaseableGladiatorIndex);

                if (purchaseableGladiatorIndex != 0)
                {
                    purchaseableGladiatorIndex--;
                }
                holdPlayerInformation.gladiatorList.Add(gladiator);
                holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
                if (audioSource != null) 
                {
                    audioSource.PlayOneShot(sounds[0]);
                }
            }
        }
    }
}
