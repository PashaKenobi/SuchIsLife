using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryJobPayment : MonoBehaviour
{

    public Player player;
    public ShopManager payer;
    public DialogueManager2 followUp;
    
    public void payForJob(){
        if(player.GetFurn()){
            payer.AddCoin(2000);
            showDialogue();
        }
    }

    public void showDialogue(){
        followUp.setPanelVisible();
    }
}
