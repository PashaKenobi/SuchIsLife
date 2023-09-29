using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public GameObject shopMenuBox;
    // Start is called before the first frame update
    void Start()
    {
        shopMenuBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPanelVisibile()
    {
        shopMenuBox.SetActive(true);
        Debug.Log("Pressed button, set true");
    }

    public void setPanelInvisibile()
    {
        shopMenuBox.SetActive(false);
        Debug.Log("Pressed button, set false");
    }


}
