using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;

namespace Tests
{
    public class DisplayMoneyTest
    {

        // Test that text game object can be changed via a controler
        [Test]
        public void DisplayMoneyTestSimplePasses()
        {
            GameObject controler = new GameObject();
            GameObject text = new GameObject();

            text.AddComponent<TextMeshProUGUI>();

            controler.AddComponent<DisplayGold>();
            controler.GetComponent<DisplayGold>().goldText = text.GetComponent<TextMeshProUGUI>();
            controler.GetComponent<DisplayGold>().playerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();

            controler.GetComponent<DisplayGold>().playerInformation.gold = 0;
            controler.GetComponent<DisplayGold>().goldText.text = controler.GetComponent<DisplayGold>().playerInformation.gold.ToString();

            Assert.AreEqual(controler.GetComponent<DisplayGold>().goldText.text, "0");

            controler.GetComponent<DisplayGold>().playerInformation.gold = 100;
            controler.GetComponent<DisplayGold>().goldText.text = controler.GetComponent<DisplayGold>().playerInformation.gold.ToString();

            Assert.AreEqual(controler.GetComponent<DisplayGold>().goldText.text, "100");
        }

    }
}
