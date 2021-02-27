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
            HoldPlayerInventory holdPlayerInventory = ScriptableObject.CreateInstance<HoldPlayerInventory>();
            Assert.IsNotNull(holdPlayerInventory);
        }

        [Test]
        public void AddItemToInventory()
        {
            HoldPlayerInventory holdPlayerInventory = ScriptableObject.CreateInstance<HoldPlayerInventory>();
            PlayerInventory inventory = holdPlayerInventory.playerInventory;
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword});
            Assert.AreEqual(1, inventory.GetItemList().Count);
        }


        [Test]
        public void RemoveItemFromInventory()
        {
            HoldPlayerInventory holdPlayerInventory = ScriptableObject.CreateInstance<HoldPlayerInventory>();
            PlayerInventory inventory = holdPlayerInventory.playerInventory;
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword});
            List<Item> itemList = inventory.GetItemList();
            Assert.AreEqual(1, itemList.Count);

            Item item = itemList[0];
            inventory.RemoveItem(item);
            Assert.AreEqual(0, itemList.Count);
        }
    }
}
