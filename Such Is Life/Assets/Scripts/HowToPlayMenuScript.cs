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
}
