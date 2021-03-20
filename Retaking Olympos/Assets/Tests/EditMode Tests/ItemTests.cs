using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ItemTests
    {
        // Tests that items exist for each of the 5 classes and can be found in the shop
        // For user story 47
        [Test]
        public void ItemTestThracian()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.PopulateWithShopItems();
            Item thracianSword = inventory.GetItemList().Find(x => x.itemName == Item.ItemName.Sword);
            Assert.IsNotNull(thracianSword);
        }

        [Test]
        public void ItemTestSamnite()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.PopulateWithShopItems();
            Item samniteSword = inventory.GetItemList().Find(x => x.itemName == Item.ItemName.Sword2);
            Assert.IsNotNull(samniteSword);
        }

        [Test]
        public void ItemTestSecutor()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.PopulateWithShopItems();
            Item secutorSword = inventory.GetItemList().Find(x => x.itemName == Item.ItemName.Sword3);
            Assert.IsNotNull(secutorSword);
        }

        [Test]
        public void ItemTestMurmillo()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.PopulateWithShopItems();
            Item murmilloSword = inventory.GetItemList().Find(x => x.itemName == Item.ItemName.Sword4);
            Assert.IsNotNull(murmilloSword);
        }

        [Test]
        public void ItemTestDimachaerus()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.PopulateWithShopItems();
            Item dimachaerusSword = inventory.GetItemList().Find(x => x.itemName == Item.ItemName.Sword5);
            Assert.IsNotNull(dimachaerusSword);
        }
    }
}
