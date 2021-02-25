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
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword, cost = 500});
            Assert.AreEqual(1, inventory.GetItemList().Count);
        }

    }
}
