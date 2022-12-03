using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorControl : MonoBehaviour
{
    public Collider2D collider1;
    public GameObject building;

    void Update()
    { 
        OnTriggerStay2D(collider1);
    }

    private void OnTriggerStay2D(Collider2D player)
    {
        if (player.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                openDoor();
            }
        }
    }
    void openDoor()
    {
        if (building.CompareTag("Warehouse"))
        {
            SceneManager.LoadScene("Warehouse");
        }
        else if (building.CompareTag("PCHouse"))
        {
            SceneManager.LoadScene("PCHouse");
        }
    }
}
