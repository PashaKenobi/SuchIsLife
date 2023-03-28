using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Text coinText;

    void Start()
    {
        string coinString = coinText.text.ToString();
        int coinInt = int.Parse(coinString);
        print(coinInt + 2);
    }
    public int TransformText ()
    {
        string coinString = coinText.text.ToString();
        int coinInt = int.Parse(coinString);

       return coinInt;
        
    }
    public void AddCoin(int amount)
    {
        int currentCoin = TransformText();
        print(currentCoin);
        coinText.text = (currentCoin + amount).ToString();
    }
    public void SubCoin(int amount)
    {
        int currentCoin = TransformText();
        coinText.text = (currentCoin - amount).ToString();

    }
}
