using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayMenuScript : MonoBehaviour
{
    public void goBackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void goNextPage()
    {
        SceneManager.LoadScene("Htp 2");
    }

    public void goNextPage2()
    {
        SceneManager.LoadScene("Htp 3");
    }
}
