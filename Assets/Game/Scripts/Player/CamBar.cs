using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CamBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public TextMeshProUGUI healthText;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int Health)
    {
        slider.value = Health;
        healthText.text = Health.ToString();
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
