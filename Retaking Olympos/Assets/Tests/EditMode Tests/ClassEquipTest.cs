using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    // Tests that each gladiator can only equip items of its own class
    // For user story 47
    public class ClassEquipTest
    {
        [Test]
        public void TestThracianCorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Thracian");
            // Create sword gladiator can equip
            Item thracianSword = new Item { itemName = Item.ItemName.Sword, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, thracianSword, 0);
            // Assert weapon equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, thracianSword);
        }

        [Test]
        public void TestThracianIncorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Thracian");
            // Create samnite sword, gladiator cant equip it
            Item sword = new Item { itemName = Item.ItemName.Sword2, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, sword, 0);
            // assert weapon not equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, null);
        }

        [Test]
        public void TestSamniteCorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Samnite");
            // Create sword gladiator can equip
            Item sword = new Item { itemName = Item.ItemName.Sword2, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, sword, 0);
            // Assert weapon equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, sword);
        }

        [Test]
        public void TestSamniteIncorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Samnite");
            // Create thracian sword, gladiator cant equip it
            Item sword = new Item { itemName = Item.ItemName.Sword, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, sword, 0);
            // assert weapon not equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, null);
        }

        [Test]
        public void TestSecutorCorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Secutor");
            // Create sword gladiator can equip
            Item sword = new Item { itemName = Item.ItemName.Sword3, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, sword, 0);
            // Assert weapon equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, sword);
        }

        [Test]
        public void TestSecutorIncorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Secutor");
            // Create thracian sword, gladiator cant equip it
            Item sword = new Item { itemName = Item.ItemName.Sword, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, sword, 0);
            // assert weapon not equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, null);
        }

        [Test]
        public void TestMurmilloCorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Murmillo");
            // Create sword gladiator can equip
            Item thracianSword = new Item { itemName = Item.ItemName.Sword4, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, thracianSword, 0);
            // Assert weapon equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, thracianSword);
        }

        [Test]
        public void TestMurmilloIncorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Murmillo");
            // Create thracian sword, gladiator cant equip it
            Item samniteSword = new Item { itemName = Item.ItemName.Sword, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, samniteSword, 0);
            // assert weapon not equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, null);
        }

        [Test]
        public void TestDimachaerusCorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Dimachaerus");
            // Create sword gladiator can equip
            Item thracianSword = new Item { itemName = Item.ItemName.Sword5, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, thracianSword, 0);
            // Assert weapon equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, thracianSword);
        }

        [Test]
        public void TestDimachaerusIncorrectEquip()
        {
            // Set up game object
            GameObject gameObject = new GameObject();
            ViewGladiator viewGladiator = gameObject.AddComponent<ViewGladiator>();
            GladiatorEquiptment gladiatorEquiptment = gameObject.AddComponent<GladiatorEquiptment>();
            UIInventory uIInventory = gameObject.AddComponent<UIInventory>();

            // Set up links
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            viewGladiator.holdPlayerInformation = holdPlayerInformation;
            uIInventory.inventory = holdPlayerInformation.playerInventory;
            gladiatorEquiptment.playerInformation = holdPlayerInformation;
            gladiatorEquiptment.uIInventory = uIInventory;

            // Create Gladiator
            viewGladiator.createNewGladiator("Phil", 1, "Dimachaerus");
            // Create thracian sword, gladiator cant equip it
            Item samniteSword = new Item { itemName = Item.ItemName.Sword, amount = 1 };
            gladiatorEquiptment.testEquip(GladiatorEquiptment.SlotName.Sword, samniteSword, 0);
            // assert weapon not equipped
            Assert.AreEqual(holdPlayerInformation.individualGladiatorEquipment[0].weapon, null);
        }
    }
}
