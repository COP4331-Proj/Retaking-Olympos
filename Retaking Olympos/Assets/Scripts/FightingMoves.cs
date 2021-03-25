using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingMoves : MonoBehaviour
{
    public PlayerGladiator player;
    public EnemyGladiator enemy;
    public Animator playerAnimator;
    public Animator enemyAnimator;
    public Transform playerAttackPoint;
    public Transform enemyAttackPoint;
    public float playerRange = 1.0f;
    public float enemyRange = 1.0f;
    public LayerMask playerLayers;
    public LayerMask enemyLayers;
    public float playerAttackRate = 2f;
    public float enemyAttackRate = 1f;
    float nextPlayerAttackTime = 0f;
    float nextEnemyAttackTime = 0f;
    public float playerDodgeRate = 1f;
    public float playerBlockPenalty = 1000f;
    float nextPlayerDodgeTime = 0f;
    float attackTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        // Limits player to certain number of attacks per second
        if (Time.time >= nextPlayerAttackTime)
        {
            // To test attacks, pressing Space down will cause damage to the enemy if in range
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerSwing();
                nextPlayerAttackTime = Time.time + 1f / playerAttackRate;
                playerAnimator.SetBool("isAttacking", true);
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnimator.SetBool("isAttacking", false);
        }

        // Limits enemy to certain number of attacks per second
        if (Time.time >= nextEnemyAttackTime)
        {

            attackTime = Time.time;
            // If in range, the enemy will start attacking the player
            if (Vector2.Distance(enemyAttackPoint.position, playerAttackPoint.position) <= (enemyRange * 1.25))
            {
                //Debug.Log("HERE");
                enemySwing();
                nextEnemyAttackTime = Time.time + 1f / enemyAttackRate;
                
                enemyAnimator.SetBool("EnemyAttacking", true);
            }
            else
            {
                //Debug.Log("HERE2");

                enemyAnimator.SetBool("EnemyAttacking", false);
            }
        }

        if (Time.time - attackTime > 0.3f) 
        {
            enemyAnimator.SetBool("EnemyAttacking", false);
        }

        // Limits rate of player dodging
        if (Time.time >= nextPlayerDodgeTime)
        {
            
            playerDodgeEnd();
            if (Input.GetKeyDown(KeyCode.F))
            {
                playerDodgeStart();
                nextPlayerAttackTime = Time.time + 1f / playerDodgeRate;
                nextPlayerDodgeTime = Time.time + 1f / playerDodgeRate;
            }
        }

        // While blocking, player cannot attack or dodge
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            playerBlockStart();
            nextPlayerAttackTime = Time.time + playerBlockPenalty;
            nextPlayerDodgeTime = Time.time + playerBlockPenalty;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            playerBlockEnd();
            nextPlayerAttackTime = Time.time;
            nextPlayerDodgeTime = Time.time;
        }
    }


    public void playerHit(EnemyGladiator enemy)
    {
        int damage = PlayerGladiator.currentPower - enemy.enemy.GetDefense();

        // 10 is the minimum amount of damage that can be done no matter what.
        if (damage < 10)
        {
            enemy.takeDamage(10);
        }
        else
        {
            enemy.takeDamage(damage);
        }
    }

    public void enemyHit(PlayerGladiator player)
    {
        int damage = enemy.enemy.GetPower() - PlayerGladiator.currentDefense;

        // 10 is the minimum amount of damage that can be done no matter what.
        if (damage < 10)
        {
            player.takeDamage(10);
        }
        else
        {
            player.takeDamage(damage);
        }
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

    public void playerDodgeStart()
    {
        playerLayers = LayerMask.GetMask("Default");
        if (player != null)
        {
            player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
        }
    }

    public void playerDodgeEnd()
    {
        playerLayers = LayerMask.GetMask("Player");
        if (player != null)
        {
            player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
    }

    public void playerBlockStart()
    {
        playerLayers = LayerMask.GetMask("Default");
        if (player!= null) 
        {
            player.GetComponent<SpriteRenderer>().color = new Color(.5f, .5f, .5f, 1f);
        }
    }

    public void playerBlockEnd()
    {
        playerLayers = LayerMask.GetMask("Player");
        if (player != null)
        {
            player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(playerAttackPoint.position, playerRange);
        Gizmos.DrawWireSphere(enemyAttackPoint.position, enemyRange);
    }

}
