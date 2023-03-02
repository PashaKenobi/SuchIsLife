using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public bool enter;
    public string Scene;

    void Update()
    {
        if (enter)
        {
            SceneManager.LoadScene(Scene);
        }
    }

    private void OnTriggerEnter2D(Collider2D door)
    {
        if (door.GetComponent<RoadToHospitalWest>())
        {
            Scene = "Map 2";
            enter = true;
        }
        else if (door.GetComponent<RoadToHospitalEast>())
        {
            Scene = "Map 2";
            enter = true;
        }
        else if (door.GetComponent<RoadToWarehouse>())
        {
            Scene = "Map 3";
            enter = true;
        }
        else if (door.GetComponent<RoadToHome>())
        {
            Scene = "Map 1";
            enter = true;
        }
        else if (door.GetComponent<RoadtoPark>())
        {
            Scene = "CaravanPark";
            enter = true;
        }

    }

    private void OnTriggerExit2D(Collider2D door)
    {
        if (door.GetComponent<RoadToHospitalWest>() || door.GetComponent<RoadToHospitalEast>() ||
            door.GetComponent<RoadToWarehouse>() || door.GetComponent<RoadToHome>() || door.GetComponent<RoadtoPark>()) 
        {
            enter = false;
        }
    }
}
