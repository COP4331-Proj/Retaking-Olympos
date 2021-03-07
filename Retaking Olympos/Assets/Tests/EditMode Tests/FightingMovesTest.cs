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
        public void playerSwingTest()
        {
            GameObject player = new GameObject();
            GameObject enemy = new GameObject();
            GameObject moves = new GameObject();
            PlayerGladiator playerGlad = player.AddComponent<PlayerGladiator>();
            EnemyGladiator enemyGlad = enemy.AddComponent<EnemyGladiator>();
            FightingMoves attacks = moves.AddComponent<FightingMoves>();
            enemyGlad.setupEnemyGladiator();
            EnemyGladiator.currentHealth = enemyGlad.enemy.GetHealth();
            attacks.playerSwing(enemyGlad);
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
            attacks.enemySwing(playerGlad);
            Assert.AreEqual(80, playerGlad.getCurrentHealth());
        }
    }
}
