using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    Queue<string> sentences;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }



    public void StartDialogue(Dialogue d)
    {
        Time.timeScale = 0;
        canvas.SetActive(true);
        nameText.text = d.name;
        Debug.Log("start c with " + d.name);
        sentences.Clear();
        foreach (string sentnce in d.sentences)
        {
            sentences.Enqueue(sentnce);
        }

        displayNextSentence();
    }

    public void displayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string s = sentences.Dequeue();
        dialogueText.text = s;
    }

    private void EndDialogue()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }

}
