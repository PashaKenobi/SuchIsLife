using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Text coinText;
    public int coinInt;

    void Start()
    {
        PlayerData playerData = SaveSystem.LoadPlayer();
        coinInt = playerData.coin;
        coinText.text = coinInt.ToString();
    }
    public int TransformText ()
    {
        //string coinString = coinText.text.ToString();
        //coinInt = int.Parse(coinString);
       return coinInt;
        
    }
    public void Update ()
    {
        add();
    }
    void add()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            AddCoin(50);
        }
    }
    /*public void displayCoin()
    {
        coin.text = "" + coinInt;
    }
    public void FixedUpdate()
    {
        displayCoin();
    }*/
    public void AddCoin(int amount)
    {
        int currentCoin = TransformText();
        print(currentCoin);
        coinInt = currentCoin+amount;
        coinText.text = coinInt.ToString();
        PlayerPrefs.SetInt("money", coinInt);
    }
    public void SubCoin(int amount)
    {
        int currentCoin = TransformText();
        coinInt = currentCoin - amount;
        coinText.text = coinInt.ToString();
        PlayerPrefs.SetInt("money", coinInt);
    }
}
