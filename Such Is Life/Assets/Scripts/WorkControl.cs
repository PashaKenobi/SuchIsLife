using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorkControl : MonoBehaviour

{
    public GameObject workUI;
    public int workHours;

    // Start is called before the first frame update
    void Start()
    {
        workUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoWorkshift(){
        StopAllCoroutines();
        StartCoroutine(DoShift());

    }

    IEnumerator DoShift(){
        workUI.SetActive(true);
        Time.timeScale = 6f;
        yield return new WaitForSecondsRealtime(workHours+2);
        workUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
