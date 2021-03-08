using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DifficultyTest
    {
        [Test]
        public void HealthTest()
        {
            float difficulty = PlayerPrefs.HasKey("DifficultyPreference") ? PlayerPrefs.GetFloat("DifficultyPreference") : 1f;
            int expectedHealth = (int) (difficulty * 100);

            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            controler.GetComponent<ViewGladiator>().holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, (int)(difficulty * 100), 100, 6, 14);

            Assert.AreEqual(expectedHealth, gladiator.GetHealth());
        }

    }
}
