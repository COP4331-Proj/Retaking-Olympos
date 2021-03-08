using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class FightingMovesTest
    {
        [Test]
        public void playerHitTest()
        {
            GameObject player = new GameObject();
            GameObject enemy = new GameObject();
            GameObject moves = new GameObject();
            PlayerGladiator playerGlad = player.AddComponent<PlayerGladiator>();
            EnemyGladiator enemyGlad = enemy.AddComponent<EnemyGladiator>();
            FightingMoves attacks = moves.AddComponent<FightingMoves>();
            enemyGlad.setupEnemyGladiator();
            EnemyGladiator.currentHealth = enemyGlad.enemy.GetHealth();
            attacks.playerHit(enemyGlad);
            Assert.AreEqual(80, enemyGlad.getCurrentHealth());
        }

        [Test]
        public void enemyHitTest()
        {
            GameObject player = new GameObject();
            GameObject enemy = new GameObject();
            GameObject moves = new GameObject();
            PlayerGladiator playerGlad = player.AddComponent<PlayerGladiator>();
            EnemyGladiator enemyGlad = enemy.AddComponent<EnemyGladiator>();
            FightingMoves attacks = moves.AddComponent<FightingMoves>();
            PlayerGladiator.currentHealth = playerGlad.player.GetHealth();
            attacks.enemyHit(playerGlad);
            Assert.AreEqual(80, playerGlad.getCurrentHealth());
        }

        /* Work in Progress
        [Test]
        public void playerSwingTest()
        {
            GameObject player = new GameObject();
            GameObject enemy = new GameObject();
            GameObject moves = new GameObject();
            PlayerGladiator playerGlad = player.AddComponent<PlayerGladiator>();
            EnemyGladiator enemyGlad = enemy.AddComponent<EnemyGladiator>();
            FightingMoves attacks = moves.AddComponent<FightingMoves>();
            Transform playerAttackPoint = player.GetComponent<Transform>();
            Transform enemyAttackPoint = enemy.GetComponent<Transform>();
            player.AddComponent<Rigidbody2D>();
            enemy.AddComponent<Rigidbody2D>();
            player.AddComponent<BoxCollider2D>();
            enemy.AddComponent<BoxCollider2D>();
            attacks.playerLayers = 0;
            attacks.enemyLayers = 0;
            enemyGlad.setupEnemyGladiator();
            EnemyGladiator.currentHealth = enemyGlad.enemy.GetHealth();
            attacks.playerSwing();
            Assert.AreEqual(80, enemyGlad.getCurrentHealth());
        }

        [Test]
        public void enemySwingTest()
        {
            GameObject player = new GameObject();
            GameObject enemy = new GameObject();
            GameObject moves = new GameObject();
            PlayerGladiator playerGlad = player.AddComponent<PlayerGladiator>();
            EnemyGladiator enemyGlad = enemy.AddComponent<EnemyGladiator>();
            FightingMoves attacks = moves.AddComponent<FightingMoves>();
            PlayerGladiator.currentHealth = playerGlad.player.GetHealth();
            attacks.enemySwing();
            Assert.AreEqual(80, playerGlad.getCurrentHealth());
        }
        */
    }
}
