using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ViewGladiatorTests
    {
        [Test]
        public void CreateGladiatorObject()
        {
            ViewGladiator viewGladiator = new ViewGladiator();
            Gladiator gladiator = viewGladiator.createNewGladiator("Caesar", 3, 100, 100, 6, 14);
            Assert.IsNotNull(gladiator);
        }

    }
}
