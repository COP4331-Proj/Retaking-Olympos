using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float movementSpeed = 1.0f;
    public float attackRange = 1.0f;
    public Transform playerChar;

    // Start is called before the first frame update
    void Start()
    {
        playerChar = GameObject.FindWithTag("Player Gladiator").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, playerChar.position) > attackRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerChar.position, movementSpeed * Time.deltaTime);
        }
    }


}
