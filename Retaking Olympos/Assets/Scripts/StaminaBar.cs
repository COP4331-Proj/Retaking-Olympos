using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;

    public void setMaxStamina(int stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
        UpdateLabel();
    }

    public void setStamina(int stamina)
    {
        slider.value = stamina;
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        if (GameObject.Find("Canvas/Stamina Number") != null) 
        {
            Text staminaNum = GameObject.Find("Canvas/Stamina Number").GetComponent<Text>();
            staminaNum.text = slider.value + " / " + slider.maxValue;;
        }
    }
}
