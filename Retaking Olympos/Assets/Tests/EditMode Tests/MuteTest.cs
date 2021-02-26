using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MuteTest
    {
        private bool expectedMuteState = AudioListener.pause;

        [Test]
        public void MuteTestSimplePasses()
        {
            Assert.AreEqual(expectedMuteState, MuteManager.getMuteState());
        }
    }
}
