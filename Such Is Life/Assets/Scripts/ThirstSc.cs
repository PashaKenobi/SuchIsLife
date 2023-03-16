using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirstSc : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;


    // Start is called before the first frame update
    public void SetMaxThirst(int thirst)
    {
        slider.maxValue = thirst;
        slider.value = thirst;


    }
    public void SetThirst(int thirst)
    {

        slider.value = thirst;
    }
}
