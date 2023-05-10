using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnForBathroom : MonoBehaviour
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
        if (gameObject.name.Equals("Mirror"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x", x);
            PlayerPrefs.SetFloat("bathroom_y", y);
            PlayerPrefs.SetFloat("bathroom_z", z);
        }
        else if (gameObject.name.Equals("Washer machine"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x1", x);
            PlayerPrefs.SetFloat("bathroom_y1", y);
            PlayerPrefs.SetFloat("bathroom_z1", z);
        }
        else if (gameObject.name.Equals("Wardrobe"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x2", x);
            PlayerPrefs.SetFloat("bathroom_y2", y);
            PlayerPrefs.SetFloat("bathroom_z2", z);
        }
        else if (gameObject.name.Equals("Bathtub"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x3", x);
            PlayerPrefs.SetFloat("bathroom_y3", y);
            PlayerPrefs.SetFloat("bathroom_z3", z);
        }
        else if (gameObject.name.Equals("Coat rack"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x4", x);
            PlayerPrefs.SetFloat("bathroom_y4", y);
            PlayerPrefs.SetFloat("bathroom_z4", z);
        }
        else if (gameObject.name.Equals("Box"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x5", x);
            PlayerPrefs.SetFloat("bathroom_y5", y);
            PlayerPrefs.SetFloat("bathroom_z5", z);
        }
        else if (gameObject.name.Equals("Box2"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x6", x);
            PlayerPrefs.SetFloat("bathroom_y6", y);
            PlayerPrefs.SetFloat("bathroom_z6", z);
        }
        else if (gameObject.name.Equals("Closet"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("bathroom_x7", x);
            PlayerPrefs.SetFloat("bathroom_y7", y);
            PlayerPrefs.SetFloat("bathroom_z7", z);
        }
    }

    public void Load()
    {
        first = PlayerPrefs.GetInt("foo1");
        if (first == 1 || PlayerPrefs.GetInt("foo1").Equals(null))
        {
            if (gameObject.name.Equals("Mirror"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Washer machine"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Wardrobe"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Bathtub"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Coat rack"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Box"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Box2"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Closet"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            first = 0;
            PlayerPrefs.SetInt("foo1", first);
        }
        else
        {
            if (gameObject.name.Equals("Mirror"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x");
                y = PlayerPrefs.GetFloat("bathroom_y");
                z = PlayerPrefs.GetFloat("bathroom_z");
            }
            else if (gameObject.name.Equals("Washer machine"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x1");
                y = PlayerPrefs.GetFloat("bathroom_y1");
                z = PlayerPrefs.GetFloat("bathroom_z1");
            }
            else if (gameObject.name.Equals("Wardrobe"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x2");
                y = PlayerPrefs.GetFloat("bathroom_y2");
                z = PlayerPrefs.GetFloat("bathroom_z2");
            }
            else if (gameObject.name.Equals("Bathtub"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x3");
                y = PlayerPrefs.GetFloat("bathroom_y3");
                z = PlayerPrefs.GetFloat("bathroom_z3");
            }
            else if (gameObject.name.Equals("Coat rack"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x4");
                y = PlayerPrefs.GetFloat("bathroom_y4");
                z = PlayerPrefs.GetFloat("bathroom_z4");
            }
            else if (gameObject.name.Equals("Box"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x5");
                y = PlayerPrefs.GetFloat("bathroom_y5");
                z = PlayerPrefs.GetFloat("bathroom_z5");
            }
            else if (gameObject.name.Equals("Box2"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x6");
                y = PlayerPrefs.GetFloat("bathroom_y6");
                z = PlayerPrefs.GetFloat("bathroom_z6");
            }
            else if (gameObject.name.Equals("Closet"))
            {
                x = PlayerPrefs.GetFloat("bathroom_x7");
                y = PlayerPrefs.GetFloat("bathroom_y7");
                z = PlayerPrefs.GetFloat("bathroom_z7");
            }
        }
        LoadPosition = new Vector3(x, y, z);
        this.transform.position = LoadPosition;
    }
}
