using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : Interactable
{
    //be sure to reimplement to be able to deal with changing progression
    public Dialogue dialogue;

    public override void Interact()
    {
        DialogueManager.Instance.StartDialogue(dialogue);
    }

}
