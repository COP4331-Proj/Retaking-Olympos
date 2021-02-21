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
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.IsNotNull(gladiator);
        }


        [Test]
        public void TestGladiatorName() 
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetName(), "Caesar");
        }

        [Test]
        public void TestGladiatorLevel()
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetLevel(), 3);
        }

        [Test]
        public void TestGladiatorHealth()
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetHealth(), 100);
        }

        [Test]
        public void TestGladiatorStamina()
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetStamina(), 100);
        }

        [Test]
        public void TestGladiatorPower()
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetPower(), 6);
        }

        [Test]
        public void TestGladiatorDefense()
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.AreEqual(gladiator.GetDefense(), 14);
        }

        [Test]
        public void TestAddGladiatorToList() 
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            List<Gladiator> gladiatorList = viewGladiator.GetGladiatorList();
            Assert.AreEqual(0, gladiatorList.Count);
            viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            viewGladiator.createNewGladiator("Bob", 4, 120, 120, 10, 12);
            Assert.AreEqual(2, gladiatorList.Count);
        }
    }
}
