using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public Toggle toggle;
    public Dropdown resolutionDropdown;
    public Dropdown difficultyDropdown;
    static float currentVolume;
    static String previousClass;
    Resolution[] resolutions;

    public void Start()
    {
        LoadResolutions();
        LoadSettings();

        GameObject gameObject = new GameObject();
        gameObject.AddComponent<MuteManager>();
        gameObject.GetComponent<MuteManager>().Load();
    }

    public void Save()
    {
        SaveSettings();
    }

    public void ShowSettingsMenu(string callingClass)
    {
        previousClass = callingClass;

        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene("Options Menu");
    }

    public void ReturnToPreviousClass()
    {
        Save();

        GameObject gameObject = new GameObject();
        gameObject.AddComponent<SceneLoader>();
        gameObject.GetComponent<SceneLoader>().GoToScene(previousClass);
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        currentVolume = volume;
    }

    public void SetResolution(int resolutionIndex)
    {
	    Resolution resolution = resolutions[resolutionIndex];
	    Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void LoadResolutions()
    {
        resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();

        resolutionDropdown?.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown?.AddOptions(options);
        resolutionDropdown?.SetValueWithoutNotify(currentResolutionIndex);
        resolutionDropdown?.RefreshShownValue();
        }

    public void LoadSettings()
    {
        if (PlayerPrefs.HasKey("VolumePreference"))
        {
            volumeSlider?.SetValueWithoutNotify(PlayerPrefs.GetFloat("VolumePreference"));
        }
        if (PlayerPrefs.HasKey("ResolutionPreference"))
        {
            resolutionDropdown?.SetValueWithoutNotify(PlayerPrefs.GetInt("ResolutionPreference"));
        }
        if (PlayerPrefs.HasKey("FullscreenPreference"))
        {
            toggle?.SetIsOnWithoutNotify(Convert.ToBoolean(PlayerPrefs.GetInt("FullscreenPreference")));
        }

        if (PlayerPrefs.HasKey("DifficultyPreference"))
        {
            switch (PlayerPrefs.GetFloat("DifficultyPreference"))
            {
                case 0.5f: // Easy
                    difficultyDropdown?.SetValueWithoutNotify(0);
                    break;
                case 1.0f: // Normal
                    difficultyDropdown?.SetValueWithoutNotify(1);
                    break;
                case 1.5f: // Hard
                    difficultyDropdown?.SetValueWithoutNotify(2);
                    break;
            }
        }
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("VolumePreference", currentVolume);
        PlayerPrefs.SetInt("FullscreenPreference", Convert.ToInt32(Screen.fullScreen));
        PlayerPrefs.SetInt("ResolutionPreference", resolutionDropdown.value);

        switch (difficultyDropdown.value)
        {
            case 0: // Easy
                PlayerPrefs.SetFloat("DifficultyPreference", 0.5f);
                break;
            case 1: // Normal
                PlayerPrefs.SetFloat("DifficultyPreference", 1.0f);
                break;
            case 2: // Hard
                PlayerPrefs.SetFloat("DifficultyPreference", 1.5f);
                break;
        }
    }
}
