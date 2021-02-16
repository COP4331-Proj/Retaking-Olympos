using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GladiatorBehavior : MonoBehaviour
{
    Gladiator gladiator;

    // Start is called before the first frame update
    void Start()
    {
        gladiator = new Gladiator("Caesar", 3, 100, 100, 7, 16);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
