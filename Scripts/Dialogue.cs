using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/Dialogue", order = 1)]
public class Dialogue : ScriptableObject
{
    [SerializeField]
    public DialogueBranch[] dialogueBranches;
    public int dialogueID;
    public Player myPlayer;
    public int activeDialogueBranchID;

    public DialogueBranch activeDialogueBranch() {
        return dialogueBranches[activeDialogueBranchID];
    }
    // Start is called after the manager takes control of it
    public virtual void startDialogue()
    {

    }
    //
    public void loadMain(string myData)
    {

        int charactersUntil = myData.IndexOf(',');
        int dialogueNumber = int.Parse(myData.Substring(0, charactersUntil));
        activeDialogueBranch().dialogueLine = dialogueNumber;
        myData = myData.Remove(0, charactersUntil);
    }
    public string saveMain(DialogueManager dialogueManager) {

        return dialogueID+","+activeDialogueBranch().dialogueLine+",";
    }
    public virtual void makeChoice(int choice) { 
    
    }
}