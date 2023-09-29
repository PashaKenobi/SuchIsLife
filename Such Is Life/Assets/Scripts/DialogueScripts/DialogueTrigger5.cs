using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger5 : MonoBehaviour
{
    public Dialogue dialogue;

    private void Start(){
        TriggerDialogue();
    }

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager5>().StartDialogue(dialogue);
    }
}
