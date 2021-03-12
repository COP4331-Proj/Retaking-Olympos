using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    // If we ever play around with the base stats, be sure to update the expected stats in these tests!
    public class GladiatorClassTest
    {
        [Test]
        public void TharcianTest()
        {
            Tharcian NoobTharcian = new Tharcian("Billy", 1);
            Tharcian IntermediateTharcian = new Tharcian("Joe", 10);
            Tharcian AdvancedTharcian = new Tharcian("Oziach", 100);

            string expectedClassName = "Tharcian";

            // Test that they're all the right class
            Assert.AreEqual(expectedClassName, NoobTharcian.GetClass());
            Assert.AreEqual(expectedClassName, IntermediateTharcian.GetClass());
            Assert.AreEqual(expectedClassName, AdvancedTharcian.GetClass());

            // Get the expected stat values for the noob tharcian and test if they're the same as the actual values
            // These values are calculated in the Tharcian class
            string expectedName = "Billy";
            int expectedLevel = 1;
            int expectedHealth = 100;
            int expectedStamina = 120;
            int expectedPower = 100;
            int expectedDefense = 100;
            Assert.AreEqual(expectedName, NoobTharcian.GetName());
            Assert.AreEqual(expectedLevel, NoobTharcian.GetLevel());
            Assert.AreEqual(expectedHealth, NoobTharcian.GetHealth());
            Assert.AreEqual(expectedStamina, NoobTharcian.GetStamina());
            Assert.AreEqual(expectedPower, NoobTharcian.GetPower());
            Assert.AreEqual(expectedDefense, NoobTharcian.GetDefense());

            // Do the same with the intermediate tharcian
            expectedName = "Joe";
            expectedLevel = 10;
            expectedHealth = 325;
            expectedStamina = 480;
            expectedPower = 325;
            expectedDefense = 325;
            Assert.AreEqual(expectedName, IntermediateTharcian.GetName());
            Assert.AreEqual(expectedLevel, IntermediateTharcian.GetLevel());
            Assert.AreEqual(expectedHealth, IntermediateTharcian.GetHealth());
            Assert.AreEqual(expectedStamina, IntermediateTharcian.GetStamina());
            Assert.AreEqual(expectedPower, IntermediateTharcian.GetPower());
            Assert.AreEqual(expectedDefense, IntermediateTharcian.GetDefense());

            // Do the same with the advanced tharcian
            expectedName = "Oziach";
            expectedLevel = 100;
            expectedHealth = 2575;
            expectedStamina = 4080;
            expectedPower = 2575;
            expectedDefense = 2575;
            Assert.AreEqual(expectedLevel, AdvancedTharcian.GetLevel());
            Assert.AreEqual(expectedHealth, AdvancedTharcian.GetHealth());
            Assert.AreEqual(expectedStamina, AdvancedTharcian.GetStamina());
            Assert.AreEqual(expectedPower, AdvancedTharcian.GetPower());
            Assert.AreEqual(expectedDefense, AdvancedTharcian.GetDefense());

            // Test the level up function
            AdvancedTharcian.LevelUp();
            expectedLevel = 101;
            expectedHealth = 2600;
            expectedStamina = 4120;
            expectedPower = 2600;
            expectedDefense = 2600;
            Assert.AreEqual(expectedLevel, AdvancedTharcian.GetLevel());
            Assert.AreEqual(expectedHealth, AdvancedTharcian.GetHealth());
            Assert.AreEqual(expectedStamina, AdvancedTharcian.GetStamina());
            Assert.AreEqual(expectedPower, AdvancedTharcian.GetPower());
            Assert.AreEqual(expectedDefense, AdvancedTharcian.GetDefense());
        }

        [Test]
        public void SecutorTest()
        {
            Secutor NoobSecutor = new Secutor("Billy", 1);
            Secutor IntermediateSecutor = new Secutor("Joe", 10);
            Secutor AdvancedSecutor = new Secutor("Oziach", 100);

            string expectedClassName = "Secutor";

            // Test that they're all the right class
            Assert.AreEqual(expectedClassName, NoobSecutor.GetClass());
            Assert.AreEqual(expectedClassName, IntermediateSecutor.GetClass());
            Assert.AreEqual(expectedClassName, AdvancedSecutor.GetClass());

            // Get the expected stat values for the noob secutor and test if they're the same as the actual values
            // These values are calculated in the secutor class
            string expectedName = "Billy";
            int expectedLevel = 1;
            int expectedHealth = 105;
            int expectedStamina = 80;
            int expectedPower = 100;
            int expectedDefense = 115;
            Assert.AreEqual(expectedName, NoobSecutor.GetName());
            Assert.AreEqual(expectedLevel, NoobSecutor.GetLevel());
            Assert.AreEqual(expectedHealth, NoobSecutor.GetHealth());
            Assert.AreEqual(expectedStamina, NoobSecutor.GetStamina());
            Assert.AreEqual(expectedPower, NoobSecutor.GetPower());
            Assert.AreEqual(expectedDefense, NoobSecutor.GetDefense());

            // Do the same with the intermediate secutor
            expectedName = "Joe";
            expectedLevel = 10;
            expectedHealth = 375;
            expectedStamina = 215;
            expectedPower = 325;
            expectedDefense = 475;
            Assert.AreEqual(expectedName, IntermediateSecutor.GetName());
            Assert.AreEqual(expectedLevel, IntermediateSecutor.GetLevel());
            Assert.AreEqual(expectedHealth, IntermediateSecutor.GetHealth());
            Assert.AreEqual(expectedStamina, IntermediateSecutor.GetStamina());
            Assert.AreEqual(expectedPower, IntermediateSecutor.GetPower());
            Assert.AreEqual(expectedDefense, IntermediateSecutor.GetDefense());

            // Do the same with the advanced secutor
            expectedName = "Oziach";
            expectedLevel = 100;
            expectedHealth = 3075;
            expectedStamina = 1565;
            expectedPower = 2575;
            expectedDefense = 4075;

            Assert.AreEqual(expectedName, AdvancedSecutor.GetName());
            Assert.AreEqual(expectedLevel, AdvancedSecutor.GetLevel());
            Assert.AreEqual(expectedHealth, AdvancedSecutor.GetHealth());
            Assert.AreEqual(expectedStamina, AdvancedSecutor.GetStamina());
            Assert.AreEqual(expectedPower, AdvancedSecutor.GetPower());
            Assert.AreEqual(expectedDefense, AdvancedSecutor.GetDefense());

            // Test the level up function
            AdvancedSecutor.LevelUp();
            expectedLevel = 101;
            expectedHealth = 3105;
            expectedStamina = 1580;
            expectedPower = 2600;
            expectedDefense = 4115;
            Assert.AreEqual(expectedLevel, AdvancedSecutor.GetLevel());
            Assert.AreEqual(expectedHealth, AdvancedSecutor.GetHealth());
            Assert.AreEqual(expectedStamina, AdvancedSecutor.GetStamina());
            Assert.AreEqual(expectedPower, AdvancedSecutor.GetPower());
            Assert.AreEqual(expectedDefense, AdvancedSecutor.GetDefense());
        }

        [Test]
        public void SamniteTest()
        {
            Samnite Noob = new Samnite("Billy", 1);
            Samnite Intermediate = new Samnite("Joe", 10);
            Samnite Advanced = new Samnite("Oziach", 100);

            string expectedClassName = "Samnite";

            // Test that they're all the right class
            Assert.AreEqual(expectedClassName, Noob.GetClass());
            Assert.AreEqual(expectedClassName, Intermediate.GetClass());
            Assert.AreEqual(expectedClassName, Advanced.GetClass());

            // Get the expected stat values for the noob samnite and test if they're the same as the actual values
            // These values are calculated in the Samnite class
            string expectedName = "Billy";
            int expectedLevel = 1;
            int expectedHealth = 100;
            int expectedStamina = 100;
            int expectedPower = 100;
            int expectedDefense = 100;
            Assert.AreEqual(expectedName, Noob.GetName());
            Assert.AreEqual(expectedLevel, Noob.GetLevel());
            Assert.AreEqual(expectedHealth, Noob.GetHealth());
            Assert.AreEqual(expectedStamina, Noob.GetStamina());
            Assert.AreEqual(expectedPower, Noob.GetPower());
            Assert.AreEqual(expectedDefense, Noob.GetDefense());

            // Do the same with the intermediate samnite
            expectedName = "Joe";
            expectedLevel = 10;
            expectedHealth = 325;
            expectedStamina = 325;
            expectedPower = 325;
            expectedDefense = 325;
            Assert.AreEqual(expectedName, Intermediate.GetName());
            Assert.AreEqual(expectedLevel, Intermediate.GetLevel());
            Assert.AreEqual(expectedHealth, Intermediate.GetHealth());
            Assert.AreEqual(expectedStamina, Intermediate.GetStamina());
            Assert.AreEqual(expectedPower, Intermediate.GetPower());
            Assert.AreEqual(expectedDefense, Intermediate.GetDefense());

            // Do the same with the advanced samnite
            expectedName = "Oziach";
            expectedLevel = 100;
            expectedHealth = 2575;
            expectedStamina = 2575;
            expectedPower = 2575;
            expectedDefense = 2575;

            Assert.AreEqual(expectedName, Advanced.GetName());
            Assert.AreEqual(expectedLevel, Advanced.GetLevel());
            Assert.AreEqual(expectedHealth, Advanced.GetHealth());
            Assert.AreEqual(expectedStamina, Advanced.GetStamina());
            Assert.AreEqual(expectedPower, Advanced.GetPower());
            Assert.AreEqual(expectedDefense, Advanced.GetDefense());

            // Test the level up function
            Advanced.LevelUp();
            expectedLevel = 101;
            expectedHealth = 2600;
            expectedStamina = 2600;
            expectedPower = 2600;
            expectedDefense = 2600;
            Assert.AreEqual(expectedLevel, Advanced.GetLevel());
            Assert.AreEqual(expectedHealth, Advanced.GetHealth());
            Assert.AreEqual(expectedStamina, Advanced.GetStamina());
            Assert.AreEqual(expectedPower, Advanced.GetPower());
            Assert.AreEqual(expectedDefense, Advanced.GetDefense());
        }

        [Test]
        public void MurmilloTest()
        {
            Murmillo Noob = new Murmillo("Billy", 1);
            Murmillo Intermediate = new Murmillo("Joe", 10);
            Murmillo Advanced = new Murmillo("Oziach", 100);

            string expectedClassName = "Murmillo";

            // Test that they're all the right class
            Assert.AreEqual(expectedClassName, Noob.GetClass());
            Assert.AreEqual(expectedClassName, Intermediate.GetClass());
            Assert.AreEqual(expectedClassName, Advanced.GetClass());

            // Get the expected stat values for the noob murmillo and test if they're the same as the actual values
            // These values are calculated in the Murmillo class
            string expectedName = "Billy";
            int expectedLevel = 1;
            int expectedHealth = 100;
            int expectedStamina = 80;
            int expectedPower = 110;
            int expectedDefense = 100;
            Assert.AreEqual(expectedName, Noob.GetName());
            Assert.AreEqual(expectedLevel, Noob.GetLevel());
            Assert.AreEqual(expectedHealth, Noob.GetHealth());
            Assert.AreEqual(expectedStamina, Noob.GetStamina());
            Assert.AreEqual(expectedPower, Noob.GetPower());
            Assert.AreEqual(expectedDefense, Noob.GetDefense());

            // Do the same with the intermediate murmillo
            expectedName = "Joe";
            expectedLevel = 10;
            expectedHealth = 325;
            expectedStamina = 215;
            expectedPower = 425;
            expectedDefense = 325;
            Assert.AreEqual(expectedName, Intermediate.GetName());
            Assert.AreEqual(expectedLevel, Intermediate.GetLevel());
            Assert.AreEqual(expectedHealth, Intermediate.GetHealth());
            Assert.AreEqual(expectedStamina, Intermediate.GetStamina());
            Assert.AreEqual(expectedPower, Intermediate.GetPower());
            Assert.AreEqual(expectedDefense, Intermediate.GetDefense());

            // Do the same with the advanced murmillo
            expectedName = "Oziach";
            expectedLevel = 100;
            expectedHealth = 2575;
            expectedStamina = 1565;
            expectedPower = 3575;
            expectedDefense = 2575;

            Assert.AreEqual(expectedName, Advanced.GetName());
            Assert.AreEqual(expectedLevel, Advanced.GetLevel());
            Assert.AreEqual(expectedHealth, Advanced.GetHealth());
            Assert.AreEqual(expectedStamina, Advanced.GetStamina());
            Assert.AreEqual(expectedPower, Advanced.GetPower());
            Assert.AreEqual(expectedDefense, Advanced.GetDefense());

            // Test the level up function
            Advanced.LevelUp();
            expectedLevel = 101;
            expectedHealth = 2600;
            expectedStamina = 1580;
            expectedPower = 3610;
            expectedDefense = 2600;
            Assert.AreEqual(expectedLevel, Advanced.GetLevel());
            Assert.AreEqual(expectedHealth, Advanced.GetHealth());
            Assert.AreEqual(expectedStamina, Advanced.GetStamina());
            Assert.AreEqual(expectedPower, Advanced.GetPower());
            Assert.AreEqual(expectedDefense, Advanced.GetDefense());
        }

        [Test]
        public void DimachaerusTest()
        {
            Dimachaerus Noob = new Dimachaerus("Billy", 1);
            Dimachaerus Intermediate = new Dimachaerus("Joe", 10);
            Dimachaerus Advanced = new Dimachaerus("Oziach", 100);

            string expectedClassName = "Dimachaerus";

            // Test that they're all the right class
            Assert.AreEqual(expectedClassName, Noob.GetClass());
            Assert.AreEqual(expectedClassName, Intermediate.GetClass());
            Assert.AreEqual(expectedClassName, Advanced.GetClass());

            // Get the expected stat values for the noob dimachaerus and test if they're the same as the actual values
            // These values are calculated in the Dimachaerus class
            string expectedName = "Billy";
            int expectedLevel = 1;
            int expectedHealth = 80;
            int expectedStamina = 100;
            int expectedPower = 125;
            int expectedDefense = 80;
            Assert.AreEqual(expectedName, Noob.GetName());
            Assert.AreEqual(expectedLevel, Noob.GetLevel());
            Assert.AreEqual(expectedHealth, Noob.GetHealth());
            Assert.AreEqual(expectedStamina, Noob.GetStamina());
            Assert.AreEqual(expectedPower, Noob.GetPower());
            Assert.AreEqual(expectedDefense, Noob.GetDefense());

            // Do the same with the intermediate dimachaerus
            expectedName = "Joe";
            expectedLevel = 10;
            expectedHealth = 215;
            expectedStamina = 325;
            expectedPower = 575;
            expectedDefense = 215;
            Assert.AreEqual(expectedName, Intermediate.GetName());
            Assert.AreEqual(expectedLevel, Intermediate.GetLevel());
            Assert.AreEqual(expectedHealth, Intermediate.GetHealth());
            Assert.AreEqual(expectedStamina, Intermediate.GetStamina());
            Assert.AreEqual(expectedPower, Intermediate.GetPower());
            Assert.AreEqual(expectedDefense, Intermediate.GetDefense());

            // Do the same with the advanced dimachaerus
            expectedName = "Oziach";
            expectedLevel = 100;
            expectedHealth = 1565;
            expectedStamina = 2575;
            expectedPower = 5075;
            expectedDefense = 1565;

            Assert.AreEqual(expectedName, Advanced.GetName());
            Assert.AreEqual(expectedLevel, Advanced.GetLevel());
            Assert.AreEqual(expectedHealth, Advanced.GetHealth());
            Assert.AreEqual(expectedStamina, Advanced.GetStamina());
            Assert.AreEqual(expectedPower, Advanced.GetPower());
            Assert.AreEqual(expectedDefense, Advanced.GetDefense());

            // Test the level up function
            Advanced.LevelUp();
            expectedLevel = 101;
            expectedHealth = 1580;
            expectedStamina = 2600;
            expectedPower = 5125;
            expectedDefense = 1580;
            Assert.AreEqual(expectedLevel, Advanced.GetLevel());
            Assert.AreEqual(expectedHealth, Advanced.GetHealth());
            Assert.AreEqual(expectedStamina, Advanced.GetStamina());
            Assert.AreEqual(expectedPower, Advanced.GetPower());
            Assert.AreEqual(expectedDefense, Advanced.GetDefense());
        }
    }
}
