using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerGladiatorTest
    {
        
        [Test]
        public void StaminaRegenTest()
        {
            GameObject player = new GameObject();
            PlayerGladiator playerGlad = player.AddComponent<PlayerGladiator>();
            int maxStamina = PlayerGladiator.currentStamina;
            PlayerGladiator.currentStamina -= 1;
            playerGlad.staminaRegen();
            Assert.AreEqual(maxStamina, PlayerGladiator.currentStamina);
        }

    }
}
