using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    public TextMeshProUGUI timeUI;
    public TextMeshProUGUI dayUI;
    public float tickRate;
    public float seconds;
    public int mins;
    public int hours;
    public int days = 1;

    public bool activate;

    private void Awake()
    {
        seconds = PlayerPrefs.GetFloat("Seconds");
        mins = PlayerPrefs.GetInt("Mins");
        hours = PlayerPrefs.GetInt("Hours");
        days = PlayerPrefs.GetInt("Days");
    }
    void Start()
    {
        tickRate = 500;
        activate = true;
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
        if (seconds >= 60) // 60 seconds = 1 min so it adds 1 to minutes
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
        PlayerPrefs.SetFloat("Seconds", seconds);
        PlayerPrefs.SetInt("Mins", mins);
        PlayerPrefs.SetInt("Hours", hours);
        PlayerPrefs.SetInt("Days", days);
    }
}
