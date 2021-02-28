using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scriptable object to hold a gladiator equipment object
// Scriptable object allows data to be held between scenes
[CreateAssetMenu(fileName ="PlayerEquipment", menuName = "Equipment")]
public class HoldPlayerEquipment : ScriptableObject
{

    public List<IndividualGladiatorEquipment> individualGladiatorEquipment = new List<IndividualGladiatorEquipment>();
    

}
