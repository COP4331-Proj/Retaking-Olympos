using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class FightingMovesPlayTest
    {
        [OneTimeSetUp]
        public void LoadScene()
        {
            SceneManager.LoadScene("Game");
        }

        [UnityTest]
        public IEnumerator FightingMovesEnemyAttack()
        {
            GameObject enemy = GameObject.Find("Enemy Gladiator");
            GameObject player = GameObject.Find("Player Gladiator");
            GameObject attacks = GameObject.Find("FightingMoves");
            enemy.transform.position = new Vector2(player.transform.position.x, player.transform.position.y) + new Vector2(1, 0);
            yield return null;
            Assert.AreEqual(player.GetComponent<PlayerGladiator>().player.GetHealth() - 10, PlayerGladiator.currentHealth);
        }

    }
}
