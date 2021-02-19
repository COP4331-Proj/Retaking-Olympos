using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    static float currentVolume;

    public void Awake()
    {
        LoadSettings();
    }

    public void OnDestroy()
    {
        SaveSettings();
    }

    public void setVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        currentVolume = volume;
    }

    public void LoadSettings()
    {
        if (PlayerPrefs.HasKey("VolumePreference"))
        {
            volumeSlider.value = PlayerPrefs.GetFloat("VolumePreference");
        }
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("VolumePreference", currentVolume);
    }
}
