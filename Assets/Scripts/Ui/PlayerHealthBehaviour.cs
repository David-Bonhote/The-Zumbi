using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBehaviour
{
    
    public void SetMaxHealth(Slider slider, int health)
    {
        slider.maxValue = health;
    }

    public void SetHealth(Slider slider, int health)
    {
        slider.value = health;
    }
}
