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
            Scene = "SampleScene";
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
    }

    private void OnTriggerExit2D(Collider2D door)
    {
        if(door.GetComponent<PcHouseDoor>() || door.GetComponent<wareHouseDoor>() || door.GetComponent<PcDoor>() ||
           door.GetComponent<wareDoor>())
        {
            enter = false;
        }
    }
}
