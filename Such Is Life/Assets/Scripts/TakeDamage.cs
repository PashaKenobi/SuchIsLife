using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    float timer;
    public HungerHealthSc healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }

    // Update is called once per frame
    void Damage(int damage)
    {

        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
    }
    void Update()
    {
        timer += Time.deltaTime;
        print(timer);
        if(timer > 10)
        {
            Damage(10);
            timer = 0;
        }
    }

    
}
