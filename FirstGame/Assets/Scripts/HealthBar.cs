using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Slider slider;
    
    public void SetHealth (float life)
    {
        slider.value = life;
    }

    public void SetMaxHealth (float life)
    {
        slider.maxValue = life;
        slider.value = life;
    }
}
