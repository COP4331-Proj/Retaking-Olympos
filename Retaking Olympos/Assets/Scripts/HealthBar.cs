using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        UpdateLabel();
    }

    public void setHealth(int health)
    {
        slider.value = health;
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        if (GameObject.Find("Canvas/HP Number") != null) 
        {
            Text hpNum = GameObject.Find("Canvas/HP Number").GetComponent<Text>();
            //Debug.Log(slider.value + " / " + slider.maxValue);
            hpNum.text = slider.value + " / " + slider.maxValue;
        }
    }
}
