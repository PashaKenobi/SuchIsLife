using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnFurniture : MonoBehaviour
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
        if(gameObject.name.Equals("Lava lamp1"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x", x);
            PlayerPrefs.SetFloat("y", y);
            PlayerPrefs.SetFloat("z", z);
        }
        else if (gameObject.name.Equals("Bookstore1"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x1", x);
            PlayerPrefs.SetFloat("y1", y);
            PlayerPrefs.SetFloat("z1", z);
        }
        else if (gameObject.name.Equals("Bookstore2"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x2", x);
            PlayerPrefs.SetFloat("y2", y);
            PlayerPrefs.SetFloat("z2", z);
        }
        else if (gameObject.name.Equals("Bookstore3"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x3", x);
            PlayerPrefs.SetFloat("y3", y);
            PlayerPrefs.SetFloat("z3", z);
        }
        else if (gameObject.name.Equals("Lava lamp2"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x4", x);
            PlayerPrefs.SetFloat("y4", y);
            PlayerPrefs.SetFloat("z4", z);
        }
        else if (gameObject.name.Equals("Bed"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x5", x);
            PlayerPrefs.SetFloat("y5", y);
            PlayerPrefs.SetFloat("z5", z);
        }
        else if (gameObject.name.Equals("Short Drawer"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x6", x);
            PlayerPrefs.SetFloat("y6", y);
            PlayerPrefs.SetFloat("z6", z);
        }
        else if (gameObject.name.Equals("Long Drawer"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x7", x);
            PlayerPrefs.SetFloat("y7", y);
            PlayerPrefs.SetFloat("z7", z);
        }
        else if (gameObject.name.Equals("Flowerpot"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x8", x);
            PlayerPrefs.SetFloat("y8", y);
            PlayerPrefs.SetFloat("z8", z);
        }
        else if (gameObject.name.Equals("Table"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x9", x);
            PlayerPrefs.SetFloat("y9", y);
            PlayerPrefs.SetFloat("z9", z);
        }
        else if (gameObject.name.Equals("TV"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x10", x);
            PlayerPrefs.SetFloat("y10", y);
            PlayerPrefs.SetFloat("z10", z);
        }
        else if (gameObject.name.Equals("Couch"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x11", x);
            PlayerPrefs.SetFloat("y11", y);
            PlayerPrefs.SetFloat("z11", z);
        }
        else if (gameObject.name.Equals("Carpet"))
        {
            x = this.transform.position.x;
            y = this.transform.position.y;
            z = this.transform.position.z;

            PlayerPrefs.SetFloat("x12", x);
            PlayerPrefs.SetFloat("y12", y);
            PlayerPrefs.SetFloat("z12", z);
        }

    }

    public void Load()
    {
        first = PlayerPrefs.GetInt("foo");
        if (first == 1 || PlayerPrefs.GetInt("foo").Equals(null))
        {
            if (gameObject.name.Equals("Lava lamp1"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;    
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Bookstore1"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Bookstore2"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Bookstore3"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Lava lamp2"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Bed"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Short Drawer"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Long Drawer"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Flowerpot"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Table"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("TV"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Couch"))
            {
                x = this.transform.position.x;
                y = this.transform.position.y;
                z = this.transform.position.z;
            }
            else if (gameObject.name.Equals("Carpet"))
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
            if (gameObject.name.Equals("Lava lamp1"))
            {
                x = PlayerPrefs.GetFloat("x");
                y = PlayerPrefs.GetFloat("y");
                z = PlayerPrefs.GetFloat("z");
            }
            else if (gameObject.name.Equals("Bookstore1"))
            {
                x = PlayerPrefs.GetFloat("x1");
                y = PlayerPrefs.GetFloat("y1");
                z = PlayerPrefs.GetFloat("z1");
            }
            else if (gameObject.name.Equals("Bookstore2"))
            {
                x = PlayerPrefs.GetFloat("x2");
                y = PlayerPrefs.GetFloat("y2");
                z = PlayerPrefs.GetFloat("z2");
            }
            else if (gameObject.name.Equals("Bookstore3"))
            {
                x = PlayerPrefs.GetFloat("x3");
                y = PlayerPrefs.GetFloat("y3");
                z = PlayerPrefs.GetFloat("z3");
            }
            else if (gameObject.name.Equals("Lava lamp2"))
            {
                x = PlayerPrefs.GetFloat("x4");
                y = PlayerPrefs.GetFloat("y4");
                z = PlayerPrefs.GetFloat("z4");
            }
            else if (gameObject.name.Equals("Bed"))
            {
                x = PlayerPrefs.GetFloat("x5");
                y = PlayerPrefs.GetFloat("y5");
                z = PlayerPrefs.GetFloat("z5");
            }
            else if (gameObject.name.Equals("Short Drawer"))
            {
                x = PlayerPrefs.GetFloat("x6");
                y = PlayerPrefs.GetFloat("y6");
                z = PlayerPrefs.GetFloat("z6");
            }
            else if (gameObject.name.Equals("Long Drawer"))
            {
                x = PlayerPrefs.GetFloat("x7");
                y = PlayerPrefs.GetFloat("y7");
                z = PlayerPrefs.GetFloat("z7");
            }
            else if (gameObject.name.Equals("Flowerpot"))
            {
                x = PlayerPrefs.GetFloat("x8");
                y = PlayerPrefs.GetFloat("y8");
                z = PlayerPrefs.GetFloat("z8");
            }
            else if (gameObject.name.Equals("Table"))
            {
                x = PlayerPrefs.GetFloat("x9");
                y = PlayerPrefs.GetFloat("y9");
                z = PlayerPrefs.GetFloat("z9");
            }
            else if (gameObject.name.Equals("TV"))
            {
                x = PlayerPrefs.GetFloat("x10");
                y = PlayerPrefs.GetFloat("y10");
                z = PlayerPrefs.GetFloat("z10");
            }
            else if (gameObject.name.Equals("Couch"))
            {
                x = PlayerPrefs.GetFloat("x11");
                y = PlayerPrefs.GetFloat("y11");
                z = PlayerPrefs.GetFloat("z11");
            }
            else if (gameObject.name.Equals("Carpet"))
            {
                x = PlayerPrefs.GetFloat("x12");
                y = PlayerPrefs.GetFloat("y12");
                z = PlayerPrefs.GetFloat("z12");
            }
        }
        LoadPosition = new Vector3(x, y, z);
        this.transform.position = LoadPosition;

    }
}
