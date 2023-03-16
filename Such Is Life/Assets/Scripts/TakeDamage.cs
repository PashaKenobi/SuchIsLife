using System.Collections;
using System.Collections.Generic;
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
        healthBar.SetHealth(maxHealth);
        HungerBar.SetHunger(maxHunger);
        ThirstBar.SetThirst(maxThirst);
     
    }

    // Update is called once per frame
    void Damage(int damage)
    {

        
        currentHunger -= damage;
        currentThirst -= damage;

        healthBar.SetHealth(currentHealth);
        HungerBar.SetHunger(currentHunger);
        ThirstBar.SetThirst(currentThirst);
        if(currentHunger == 0 || currentThirst == 0)
        {
            currentHealth -= damage;
        }    

    }
    void Update()
    {
        timer += Time.deltaTime;
        print(timer);
    
        if(timer > 10)
        {
            Damage(10);
            timer = 0;
            SaveHealth();
            SaveThirst();
            SaveHunger();
        }
    }

    void SaveHealth()
    {
        PlayerPrefs.SetInt("healthP", currentHealth);
    }
    void SaveThirst()
    {
        PlayerPrefs.SetInt("thirsthP", currentThirst);
    }
    void SaveHunger()
    {
        PlayerPrefs.SetInt("hungerhP", currentHunger);
    }

}
