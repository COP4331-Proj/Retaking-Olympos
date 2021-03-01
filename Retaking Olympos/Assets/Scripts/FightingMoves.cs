using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingMoves : MonoBehaviour
{
    public PlayerGladiator player;
    public EnemyGladiator enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // To test attacks, pressing J down will cause damage to the enemy
        // Releasing J will cause damage to the player, simulating a counter-attack
        if (Input.GetKeyDown(KeyCode.J))
        {
            playerSwing(enemy);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            enemySwing(player);
        }
    }

    public void playerSwing(EnemyGladiator enemy)
    {
       enemy.takeDamage(20);
    }

    public void enemySwing(PlayerGladiator player)
    {
       player.takeDamage(20);
    }

}
