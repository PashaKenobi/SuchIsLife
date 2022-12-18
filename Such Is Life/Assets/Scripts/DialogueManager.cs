using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public float delay;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Image speakerPortraitEmpty;
    public GameObject dialogueBox;

    private Queue<string> sentences;

    // Start is called before the first frame update
    private void Awake()
    {
        sentences = new Queue<string>();
    }

    public void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && dialogueBox.activeSelf){
            DisplayNextSentence();
        }
    }

    public void StartDialogue (Dialogue dialogue){
        nameText.text = dialogue.speakerName;
        speakerPortraitEmpty.sprite = dialogue.speakerPortrait;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence){
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogueText.text+= letter;
            yield return new WaitForSeconds(delay);
        }
    }

    public void EndDialogue(){
        setPanelVisibility(false);
        Debug.Log("End of conversation.");
    }

    public void setPanelVisibility(bool panelStatus){
        if (dialogueBox != null) {
            dialogueBox.SetActive(panelStatus);  
        }  
    }
}
