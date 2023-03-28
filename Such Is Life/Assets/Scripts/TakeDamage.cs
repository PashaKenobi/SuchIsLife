using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int maxHunger = 100;
    public int maxThirst = 100;
    public int currentHealth;
    public int currentThirst;
    public int currentHunger;
   
    float timer;
    public HealthSc healthBar;
    public ThirstSc ThirstBar;
    public HungerSc HungerBar;

    
    // Start is called before the first frame update
    void Start()
    {
        currentHunger = maxHunger;
        currentThirst = maxThirst;
        currentHealth = maxHealth;

        currentThirst = (int)PlayerPrefs.GetFloat("save", currentThirst);
        currentHunger = (int)PlayerPrefs.GetFloat("save1", currentHunger);
        currentHealth = (int)PlayerPrefs.GetFloat("save2", currentHealth);

        healthBar.SetHealth(currentHealth);
        HungerBar.SetHunger(currentHunger);
        ThirstBar.SetThirst(currentThirst);
    }
   

    public void PlayerDied()
    {
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
    void Damage(int damage)
    {
        currentHunger -= damage;
        currentThirst -= damage;

        if (currentThirst < 0)
        {
            currentThirst = 0;
        }
        if( currentHunger < 0)
        {
            currentHunger = 0;
        }
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        if (currentHunger == 0 && currentThirst == 0)
        {
            currentHealth -= damage;
        }
        if (currentHunger >0 || currentThirst >0)
        {
            currentHealth += 20;
        }
        if (currentHealth == 0)
        {
            PlayerDied();
        }

        healthBar.SetHealth(currentHealth);
        HungerBar.SetHunger(currentHunger);
        ThirstBar.SetThirst(currentThirst);
     




    }
    public void addHunger(int nut)
    {
        currentHunger += nut;
        HungerBar.SetHunger(currentHunger);
        PlayerPrefs.SetFloat("save1", currentHunger);
    }
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > 10)
        {
            Damage(50);
            timer = 0;
      
            PlayerPrefs.SetFloat("save", currentThirst);
            PlayerPrefs.SetFloat("save1", currentHunger);
            PlayerPrefs.SetFloat("save2", currentHealth);

        }



    }

  



}
