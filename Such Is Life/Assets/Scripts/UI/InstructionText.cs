using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InstructionText : MonoBehaviour
{
    public TextMeshProUGUI instructText;
    public KeyCode disappearKey;
    public bool oneTimeThing;
    public bool alreadyShown = false;
    public GameObject textHolder;
    // Start is called before the first frame update
    void Start()
    {
        if (intToBool(PlayerPrefs.GetInt("once")).Equals(null))
        {
            alreadyShown = false;
        }
        else { 
           alreadyShown = intToBool(PlayerPrefs.GetInt("once")); 
        }
        textHolder.SetActive(true);
     if(oneTimeThing && alreadyShown){
        textHolder.SetActive(false);
     }   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(disappearKey)){
            alreadyShown = true;
            PlayerPrefs.SetInt("once", boolToInt(alreadyShown));
            textHolder.SetActive(false);
        }
    }
    int boolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }
}
