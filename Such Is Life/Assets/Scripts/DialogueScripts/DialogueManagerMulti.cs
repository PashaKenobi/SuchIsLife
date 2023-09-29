using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManagerMulti : MonoBehaviour
{
    public float delay;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Image speakerPortraitEmpty;
    public GameObject dialogueBox;
    public bool visibleOnInit;
    public int destroyAfterRepetitions = 10;
    private int repeatCount = 0;
    public bool isEnding;    
    public Player player;
    public GameObject goodEndingPanel;
    public GameObject badEndingPanel;

    private Queue<string> sentences;

    // Awake is called before the scene starts, we initialize the Queue that will store our sentences.
    private void Awake()
    {
        sentences = new Queue<string>();
        setPanelVisibility(visibleOnInit);
    }

    // This is called every second, helps us further the dialogue whenever we press spacebar or a button
    public void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && dialogueBox.activeSelf){
            DisplayNextSentence();
        }
    }

    //Puts the dialogue sentences in a queue to store them
    public void StartDialogue (Dialogue dialogue){
        nameText.text = dialogue.speakerName;
        speakerPortraitEmpty.sprite = dialogue.speakerPortrait;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    // Key feature, furthers the dialogue
    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence)); //Uses asynchronous programming to type the sentence letter by letter.
    }

    //Like stated above, types the sentences letter by letter.
    IEnumerator TypeSentence(string sentence){
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogueText.text+= letter;
            yield return new WaitForSeconds(delay);
        }
    }

    //Ends the dialogue and renders the dialogue box invisible for the time being.
    public void EndDialogue(){
        repeatCount++;
        setPanelVisibility(false);
        if(destroyAfterRepetitions == repeatCount){
            Destroy(this);
        }
        if(isEnding){
            presentEnding();
        }
        Debug.Log("End of conversation.");
    }

    //The function used to make the dialogue box disappear.
    public void setPanelVisibility(bool panelStatus){
        if (dialogueBox != null) {
            dialogueBox.SetActive(panelStatus);  
        }  
    }

    public void setPanelVisible(){
        dialogueBox.SetActive(true);
    }

    public void presentEnding(){
        if(player.GetEnding()){
            goodEndingPanel.SetActive(true);
            Destroy(player);
        }
        else{
            badEndingPanel.SetActive(true);
            Destroy(player);
        }
    }


}
