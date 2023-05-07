using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool inRange;
    public KeyCode interactKey;
    public UnityEvent interactAction1;
    public UnityEvent interactAction2;
    public UnityEvent interactAction3;
    public UnityEvent interactAction4;
    public UnityEvent interactAction5;
    public UnityEvent interactAction6;
    public int keyCount = 0;
    public bool limitedInteraction = false;
    private List<UnityEvent> actions = new List<UnityEvent>();
    
    // Start is called before the first frame update
    private void Awake()
    {
        actions.Add(interactAction1);
        actions.Add(interactAction2);
        actions.Add(interactAction3);
        actions.Add(interactAction4);
        actions.Add(interactAction5);
        actions.Add(interactAction6);
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            if (!limitedInteraction && Input.GetKeyDown(interactKey))
            {
                interactAction1.Invoke();
            }
            if (limitedInteraction && keyCount <= 5 && Input.GetKeyDown(interactKey)){
                actions[keyCount].Invoke();
                keyCount++;
            }
            if(limitedInteraction && keyCount > 5 && Input.GetKeyDown(interactKey)){
                DummyEvent();
            }
        }
        
    }

    public void DummyEvent(){
        Debug.Log("dummy event");
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            inRange = true;
            Debug.Log("in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            inRange = false;
            Debug.Log("not in range");
        }
    }
}
