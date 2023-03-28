using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public float x, y, z;
    public Vector3 LoadPosition;
    private void Start()
    {
        Load();   
    }
    private void Update()
    {
        Save();
    }
    public void Save()
    {
        if (SceneManager.GetActiveScene().name == "Map 3")
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x", x);
            PlayerPrefs.SetFloat("y", y);
            PlayerPrefs.SetFloat("z", z);
        }
        else if (SceneManager.GetActiveScene().name == "Map 2")
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x1", x);
            PlayerPrefs.SetFloat("y1", y);
            PlayerPrefs.SetFloat("z1", z);
        }
        else if (SceneManager.GetActiveScene().name == "Map 1")
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x2", x);
            PlayerPrefs.SetFloat("y2", y);
            PlayerPrefs.SetFloat("z2", z);
        }
        else if (SceneManager.GetActiveScene().name == "PCHouse")
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x3", x);
            PlayerPrefs.SetFloat("y3", y);
            PlayerPrefs.SetFloat("z3", z);
        }
        else if (SceneManager.GetActiveScene().name == "Warehouse")
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x4", x);
            PlayerPrefs.SetFloat("y4", y);
            PlayerPrefs.SetFloat("z4", z);
        }
        else if (SceneManager.GetActiveScene().name == "CaravanPark")
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x5", x);
            PlayerPrefs.SetFloat("y5", y);
            PlayerPrefs.SetFloat("z5", z);
        }


    }
    public void Load()
    {
        if (SceneManager.GetActiveScene().name == "Map 3")
        {
            x = PlayerPrefs.GetFloat("x");
            y = PlayerPrefs.GetFloat("y");
            z = PlayerPrefs.GetFloat("z");
        }
        else if(SceneManager.GetActiveScene().name == "Map 2")
        {
            x = PlayerPrefs.GetFloat("x1");
            y = PlayerPrefs.GetFloat("y1");
            z = PlayerPrefs.GetFloat("z1");
        }
        else if (SceneManager.GetActiveScene().name == "Map 1")
        {
            x = PlayerPrefs.GetFloat("x2");
            y = PlayerPrefs.GetFloat("y2");
            z = PlayerPrefs.GetFloat("z2");
        }
        else if (SceneManager.GetActiveScene().name == "PCHouse")
        {
            x = PlayerPrefs.GetFloat("x3");
            y = PlayerPrefs.GetFloat("y3");
            z = PlayerPrefs.GetFloat("z3");
        }
        else if (SceneManager.GetActiveScene().name == "Warehouse")
        {
            x = PlayerPrefs.GetFloat("x4");
            y = PlayerPrefs.GetFloat("y4");
            z = PlayerPrefs.GetFloat("z4");
        }
        else if (SceneManager.GetActiveScene().name == "CaravanPark")
        {
            x = PlayerPrefs.GetFloat("x5");
            y = PlayerPrefs.GetFloat("y5");
            z = PlayerPrefs.GetFloat("z5");
        }
        LoadPosition = new Vector3(x, y, z);
        this.transform.position = LoadPosition;
    }
}