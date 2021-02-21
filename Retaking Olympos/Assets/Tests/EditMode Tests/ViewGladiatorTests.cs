using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;

namespace Tests
{
    public class ViewGladiatorTests
    {
        
        // Tests that gladiator objects are created correctly
        [Test]
        public void TestCreateGladiatorObject()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            Assert.IsNotNull(gladiator);
        }

        // Tests that gladiator name is assigned correctly
        [Test]
        public void TestGladiatorName() 
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            Assert.AreEqual(gladiator.GetName(), "Caesar");
        }

        // Tests that gladiator level is assigned correctly
        [Test]
        public void TestGladiatorLevel()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            Assert.AreEqual(gladiator.GetLevel(), 3);
        }

        // Tests that gladiator health is assigned correctly
        [Test]
        public void TestGladiatorHealth()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            Assert.AreEqual(gladiator.GetHealth(), 100);
        }

        // Tests that gladiator stamina is assigned correctly
        [Test]
        public void TestGladiatorStamina()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            Assert.AreEqual(gladiator.GetStamina(), 100);
        }

        // Tests that gladiator power is assigned correctly
        [Test]
        public void TestGladiatorPower()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            Assert.AreEqual(gladiator.GetPower(), 6);
        }

        // Tests that gladiator defense is assigned correctly
        [Test]
        public void TestGladiatorDefense()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            Assert.AreEqual(gladiator.GetDefense(), 14);
        }

        // Tests that adding gladiators to a list works correctly
        [Test]
        public void TestAddGladiatorToList() 
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();

            List<Gladiator> gladiatorList = controler.GetComponent<ViewGladiator>().GetGladiatorList();

            Assert.AreEqual(0, gladiatorList.Count);

            controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            controler.GetComponent<ViewGladiator>().createNewGladiator("Bob", 4, 120, 120, 10, 12);

            Assert.AreEqual(2, gladiatorList.Count);
        }

        // Tests that assigining a value to a Text mesh pro field works correctly
        [Test]
        public void TestDisplayGladiatorStats() 
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();

            List<Gladiator> gladiatorList = controler.GetComponent<ViewGladiator>().GetGladiatorList();
            controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);

            GameObject text = new GameObject();
            text.AddComponent<TextMeshProUGUI>();

            // Test String name field
            text.GetComponent<TextMeshProUGUI>().text = gladiatorList[0].GetName().ToString();
            Assert.AreEqual(text.GetComponent<TextMeshProUGUI>().text, gladiatorList[0].GetName().ToString());

            // Test health int field (is displayed as a string anyways, but just to make sure both stored datatypes work)
            text.GetComponent<TextMeshProUGUI>().text = gladiatorList[0].GetHealth().ToString();
            Assert.AreEqual(text.GetComponent<TextMeshProUGUI>().text, gladiatorList[0].GetHealth().ToString());
        }
    }
}
