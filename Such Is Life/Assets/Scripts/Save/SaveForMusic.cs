using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveForMusic : MonoBehaviour
{
    public float x, y, z;
    public Vector3 LoadPosition;
    bool first = true;
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
        if (gameObject.name.Equals("Piano"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("Music_x", x);
            PlayerPrefs.SetFloat("Music_y", y);
            PlayerPrefs.SetFloat("Music_z", z);
        }
        else if (gameObject.name.Equals("Electro guitar"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("Music_x1", x);
            PlayerPrefs.SetFloat("Music_y1", y);
            PlayerPrefs.SetFloat("Music_z1", z);
        }
        else if (gameObject.name.Equals("Speaker1"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("Music_x2", x);
            PlayerPrefs.SetFloat("Music_y2", y);
            PlayerPrefs.SetFloat("Music_z2", z);
        }
        else if (gameObject.name.Equals("Speaker2"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("Music_x3", x);
            PlayerPrefs.SetFloat("Music_y3", y);
            PlayerPrefs.SetFloat("Music_z3", z);
        }
        else if (gameObject.name.Equals("Mic"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("Music_x4", x);
            PlayerPrefs.SetFloat("Music_y4", y);
            PlayerPrefs.SetFloat("Music_z4", z);
        }
        else if (gameObject.name.Equals("Batery"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("Music_x5", x);
            PlayerPrefs.SetFloat("Music_y5", y);
            PlayerPrefs.SetFloat("Music_z5", z);
        }

    }

    public void Load()
    {
        first = PlayerPrefs.GetInt("foo3") == 1 ? true : false;
        if (first == true )
        {
            if (gameObject.name.Equals("Piano"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Electro guitar"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Speaker1"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Speaker2"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Mic"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Batery"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            first = false;
            PlayerPrefs.SetInt("foo3", first ? 1 : 0);
        }
        else
        {
            if (gameObject.name.Equals("Piano"))
            {
                x = PlayerPrefs.GetFloat("Music_x");
                y = PlayerPrefs.GetFloat("Music_y");
                z = PlayerPrefs.GetFloat("Music_z");
            }
            else if (gameObject.name.Equals("Electro guitar"))
            {
                x = PlayerPrefs.GetFloat("Music_x1");
                y = PlayerPrefs.GetFloat("Music_y1");
                z = PlayerPrefs.GetFloat("Music_z1");
            }
            else if (gameObject.name.Equals("Speaker1"))
            {
                x = PlayerPrefs.GetFloat("Music_x2");
                y = PlayerPrefs.GetFloat("Music_y2");
                z = PlayerPrefs.GetFloat("Music_z2");
            }
            else if (gameObject.name.Equals("Speaker2"))
            {
                x = PlayerPrefs.GetFloat("Music_x3");
                y = PlayerPrefs.GetFloat("Music_y3");
                z = PlayerPrefs.GetFloat("Music_z3");
            }
            else if (gameObject.name.Equals("Mic"))
            {
                x = PlayerPrefs.GetFloat("Music_x4");
                y = PlayerPrefs.GetFloat("Music_y4");
                z = PlayerPrefs.GetFloat("Music_z4");
            }
            else if (gameObject.name.Equals("Batery"))
            {
                x = PlayerPrefs.GetFloat("Music_x5");
                y = PlayerPrefs.GetFloat("Music_y5");
                z = PlayerPrefs.GetFloat("Music_z5");
            }
        }
        LoadPosition = new Vector3(x, y, z);
        this.transform.position = LoadPosition;

    }
}
