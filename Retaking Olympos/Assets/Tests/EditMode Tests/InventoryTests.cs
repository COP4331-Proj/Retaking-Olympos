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
            PlayerInventory inventory = new PlayerInventory();
            Assert.IsNotNull(inventory);
        }

        [Test]
        public void AddItemToInventory()
        {
            PlayerInventory inventory = new PlayerInventory();
            inventory.AddItem(new Item { itemName = Item.ItemName.Sword, cost = 500});
            Assert.AreEqual(1, inventory.itemList.Count);
        }

    }
}
