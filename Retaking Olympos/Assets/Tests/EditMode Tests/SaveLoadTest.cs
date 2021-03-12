using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SaveLoadTest
    {
        [Test]
        public void SaveLoadPlayerGladiatorTest()
        {
            GameObject player = new GameObject();
            player.AddComponent<PlayerGladiator>();
            PlayerGladiator dummyPlayer = player.GetComponent<PlayerGladiator>();

            // We will test the save/loading scripts by modifying the power levels, saving, changing it again, then loading.
            PlayerGladiator.currentPower = 9001;
            dummyPlayer.SavePlayerGladiatorData();
            PlayerGladiator.currentPower = 1;
            dummyPlayer.LoadPlayerGladiatorData();

            Assert.AreEqual(PlayerGladiator.currentPower, 9001);

        }
    }
}
