using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class DialogueManager : MonoBehaviour
{
    public Dialogue[] dialogues;
    public Dialogue activeDialogue;
    public int activeDialogueID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            tryProcessLine();
    }
    //advances new line
    public void tryProcessLine()
    {
        processLine();
    }
    //process current line
    public void processLine() {
        activeDialogue.activeDialogueBranch().dialogueLine++;
        //more
    }
    
    public string saveDialogue() {
        StringBuilder sb = new StringBuilder(20);
        sb.Append(activeDialogue.saveMain(this));
        return sb.ToString();
    }
    public void loadDialogue(string dialogueInfo)
    {
        //finds correct dialogue
        int charactersUntil = dialogueInfo.IndexOf(',');
        int dialogueNumber = int.Parse(dialogueInfo.Substring(0, charactersUntil));
        dialogueInfo = dialogueInfo.Remove(0, charactersUntil);
        activeDialogue = dialogues[dialogueNumber];

        //loads that dialogue
        activeDialogue.loadMain(dialogueInfo);
        //makes that line appear on the text
        processLine();
    }

}
