using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class StaminaBarTest
    {
        [Test]
        public void setStaminaTest()
        {
            GameObject player = new GameObject();
            player.AddComponent<StaminaBar>();
            player.AddComponent<Slider>();
            StaminaBar staminaBar = player.GetComponent<StaminaBar>();
            staminaBar.slider = player.GetComponent<Slider>();
            staminaBar.setStamina(1);
            Assert.AreEqual(1, staminaBar.slider.value);
        }

        [Test]
        public void setMaxStaminaTest()
        {
            GameObject player = new GameObject();
            player.AddComponent<StaminaBar>();
            player.AddComponent<Slider>();
            StaminaBar staminaBar = player.GetComponent<StaminaBar>();
            staminaBar.slider = player.GetComponent<Slider>();
            staminaBar.setMaxStamina(10);
            Assert.AreEqual(10, staminaBar.slider.maxValue);
        }
    }
}
