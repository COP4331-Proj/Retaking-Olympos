using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scriptable object to hold a gladiator equipment object
// Scriptable object allows data to be held between scenes
[CreateAssetMenu(fileName = "GladiatorList", menuName = "Gladiator")]
public class HoldGladiatorList : ScriptableObject
{

    public List<Gladiator> gladiatorList = new List<Gladiator>();


}
