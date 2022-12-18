using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class LightControl : MonoBehaviour
{
    public TextMeshProUGUI timeUI;
    public TextMeshProUGUI dayUI;
    public Volume volume;
    public float volumeRate;
    public float tickRate;
    public float seconds;
    public int mins;
    public int hours;
    public int days = 1;

    public bool activate;
    public GameObject[] lights;

    private void Awake()
    {
        seconds = PlayerPrefs.GetFloat("Seconds");
        mins = PlayerPrefs.GetInt("Mins");
        hours = PlayerPrefs.GetInt("Hours");
        days = PlayerPrefs.GetInt("Days");
        volume.weight = PlayerPrefs.GetFloat("volumeRate");
    }
    void Start()
    {
        tickRate = 1000;
        volume = gameObject.GetComponent<Volume>();
    }
    private void FixedUpdate()
    {
        calcTime();
        displayTime();
    }

    public void displayTime()// shows day and time in UI
    {
        timeUI.text = string.Format("{0:00}:{1:00}", hours, mins);
        dayUI.text = "Day: " + days;
    }

    public void calcTime()
    {
        seconds += Time.fixedDeltaTime * tickRate;
        if(seconds >= 60) // 60 seconds = 1 min so it adds 1 to minutes
        {
            seconds = 0;
            mins += 1;
        }
        if (mins >= 60) // 60 mins = 1 hour so it adds 1 to hours 
        {
            mins = 0;
            hours += 1;
        }
        if (hours >= 24) // 24 hours = 1 day so it adds 1 to day value
        {
            hours = 0;
            days += 1;
        }
        PlayerPrefs.SetFloat("Seconds",seconds);
        PlayerPrefs.SetInt("Mins", mins);
        PlayerPrefs.SetInt("Hours", hours);
        PlayerPrefs.SetInt("Days",days);
        controlVolume();
        PlayerPrefs.SetFloat("volumeRate", volumeRate);
    }

    public void controlVolume()
    {
       if(hours >= 21 && hours <22) // dusk time 21:00 to 22:00 (changeable)
        {
            volume.weight = (float)mins / 60;
            volumeRate = volume.weight;
            if(activate == false)
            {
                if(mins > 45) //waits until dark
                {
                    for(int i = 0; i < lights.Length; i++)
                    {
                        lights[i].SetActive(true);//turn the lights on
                    }
                    activate = true;
                }
            }
        }
        if (volume.weight < 0.5 && !activate)
        {
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].SetActive(false);//turn the lights off
            }
        }

        if (hours >=6 && hours < 7) // dawn to 6:00 to 7:00 (changeable)
        {
            volume.weight = 1 - (float)mins / 60;
            volumeRate = volume.weight;
            if (mins > 45) //waits until bright
            {
               for (int i = 0; i < lights.Length; i++)
               {
                  lights[i].SetActive(false);//turn the lights off
               }
               activate = false;
            }
        }
    }
}
