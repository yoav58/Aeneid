using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColliderElring : MonoBehaviour
{
    public GameObject mark;
    public TMP_Text massageGuide;
    public DialogueTrigger dr;
    bool isInRange = false;

    private bool inputOnce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Return) && inputOnce == true && isInRange)
        {
            dr.TriggerDialogue();
            inputOnce = false;
        }

        if (!Input.GetKey(KeyCode.Return))
        {
            inputOnce = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mark.SetActive(true);
            massageGuide.text = "Press Enter to Speak with Elring";
            isInRange = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mark.SetActive(false);
            massageGuide.text = "";
            isInRange = false;
        }
    }
}
