using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorControl : MonoBehaviour
{
    public bool enter;
    public string Scene;

    void Update()
    { 
       if(enter && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(Scene);
        }
    }

    private void OnTriggerEnter2D(Collider2D door)
    {
        if (door.GetComponent<PcHouseDoor>())
        {
            Scene = "PCHouse";
            enter = true;
        }
        else if (door.GetComponent<PcDoor>())
        {
            Scene = "Map 1";
            enter = true;
        }
        else if (door.GetComponent<wareDoor>())
        {
            Scene = "Warehouse";
            enter = true;
        }
        else if (door.GetComponent<wareHouseDoor>())
        {
            Scene = "Map 3";
            enter = true;
        }
        else if (door.GetComponent<RoadtoNPC>())
        {
            Scene = "WDownLeft";
            enter = true;
        }
        else if (door.GetComponent<RoadtoNPC2>())
        {
            Scene = "WDownRight";
            enter = true;
        }
        else if (door.GetComponent<RoadtoNPC3>())
        {
            Scene = "WUpRight";
            enter = true;
        }
        else if (door.GetComponent<RoadToShop>())
        {
            Scene = "Shop";
            enter = true;
        }
        else if (door.GetComponent<Bank>())
        {
            Scene = "Bank";
            enter = true;
        }
        else if (door.GetComponent<Hospital>())
        {
            Scene = "Hospital";
            enter = true;
        }
        else if (door.GetComponent<Caravan>())
        {
            Scene = "Caravan";
            enter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D door)
    {
        if(door.GetComponent<PcHouseDoor>() || door.GetComponent<wareHouseDoor>() || door.GetComponent<PcDoor>() ||
           door.GetComponent<wareDoor>() || door.GetComponent<RoadtoNPC>() || door.GetComponent<RoadtoNPC2>() || door.GetComponent<RoadtoNPC3>()
           || door.GetComponent<RoadToShop>() || door.GetComponent<Bank>()|| door.GetComponent<Caravan>())
        {
            enter = false;
        }
    }
}
