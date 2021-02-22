using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.TestTools;

namespace Tests
{
    public class ActiveSettingsTests
    {
        [Test]
        public void TestVolumeSetting()
        {
            if (PlayerPrefs.HasKey("VolumePreference"))
            {
                float volume;
                AudioMixer mixer = Resources.Load("MainMixer") as AudioMixer;
                mixer.SetFloat("Volume", PlayerPrefs.GetFloat("VolumePreference"));
                mixer.GetFloat("Volume", out volume);
                Assert.AreEqual(PlayerPrefs.GetFloat("VolumePreference"), volume);
            }
        }

        [Test]
        public void TestFullscreenSetting()
        {
            if (PlayerPrefs.HasKey("FullscreenPreference"))
            {
                Assert.AreEqual(Convert.ToBoolean(PlayerPrefs.GetInt("FullscreenPreference")), Screen.fullScreen);
            }
        }
    }
}
