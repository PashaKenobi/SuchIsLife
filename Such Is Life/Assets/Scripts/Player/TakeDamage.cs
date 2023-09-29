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
    public ShopManager shopmanager;
    // Start is called before the first frame update
    void Start()
    {
        PlayerData playerData = SaveSystem.LoadPlayer();

        currentThirst = playerData.energy;
        currentHunger = playerData.hunger;
        currentHealth = playerData.health;

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
        if (currentHealth >= 100)
        {
            currentHealth = 100;
        }
        if (currentHunger >= 100)
        {
            currentHunger = 100;
        }
        if (currentHunger == 0 && currentThirst == 0 && currentHealth != 0)
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
        PlayerPrefs.SetInt("save", currentHealth);
        PlayerPrefs.SetInt("save1", currentHunger);
        PlayerPrefs.SetInt("save2", currentThirst);



    }

    public void addHealth(int heal)
    {
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
        PlayerPrefs.SetInt("save", currentHealth);
    }

    public void addHunger(int nut)
    {
        currentHunger += nut;
        HungerBar.SetHunger(currentHunger);
        PlayerPrefs.SetInt("save1", currentHunger);
    }

    public void addEnergy(int eng)
    {
        currentThirst += eng;
        ThirstBar.SetThirst(currentThirst);
        PlayerPrefs.SetInt("save2", currentThirst);
    }

    public void setFullHealth(){
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
        PlayerPrefs.SetInt("save", currentHealth);
    }

    public void setFullHunger(){
        currentHunger = maxHunger;
        HungerBar.SetHunger(currentHunger);
        PlayerPrefs.SetInt("save1", currentHunger);
    }

    public void setFullEnergy(){
        currentThirst = maxThirst;
        ThirstBar.SetThirst(currentThirst);
        PlayerPrefs.SetInt("save2", currentThirst);
    }

    public void FullHealthWithMoney(int price)
    {
        if (shopmanager.enoughMoneyCheck(price))
        {
            setFullHealth();
        }
    }
    public void FullHungerWithMoney(int price)
    {
        if (shopmanager.enoughMoneyCheck(price))
        {
            setFullHunger();
        }
    }
    public void FullEnergyWithMoney(int price)
    {
        if (shopmanager.enoughMoneyCheck(price))
        {
            setFullEnergy();
        }
    }


    public void AddHealthWithMoney(int price, int amount)
    {
        if (shopmanager.enoughMoneyCheck(price))
        {
            addHealth(amount);
        }
    }
    public void AddHungerWithMoney(int price, int amount)
    {
        if (shopmanager.enoughMoneyCheck(price))
        {
            addHunger(amount);
        }
    }

    public void AddEnergyWithMoney(int price, int amount)
    {
        if (shopmanager.enoughMoneyCheck(price))
        {
            addEnergy(amount);

        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > 30)
        {
            Damage(5);
            timer = 0;
        }
    }
}
