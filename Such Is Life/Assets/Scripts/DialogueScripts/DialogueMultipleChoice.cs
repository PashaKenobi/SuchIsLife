using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMultipleChoice : MonoBehaviour
{
    public Dialogue dialogue1;
    public Dialogue dialogue2;
    public Player player;
    public bool endingFork;

    private void Start(){
        TriggerDialogue();
    }

    public void TriggerDialogue ()
    {
        if(endingFork){
            
          if(player.GetEnding()){
              FindObjectOfType<DialogueManagerMulti>().StartDialogue(dialogue1);
          }
          else{
              FindObjectOfType<DialogueManagerMulti>().StartDialogue(dialogue2);
          }
        }
        else{

          if(player.GetFurn()){
              FindObjectOfType<DialogueManagerMulti>().StartDialogue(dialogue1);
          }
          else{
              FindObjectOfType<DialogueManagerMulti>().StartDialogue(dialogue2);
          }
        }
    }
}
