using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BankManager : MonoBehaviour
{
    public Text balanceText;
    public int balance;
    public ShopManager pocketMoney;
    public InputField deposit;
    public InputField withdrawal;

    // Start is called before the first frame update
    void Start()
    {
        balance = PlayerPrefs.GetInt("balance");
        balanceText.text = balance.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        balanceDebug();
    }

    void balanceDebug()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            AddBalance(50);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            SubBalance(50);
        }
    }

    public void depositMoney(){
        int dep;
        bool intCheck = int.TryParse(deposit.text, out dep);
        if(intCheck){
            AddBalance(dep);
        }
    }

    public void withdrawMoney(){
        int draw;
        bool intCheck = int.TryParse(withdrawal.text, out draw);
        if(intCheck){
            SubBalance(draw);
        }
    }

    public void AddBalance(int amount)
    {
        int currentBalance = balance;
        balance = currentBalance + amount;
        balanceText.text = balance.ToString();
        PlayerPrefs.SetInt("balance", balance);
        pocketMoney.SubCoin(amount);
    }

    public void SubBalance(int amount)
    {
        int currentBalance = balance;
        balance = currentBalance - amount;
        balanceText.text = balance.ToString();
        PlayerPrefs.SetInt("balance", balance);
        pocketMoney.AddCoin(amount);
    }

    
}
