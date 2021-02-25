using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{
    private bool isMuted = false;

    void Start()
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

    private void saveMuteState()
    {
        PlayerPrefs.SetInt("muted", isMuted ? 1 : 0);
    }

    private void loadMuteState()
    {
        isMuted = PlayerPrefs.GetInt("muted") == 1;
        updateText();
    }

    private void updateText()
    {
        Text muteStatus = GameObject.Find("Canvas/Mute/Text").GetComponent<Text>();
        if (isMuted)
            muteStatus.text = "Unmute";
        else
            muteStatus.text = "Mute";
    }
}
