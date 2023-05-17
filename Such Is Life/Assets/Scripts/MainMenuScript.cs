using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    PlayerData playerData;
    public void PlayGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("save", 100);
        PlayerPrefs.SetInt("save1", 100);
        PlayerPrefs.SetInt("save2", 100);
        PlayerPrefs.SetInt("money", 100);
        PlayerPrefs.SetFloat("Seconds", 0);
        PlayerPrefs.SetInt("Mins", 0);
        PlayerPrefs.SetInt("Hours", 12);
        PlayerPrefs.SetInt("Days", 1);
        PlayerPrefs.Save();
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
    public void Load()
    {
        playerData = SaveSystem.LoadPlayer();
        if (playerData.scene == null ) {
            SceneManager.LoadScene("Map 2");
        }
        else
        SceneManager.LoadScene(playerData.scene);
    }

}
