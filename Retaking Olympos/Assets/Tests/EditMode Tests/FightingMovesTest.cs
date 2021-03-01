using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FightingMovesTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void FightingMovesTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        /*
        [Test]
        public void playerSwingTest()
        {
            GameObject player = new GameObject();
            GameObject enemy = new GameObject();
            GameObject moves = new GameObject();
            PlayerGladiator playerGlad = player.AddComponent<PlayerGladiator>();
            EnemyGladiator enemyGlad = enemy.AddComponent<EnemyGladiator>();
            FightingMoves attacks = moves.AddComponent<FightingMoves>();
            enemyGlad.healthBar = enemy.AddComponent<HealthBar>();
            enemyGlad.healthBar.slider = enemy.AddComponent<Slider>();
            enemyGlad.setupEnemyGladiator();
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
            attacks.enemySwing(playerGlad);
            Assert.AreEqual(80, playerGlad.getCurrentHealth());
        }
        */

    }
}
