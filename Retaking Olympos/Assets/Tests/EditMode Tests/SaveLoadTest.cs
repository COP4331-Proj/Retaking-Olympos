using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SaveLoadTest
    {
        [Test]
        public void SaveLoadPlayerGladiatorTest()
        {
            GameObject player = new GameObject();
            player.AddComponent<PlayerGladiator>();
            PlayerGladiator dummyPlayer = player.GetComponent<PlayerGladiator>();

            // We will test the save/loading scripts by modifying the power levels, saving, changing it again, then loading.
            PlayerGladiator.currentPower = 9001;
            dummyPlayer.SavePlayerGladiatorData();
            PlayerGladiator.currentPower = 1;
            dummyPlayer.LoadPlayerGladiatorData();

            Assert.AreEqual(PlayerGladiator.currentPower, 9001);

        }

        [Test]
        public void SaveLoadEnemyGladiatorTest()
        {
            int startingHealth;

            GameObject enemy = new GameObject();
            enemy.AddComponent<EnemyGladiator>();
            EnemyGladiator dummyEnemy = enemy.GetComponent<EnemyGladiator>();

            // We will test the save/loading scripts by modifying the health, saving, changing it again, then loading.
            startingHealth = EnemyGladiator.currentHealth = 150;
            dummyEnemy.SaveEnemyGladiatorData();
            EnemyGladiator.currentHealth = 0;

            dummyEnemy.LoadEnemyGladiatorData();
            Assert.IsTrue(startingHealth > 0);
            Assert.AreEqual(EnemyGladiator.currentHealth, startingHealth);
        }
    }
}
