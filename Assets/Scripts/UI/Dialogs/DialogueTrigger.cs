using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue dl;
    public DialogueManager dialogManager;

    public void TriggerDialogue()
    {
        dialogManager.StartDialogue(dl);
        //FindObjectOfType<DialogueManager>().StartDialogue(dl);
    }
}
