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
            int previousHealth = EnemyGladiator.currentHealth;
            EnemyGladiator.currentHealth = enemyGlad.enemy.GetHealth();
            attacks.playerHit(enemyGlad);
            Assert.AreEqual(previousHealth - 10, enemyGlad.getCurrentHealth());
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
            attacks.enemy = enemyGlad;
            attacks.enemy.enemy = new Gladiator("Enemy", 1, 100, 100, 6, 14);
            PlayerGladiator.currentHealth = playerGlad.player.GetHealth();
            int previousHealth = PlayerGladiator.currentHealth;
            attacks.enemyHit(playerGlad);
            Assert.AreEqual(previousHealth - 10, playerGlad.getCurrentHealth());
        }

        [Test]
        public void playerDodgingTest()
        {
            GameObject combat = new GameObject();
            FightingMoves dodging = combat.AddComponent<FightingMoves>();
            dodging.playerDodgeStart();
            Assert.AreEqual(dodging.playerLayers.value, LayerMask.GetMask("Default"));
            dodging.playerDodgeEnd();
            Assert.AreEqual(dodging.playerLayers.value, LayerMask.GetMask("Player"));
        }

        [Test]
        public void playerBlockingTest()
        {
            GameObject combat = new GameObject();
            FightingMoves dodging = combat.AddComponent<FightingMoves>();
            dodging.playerBlockStart();
            Assert.AreEqual(dodging.playerLayers.value, LayerMask.GetMask("Default"));
            dodging.playerBlockEnd();
            Assert.AreEqual(dodging.playerLayers.value, LayerMask.GetMask("Player"));
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
