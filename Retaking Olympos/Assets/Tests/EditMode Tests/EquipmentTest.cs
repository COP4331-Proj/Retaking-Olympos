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
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            Assert.IsNotNull(holdPlayerInformation);
        }

        [Test]
        public void EquipSword() 
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item sword = new Item { itemName = Item.ItemName.Sword, amount = 1 };
            holdPlayerInformation.individualGladiatorEquipment[0].weapon = sword;
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, sword);
        }

        [Test]
        public void EquipChestplate()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item chestplate = new Item { itemName = Item.ItemName.Chestplate, amount = 1 };
            holdPlayerInformation.individualGladiatorEquipment[0].weapon = chestplate;
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, chestplate);
        }

        [Test]
        public void EquipHelmet()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item helmet = new Item { itemName = Item.ItemName.Helmet, amount = 1 };
            holdPlayerInformation.individualGladiatorEquipment[0].weapon = helmet;
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, helmet);
        }

        [Test]
        public void EquipLegs()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item legs = new Item { itemName = Item.ItemName.Pants, amount = 1 };
            holdPlayerInformation.individualGladiatorEquipment[0].weapon = legs;
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, legs);
        }

        [Test]
        public void EquipBoots()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            holdPlayerInformation.individualGladiatorEquipment.Add(new IndividualGladiatorEquipment());
            Item boots = new Item { itemName = Item.ItemName.Boots, amount = 1 };
            holdPlayerInformation.individualGladiatorEquipment[0].weapon = boots;
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, boots);
        }
    }
}
