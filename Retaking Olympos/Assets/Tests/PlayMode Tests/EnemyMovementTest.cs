using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class EnemyMovementTest
    {
        [OneTimeSetUp]
        public void LoadScene()
        {
            SceneManager.LoadScene("Game");
        }

        [UnityTest]
        public IEnumerator enemyChaseTest()
        {
            GameObject enemy = GameObject.Find("Enemy Gladiator");
            GameObject player = GameObject.Find("Player Gladiator");
            float originalDistance = Vector2.Distance(enemy.GetComponent<Transform>().position,
                enemy.GetComponent<EnemyMovement>().playerChar.position);
            yield return null;
            Assert.AreEqual(Vector2.Distance(enemy.GetComponent<Transform>().position,
                enemy.GetComponent<EnemyMovement>().playerChar.position), originalDistance - enemy.GetComponent<EnemyMovement>().movementSpeed * Time.deltaTime);
        }
    }
}
