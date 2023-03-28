using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateMng : MonoBehaviour
{
    public HealthSc healthBar;
    public ThirstSc ThirstBar;
    public HungerSc HungerBar;

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

public void ChangeSceneByName(string name)
    {
        TakeDamage takedamage = new TakeDamage();
        if (name != null) {
            SceneManager.LoadScene(name);
            PlayerPrefs.SetFloat("save", 100);
            PlayerPrefs.SetFloat("save1", 100);
            PlayerPrefs.SetFloat("save2", 100);


       

        }
    }
}

