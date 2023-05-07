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
            textHolder.SetActive(false);
        }
    }
}
