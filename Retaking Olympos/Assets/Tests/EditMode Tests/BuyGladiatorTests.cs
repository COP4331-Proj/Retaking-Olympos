using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BuyGladiatorTests
    {
        
        [Test]
        public void BuyGladiatorTest()
        {
            // Create controler game object and set up scriptable object
            GameObject controler = new GameObject();
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            holdPlayerInformation.gold = 1000;

            // Add view gladiator component and create a new gladiator in the shop
            controler.AddComponent<ViewGladiator>();
            controler.GetComponent<ViewGladiator>().holdPlayerInformation = holdPlayerInformation;
            controler.GetComponent<ViewGladiator>().createNewShopGladiator("Phil", 2, "Secutor");

            // Create new DisplayPurchasableGladiators component and set it up
            DisplayPurchasableGladiators dpg = controler.AddComponent<DisplayPurchasableGladiators>();
            dpg.holdPlayerInformation = holdPlayerInformation;
            dpg.viewGladiator = controler.GetComponent<ViewGladiator>();
            dpg.purchaseableGladiatorIndex = 0;
            dpg.gladiatorList = holdPlayerInformation.shopGladiatorList;

            // Assert that the player has no gladiators in their list
            Assert.AreEqual(0, holdPlayerInformation.gladiatorList.Count);

            // Buy a gladiator
            dpg.buyGladiator();

            // Assert that player has 1 gladiator in their inventory
            Assert.AreEqual(1, holdPlayerInformation.gladiatorList.Count);
        }

        [Test]
        public void BuyGladiatorTestRemoveFromShopInventory()
        {
            // Create controler game object and set up scriptable object
            GameObject controler = new GameObject();
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            holdPlayerInformation.gold = 1000;

            // Add view gladiator component and create a new gladiator in the shop
            controler.AddComponent<ViewGladiator>();
            controler.GetComponent<ViewGladiator>().holdPlayerInformation = holdPlayerInformation;
            controler.GetComponent<ViewGladiator>().createNewShopGladiator("Phil", 2, "Secutor");

            // Create new DisplayPurchasableGladiators component and set it up
            DisplayPurchasableGladiators dpg = controler.AddComponent<DisplayPurchasableGladiators>();
            dpg.holdPlayerInformation = holdPlayerInformation;
            dpg.viewGladiator = controler.GetComponent<ViewGladiator>();
            dpg.purchaseableGladiatorIndex = 0;
            dpg.gladiatorList = holdPlayerInformation.shopGladiatorList;

            // Assert that the player has no gladiators in their list
            Assert.AreEqual(0, holdPlayerInformation.gladiatorList.Count);

            // Buy a gladiator
            dpg.buyGladiator();

            // Assert that player has 1 gladiator in their inventory
            Assert.AreEqual(1, holdPlayerInformation.gladiatorList.Count);

            // Assert that the gladiator has been removed from the shop list
            Assert.AreEqual(0, holdPlayerInformation.shopGladiatorList.Count);
        }

        [Test]
        public void BuyGladiatorNotEnoughGoldTest()
        {
            // Create controler game object and set up scriptable object
            GameObject controler = new GameObject();
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            // Player has 0 gold so cant buy gladiator
            holdPlayerInformation.gold = 0;

            // Add view gladiator component and create a new gladiator in the shop
            controler.AddComponent<ViewGladiator>();
            controler.GetComponent<ViewGladiator>().holdPlayerInformation = holdPlayerInformation;
            controler.GetComponent<ViewGladiator>().createNewShopGladiator("Phil", 2, "Secutor");

            // Create new DisplayPurchasableGladiators component and set it up
            DisplayPurchasableGladiators dpg = controler.AddComponent<DisplayPurchasableGladiators>();
            dpg.holdPlayerInformation = holdPlayerInformation;
            dpg.viewGladiator = controler.GetComponent<ViewGladiator>();
            dpg.purchaseableGladiatorIndex = 0;
            dpg.gladiatorList = holdPlayerInformation.shopGladiatorList;

            // Assert that the player has no gladiators in their list
            Assert.AreEqual(0, holdPlayerInformation.gladiatorList.Count);

            // Attempt to buy a gladiator, but cant because 0 gold
            dpg.buyGladiator();

            // Assert that player has 0 gladiators in their inventory
            Assert.AreEqual(0, holdPlayerInformation.gladiatorList.Count);
        }
    }
}
