using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SprintTest
    {
        [Test]
        public void SprintSpeedTest()
        {
            GameObject player = new GameObject();
            player.AddComponent<PlayerMovement>();
            PlayerMovement sprintTest = player.GetComponent<PlayerMovement>();

            sprintTest.mockUpdate();

            Assert.AreEqual(sprintTest.getSprintSpeed(), sprintTest.walkingSpeed * sprintTest.sprintSpeedMultiplier);
        }

        [Test]
        public void PlayerStaminaUpdateTest()
        {
            int originalStamina = PlayerGladiator.currentStamina;

            GameObject player = new GameObject();
            player.AddComponent<PlayerMovement>();
            PlayerMovement sprintTest = player.GetComponent<PlayerMovement>();

            sprintTest.sprint();

            Assert.IsTrue(originalStamina > PlayerGladiator.currentStamina);
        }
    }
}
