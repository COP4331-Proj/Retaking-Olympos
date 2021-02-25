using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkingSpeed;
    public float sprintSpeedMultiplier;
    private float sprintingSpeed; 
    private float speed;
    private bool isSprinting = false;

    // Update is called once per frame
    void Update()
    {
        // Set the sprinting speed
        sprintingSpeed = walkingSpeed * sprintSpeedMultiplier;

        // Checks if the user is sprinting
        if (Input.GetKey(KeyCode.LeftShift) && (PlayerGladiator.currentStamina > 0))
        {
            speed = sprintingSpeed;
            isSprinting = true;
        }
        else
        {
            speed = walkingSpeed;
            isSprinting = false;
        }

        // Check whether or not to drain the stamina energy
        if (isSprinting)
            PlayerGladiator.currentStamina -= 1;

        // Checks for the input then changes the velocity of the character if a key is pressed
        if (Input.GetKey(KeyCode.W))
            transform.position = new Vector2(transform.position.x, (float)(transform.position.y + speed));
        if (Input.GetKey(KeyCode.A))
            transform.position = new Vector2((float)(transform.position.x - speed), transform.position.y);
        if (Input.GetKey(KeyCode.S))
            transform.position = new Vector2(transform.position.x, (float)(transform.position.y - speed));
        if (Input.GetKey(KeyCode.D))
            transform.position = new Vector2((float)(transform.position.x + speed), transform.position.y);
    }
}
