﻿using System.Collections;
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
    public float playerAttackRate = 2f;
    public float enemyAttackRate = 1f;
    float nextPlayerAttackTime = 0f;
    float nextEnemyAttackTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextPlayerAttackTime)
        {
            // To test attacks, pressing Space down will cause damage to the enemy if in range
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerSwing();
                nextPlayerAttackTime = Time.time + 1f / playerAttackRate;
                animator.SetBool("isAttacking", true);
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isAttacking", false);
        }

        if (Time.time >= nextEnemyAttackTime)
        {
            // If in range, the enemy will start attacking the player
            if (Vector2.Distance(enemyAttackPoint.position, playerAttackPoint.position) <= (enemyRange * 1.25))
            {
                enemySwing();
                nextEnemyAttackTime = Time.time + 1f / enemyAttackRate;
                animator.SetBool("EnemyAttacking", true);
            }
            else
            {
                animator.SetBool("EnemyAttacking", false);
            }
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
