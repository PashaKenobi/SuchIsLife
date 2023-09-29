using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSc : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;


    // Start is called before the first frame update
    public void SetMaxHunger(int hunger)
    {
        slider.maxValue = hunger;
        slider.value = hunger;


    }
    public void SetHunger(int hunger)
    {

        slider.value = hunger;
    }
}
