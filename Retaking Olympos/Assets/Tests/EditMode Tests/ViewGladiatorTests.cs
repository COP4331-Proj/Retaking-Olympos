using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ViewGladiatorTests
    {
        

        [Test]
        public void CreateGladiatorObject()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.IsNotNull(gladiator);
        }


        [Test]
        public void TestGladiatorName() 
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetName(), "Caesar");
        }

        [Test]
        public void TestGladiatorLevel()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetLevel(), 3);
        }

        [Test]
        public void TestGladiatorHealth()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetHealth(), 100);
        }

        [Test]
        public void TestGladiatorStamina()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetStamina(), 100);
        }

        [Test]
        public void TestGladiatorPower()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetPower(), 6);
        }

        [Test]
        public void TestGladiatorDefense()
        {
            GameObject controler = new GameObject();
            controler.AddComponent<ViewGladiator>();
            Gladiator gladiator = controler.GetComponent<ViewGladiator>().createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetDefense(), 14);
        }

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
    }
}
