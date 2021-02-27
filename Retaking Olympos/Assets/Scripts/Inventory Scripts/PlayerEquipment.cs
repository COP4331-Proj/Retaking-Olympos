using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="PlayerEquipment", menuName = "Equipment")]
public class PlayerEquipment : ScriptableObject
{
    public IndividualGladiatorEquipment individualGladiatorEquipment = new IndividualGladiatorEquipment();
}
