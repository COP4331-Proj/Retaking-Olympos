﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    static float currentVolume;
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;

    public void Awake()
    {
        LoadResolutions();
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

    public void LoadResolutions()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
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
