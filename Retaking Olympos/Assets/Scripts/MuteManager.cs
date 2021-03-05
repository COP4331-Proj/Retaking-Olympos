using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{
    private static bool isMuted = false;

    public void Load()
    {
        if (!PlayerPrefs.HasKey("muted"))
            PlayerPrefs.SetInt("muted", 0);
        else
            loadMuteState();
    }

    public void mutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        saveMuteState();
        updateText();
    }

    // This function is here for testing purposes
    public static bool getMuteState()
    {
        return isMuted;
    }

    private static void saveMuteState()
    {
        PlayerPrefs.SetInt("muted", isMuted ? 1 : 0);
    }

    private static void loadMuteState()
    {
        isMuted = PlayerPrefs.GetInt("muted") == 1;
        updateText();
    }

    private static void updateText()
    {
        Text muteStatus = GameObject.Find("Canvas/Mute/Text").GetComponent<Text>();
        if (isMuted)
            muteStatus.text = "Unmute";
        else
            muteStatus.text = "Mute";
    }
}
