using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Map 2");
    }

    public void QuitGame()
    {
        Debug.Log("Quit successful.");
        Application.Quit();
    }

    public void OpenHowToPlayScreen()
    {
        SceneManager.LoadScene("How To Play");
    }
   
}
