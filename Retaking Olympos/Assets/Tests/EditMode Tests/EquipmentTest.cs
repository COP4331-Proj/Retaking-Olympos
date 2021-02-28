using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EquipmentTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CreateInventory() 
        {
            HoldPlayerEquipment holdPlayerEquipment = ScriptableObject.CreateInstance<HoldPlayerEquipment>();
            Assert.IsNotNull(holdPlayerEquipment);
        }

        [Test]
        public void EquipSword() 
        {
            HoldPlayerEquipment holdPlayerEquipment = ScriptableObject.CreateInstance<HoldPlayerEquipment>();
            holdPlayerEquipment.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item sword = new Item { itemName = Item.ItemName.Sword, amount = 1 };
            holdPlayerEquipment.individualGladiatorEquipment[0].weapon = sword;
            Assert.AreEqual(holdPlayerEquipment.individualGladiatorEquipment[0].weapon, sword);
        }

        [Test]
        public void EquipChestplate()
        {
            HoldPlayerEquipment holdPlayerEquipment = ScriptableObject.CreateInstance<HoldPlayerEquipment>();
            holdPlayerEquipment.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item chestplate = new Item { itemName = Item.ItemName.Chestplate, amount = 1 };
            holdPlayerEquipment.individualGladiatorEquipment[0].weapon = chestplate;
            Assert.AreEqual(holdPlayerEquipment.individualGladiatorEquipment[0].weapon, chestplate);
        }

        [Test]
        public void EquipHelmet()
        {
            HoldPlayerEquipment holdPlayerEquipment = ScriptableObject.CreateInstance<HoldPlayerEquipment>();
            holdPlayerEquipment.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item helmet = new Item { itemName = Item.ItemName.Helmet, amount = 1 };
            holdPlayerEquipment.individualGladiatorEquipment[0].weapon = helmet;
            Assert.AreEqual(holdPlayerEquipment.individualGladiatorEquipment[0].weapon, helmet);
        }

        [Test]
        public void EquipLegs()
        {
            HoldPlayerEquipment holdPlayerEquipment = ScriptableObject.CreateInstance<HoldPlayerEquipment>();
            holdPlayerEquipment.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item legs = new Item { itemName = Item.ItemName.Pants, amount = 1 };
            holdPlayerEquipment.individualGladiatorEquipment[0].weapon = legs;
            Assert.AreEqual(holdPlayerEquipment.individualGladiatorEquipment[0].weapon, legs);
        }

        [Test]
        public void EquipBoots()
        {
            HoldPlayerEquipment holdPlayerEquipment = ScriptableObject.CreateInstance<HoldPlayerEquipment>();
            holdPlayerEquipment.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item boots = new Item { itemName = Item.ItemName.Boots, amount = 1 };
            holdPlayerEquipment.individualGladiatorEquipment[0].weapon = boots;
            Assert.AreEqual(holdPlayerEquipment.individualGladiatorEquipment[0].weapon, boots);
        }
    }
}
