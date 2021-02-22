using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class HealthBarTest
    {
        [Test]
        public void setHealthTest()
        {
            GameObject player = new GameObject();
            player.AddComponent<HealthBar>();
            player.AddComponent<Slider>();
            HealthBar healthBar = player.GetComponent<HealthBar>();
            healthBar.slider = player.GetComponent<Slider>();
            healthBar.setHealth(1);
            Assert.AreEqual(1, healthBar.slider.value);
        }

        [Test]
        public void setMaxHealthTest()
        {
            GameObject player = new GameObject();
            player.AddComponent<HealthBar>();
            player.AddComponent<Slider>();
            HealthBar healthBar = player.GetComponent<HealthBar>();
            healthBar.slider = player.GetComponent<Slider>();
            healthBar.setMaxHealth(10);
            Assert.AreEqual(10, healthBar.slider.maxValue);
        }
    }
}
