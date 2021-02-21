using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks for the input then changes the velocity of the character if a key is pressed
        if (Input.GetKey(KeyCode.W))
            transform.position = new Vector2(transform.position.x, (float)(transform.position.y + movementSpeed));
        if (Input.GetKey(KeyCode.A))
            transform.position = new Vector2((float)(transform.position.x - movementSpeed), transform.position.y);
        if (Input.GetKey(KeyCode.S))
            transform.position = new Vector2(transform.position.x, (float)(transform.position.y - movementSpeed));
        if (Input.GetKey(KeyCode.D))
            transform.position = new Vector2((float)(transform.position.x + movementSpeed), transform.position.y);
    }
}
