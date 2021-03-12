using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBar : MonoBehaviour
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
        if (GameObject.Find("Canvas/Enemy HP Number") != null) 
        {
            Text enemyHPNum = GameObject.Find("Canvas/Enemy HP Number").GetComponent<Text>();
            enemyHPNum.text = slider.value + " / " + slider.maxValue;
        }
    }
}
