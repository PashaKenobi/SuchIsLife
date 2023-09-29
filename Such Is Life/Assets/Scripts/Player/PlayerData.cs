using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    public int health;
    public int hunger;
    public int energy;
    public int coin;
    public string scene;

    public PlayerData(Player player)
    {
        health = player.health;
        hunger = player.hunger; 
        energy = player.energy; 
        coin = player.coin;
        scene = player.scene;
    }
}
