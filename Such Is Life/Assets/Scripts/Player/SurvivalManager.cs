using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SurvivalManager : MonoBehaviour
{
    [Header("Health")]
    public float _maxHealth = 10f;
    public float _healthDepletionRate = 1f;
    public float _currentHealth;
    public float HealthPercent => _currentHealth / _maxHealth;
  
    [Header("Hunger")]
    public float _maxHunger = 10f;
    public float _hungerDepletionRate = 1f;
    public float _currentHunger;
    public float HungerPercent => _currentHunger / _maxHunger;

    [Header("Thirst")]
    public float _maxThirst = 10f;
    public float _thirstDepletionRate = 1f;
    public float _currentThirst;
    public float ThirstPercent => _currentHunger / _maxHunger;
    // [Header("Player References")]
    //[SerializeField] private StarterAssetsInputs _playerInput;

    public static UnityAction OnPlayerDied;
    
    void Start()
    {
        _currentHunger = _maxHunger;
        _currentThirst = _maxThirst;
        _currentHealth = _maxHealth;
                                    
    }
    public void takeDamage(float amount) {
        _currentHealth -= amount;

        if (_currentHealth == 0) {

            OnPlayerDied?.Invoke();
            _currentHunger = 0;
            _currentThirst = 0;

        }

        /* OnPlayerDied?.Invoke();
         _currentHealth = 0;
         _currentHunger = 0;
     }    */
    }
    void Update()
    {
        _currentHunger -= _hungerDepletionRate * Time.deltaTime;
        _currentThirst -= _thirstDepletionRate * Time.deltaTime;

        if (_currentHunger <= 0) {
            takeDamage(1);
            
        }
    }
}
