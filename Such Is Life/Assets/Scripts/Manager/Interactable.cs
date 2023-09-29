using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public bool inRange;
    public KeyCode interactKey;
    public UnityEvent interactAction1;
    public UnityEvent interactAction2;
    public UnityEvent interactAction3;
    public UnityEvent interactAction4;
    public UnityEvent interactAction5;
    public UnityEvent interactAction6;
    public int keyCount = 0;
    public bool limitedInteraction = false;
    private List<UnityEvent> actions = new List<UnityEvent>();
    
    // Start is called before the first frame update
    private void Awake()
    {
        actions.Add(interactAction1);
        actions.Add(interactAction2);
        actions.Add(interactAction3);
        actions.Add(interactAction4);
        actions.Add(interactAction5);
        actions.Add(interactAction6);
        Load();
    }

    // Update is called once per frame
    void Update()
    {

        if (inRange)
        {
            if (!limitedInteraction && Input.GetKeyDown(interactKey))
            {
                interactAction1.Invoke();
            }
            if (limitedInteraction && keyCount <= 5 && Input.GetKeyDown(interactKey)){
                actions[keyCount].Invoke();
                keyCount++;
                Save();
            }
            if(limitedInteraction && keyCount > 5 && Input.GetKeyDown(interactKey)){
                DummyEvent();
            }
        }
        
    }

    public void Save()
    {
        if (SceneManager.GetActiveScene().name == "Map 3")
        {
            PlayerPrefs.SetInt("Key1", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "Map 2")
        {
            PlayerPrefs.SetInt("Key2", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "Map 1")
        {
            PlayerPrefs.SetInt("Key3", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "PCHouse")
        {
            PlayerPrefs.SetInt("Key4", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "Warehouse")
        {
            PlayerPrefs.SetInt("Key5", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "CaravanPark")
        {
            PlayerPrefs.SetInt("Key6", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "Bank")
        {
            PlayerPrefs.SetInt("Key7", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "Hospital")
        {
            PlayerPrefs.SetInt("Key8", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "Shop")
        {
            PlayerPrefs.SetInt("Key9", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "WUpRight")
        {
            PlayerPrefs.SetInt("Key10", keyCount);
        }
        else if (SceneManager.GetActiveScene().name == "Caravan")
        {
            PlayerPrefs.SetInt("Key11", keyCount);
        }
    }
    public void Load()
    {
        if (SceneManager.GetActiveScene().name == "Map 3")
        {
            if (PlayerPrefs.GetInt("Key1").Equals(null))
            {
                keyCount = 0;
            }
            else
           keyCount = PlayerPrefs.GetInt("Key1");
        }
        else if (SceneManager.GetActiveScene().name == "Map 2")
        {
            if (PlayerPrefs.GetInt("Key2").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key2");
        }
        else if (SceneManager.GetActiveScene().name == "Map 1")
        {
            if (PlayerPrefs.GetInt("Key3").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key3");
        }
        else if (SceneManager.GetActiveScene().name == "PCHouse")
        {
            if (PlayerPrefs.GetInt("Key4").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key4");
        }
        else if (SceneManager.GetActiveScene().name == "Warehouse")
        {
            if (PlayerPrefs.GetInt("Key5").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key5");
        }
        else if (SceneManager.GetActiveScene().name == "CaravanPark")
        {
            if (PlayerPrefs.GetInt("Key6").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key6");
        }
        else if (SceneManager.GetActiveScene().name == "Bank")
        {
            if (PlayerPrefs.GetInt("Key7").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key7"); ;
        }
        else if (SceneManager.GetActiveScene().name == "Hospital")
        {
            if (PlayerPrefs.GetInt("Key8").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key8");
        }
        else if (SceneManager.GetActiveScene().name == "Shop")
        {
            if (PlayerPrefs.GetInt("Key9").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key9");
        }
        else if (SceneManager.GetActiveScene().name == "WUpRight")
        {
            if (PlayerPrefs.GetInt("Key10").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key10");
        }
        else if (SceneManager.GetActiveScene().name == "Caravan")
        {
            if (PlayerPrefs.GetInt("Key11").Equals(null))
            {
                keyCount = 0;
            }
            else
                keyCount = PlayerPrefs.GetInt("Key11");
        }
    }
    public void DummyEvent(){
        Debug.Log("dummy event");
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            inRange = true;
            Debug.Log("in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            inRange = false;
            Debug.Log("not in range");
        }
    }
}
