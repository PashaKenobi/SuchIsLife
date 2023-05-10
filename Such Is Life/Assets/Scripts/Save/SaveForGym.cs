using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveForGym : MonoBehaviour
{
    public float x, y, z;
    public Vector3 LoadPosition;
    int first = 1;
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
        if (gameObject.name.Equals("gym1"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("gym_x", x);
            PlayerPrefs.SetFloat("gym_y", y);
            PlayerPrefs.SetFloat("gym_z", z);
        }
        else if (gameObject.name.Equals("gym2"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("gym_x1", x);
            PlayerPrefs.SetFloat("gym_y1", y);
            PlayerPrefs.SetFloat("gym_z1", z);
        }
        else if (gameObject.name.Equals("gym3"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("gym_x2", x);
            PlayerPrefs.SetFloat("gym_y2", y);
            PlayerPrefs.SetFloat("gym_z2", z);
        }
        else if (gameObject.name.Equals("gym4"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("gym_x3", x);
            PlayerPrefs.SetFloat("gym_y3", y);
            PlayerPrefs.SetFloat("gym_z3", z);
        }
        else if (gameObject.name.Equals("gym5"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("gym_x4", x);
            PlayerPrefs.SetFloat("gym_y4", y);
            PlayerPrefs.SetFloat("gym_z4", z);
        }
        else if (gameObject.name.Equals("gym6"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("gym_x5", x);
            PlayerPrefs.SetFloat("gym_y5", y);
            PlayerPrefs.SetFloat("gym_z5", z);
        }
    }

    public void Load()
    {
        first = PlayerPrefs.GetInt("foo2");
        if (first == 1 || PlayerPrefs.GetInt("foo2").Equals(null))
        {
            if (gameObject.name.Equals("gym1"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("gym2"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("gym3"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("gym4"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("gym5"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("gym6"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            first = 0;
            PlayerPrefs.SetInt("foo", first);
        }
        else
        {
            if (gameObject.name.Equals("gym1"))
            {
                x = PlayerPrefs.GetFloat("gym_x");
                y = PlayerPrefs.GetFloat("gym_y");
                z = PlayerPrefs.GetFloat("gym_z");
            }
            else if (gameObject.name.Equals("gym2"))
            {
                x = PlayerPrefs.GetFloat("gym_x1");
                y = PlayerPrefs.GetFloat("gym_y1");
                z = PlayerPrefs.GetFloat("gym_z1");
            }
            else if (gameObject.name.Equals("gym3"))
            {
                x = PlayerPrefs.GetFloat("gym_x2");
                y = PlayerPrefs.GetFloat("gym_y2");
                z = PlayerPrefs.GetFloat("gym_z2");
            }
            else if (gameObject.name.Equals("gym4"))
            {
                x = PlayerPrefs.GetFloat("gym_x3");
                y = PlayerPrefs.GetFloat("gym_y3");
                z = PlayerPrefs.GetFloat("gym_z3");
            }
            else if (gameObject.name.Equals("gym5"))
            {
                x = PlayerPrefs.GetFloat("gym_x4");
                y = PlayerPrefs.GetFloat("gym_y4");
                z = PlayerPrefs.GetFloat("gym_z4");
            }
            else if (gameObject.name.Equals("gym6"))
            {
                x = PlayerPrefs.GetFloat("gym_x5");
                y = PlayerPrefs.GetFloat("gym_y5");
                z = PlayerPrefs.GetFloat("gym_z5");
            }
        }
        LoadPosition = new Vector3(x, y, z);
        this.transform.position = LoadPosition;
    }
}
