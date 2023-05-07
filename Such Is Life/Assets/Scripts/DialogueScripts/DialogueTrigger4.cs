using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger4 : MonoBehaviour
{
    public Dialogue dialogue;

    private void Start(){
        TriggerDialogue();
    }

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager4>().StartDialogue(dialogue);
    }
}
