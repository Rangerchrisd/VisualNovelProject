using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginingSpeach : Dialogue
{
    public override void startDialogue()
    {
    }

    public override void makeChoice(int choice)
    {
        base.makeChoice(choice);
        if (activeDialogueBranch().dialogueLine == 8) {
            if (choice == 1)
            {
                //join me
            }
            else if (choice== 2) { 
                //then perish
            }
        }else  if (activeDialogueBranch().dialogueLine == 20)
        {
            if (choice == 1)
            {
                //join me
            }
            else if (choice == 2)
            {
                //then perish
            }
        }
    }
}
