using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class InventoryTests
    {
        

        [Test]
        public void CreateInventory()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            Assert.IsNotNull(holdPlayerInformation);
        }

        [Test]
        public void AddItemToInventory()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.playerInventory;
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword});
            Assert.AreEqual(1, inventory.GetItemList().Count);
        }


        [Test]
        public void RemoveItemFromInventory()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.playerInventory;
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword});
            List<Item> itemList = inventory.GetItemList();
            Assert.AreEqual(1, itemList.Count);

            Item item = itemList[0];
            inventory.RemoveItem(item);
            Assert.AreEqual(0, itemList.Count);
        }

        [Test]
        public void SellItem()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.playerInventory;
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword });
            List<Item> itemList = inventory.GetItemList();
            Assert.AreEqual(1, itemList.Count);

            Item item = itemList[0];
            inventory.RemoveItem(item);
            holdPlayerInformation.gold += item.GetSellPrice();
            Assert.AreEqual(75, holdPlayerInformation.gold);

        }
        [Test]
        public void CreateShopInventory() 
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.PopulateWithShopItems();
            List<Item> itemList = inventory.GetItemList();
            Assert.AreEqual(itemList.Count, 23);
        }

        [Test]
        public void AddItemToShop()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword });
            Assert.AreEqual(1, inventory.GetItemList().Count);
        }

        [Test]
        public void RemoveItemFromShop()
        {
            HoldPlayerInformation holdPlayerInformation = ScriptableObject.CreateInstance<HoldPlayerInformation>();
            PlayerInventory inventory = holdPlayerInformation.shopInventory;
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword });
            List<Item> itemList = inventory.GetItemList();
            Assert.AreEqual(1, itemList.Count);

            Item item = itemList[0];
            inventory.RemoveItem(item);
            Assert.AreEqual(0, itemList.Count);
        }
    }
}
