using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingMoves : MonoBehaviour
{
    public PlayerGladiator player;
    public EnemyGladiator enemy;
    public Animator animator;

    public Transform playerAttackPoint;
    public Transform enemyAttackPoint;
    public float playerRange = 1.0f;
    public float enemyRange = 1.0f;
    public LayerMask playerLayers;
    public LayerMask enemyLayers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // To test attacks, pressing Space down will cause damage to the enemy if in range
        // Releasing Space will cause damage to the player if they are close to the enemy, simulating a counter-attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerSwing();
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            enemySwing();
            animator.SetBool("isAttacking", false);
        }
    }

    public void playerHit(EnemyGladiator enemy)
    {
       enemy.takeDamage(20);
    }

    public void enemyHit(PlayerGladiator player)
    {
       player.takeDamage(20);
    }

    public void playerSwing()
    {
        Collider2D[] hitEnemy = Physics2D.OverlapCircleAll(playerAttackPoint.position, playerRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemy)
        {
            if (enemy != null)
                playerHit(enemy.GetComponent<EnemyGladiator>());
        }
    }

    public void enemySwing()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(enemyAttackPoint.position, enemyRange, playerLayers);

        foreach (Collider2D player in hitPlayer)
        {
            if (player != null)
                enemyHit(player.GetComponent<PlayerGladiator>());
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(playerAttackPoint.position, playerRange);
        Gizmos.DrawWireSphere(enemyAttackPoint.position, enemyRange);
    }

}
