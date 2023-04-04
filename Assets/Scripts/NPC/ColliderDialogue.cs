using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ColliderDialogue : MonoBehaviour
{
    public GameObject mark;
    public TMP_Text massageGuide;
    public DialogueTrigger dr;
    bool isInRange = false;
    public string nameToSpeakWith;
    public string missionsToCompleName;
    public bool finishedOnce = true;
    public int missionCount;
    public string[] newSentences;
    private bool inputOnce;

    public bool hasMissions = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Return) && inputOnce == true && isInRange)
        {
            if (checkMissionCompleted())
            {
                dr.ChangeDialogue(newSentences);
                Debug.Log("conpleted");
            }
            dr.TriggerDialogue();
            inputOnce = false;
            if(hasMissions) addMissions();
            hasMissions = false;
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
            massageGuide.text = "Press Enter to Speak with " + nameToSpeakWith;
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

    private bool checkMissionCompleted()
    {
        if (PlayerPrefs.GetInt(missionsToCompleName) == missionCount)
        {
            if (finishedOnce) awardMethod();
            finishedOnce = false;
            return true;
        }
        return false;
    }
    
    public virtual void awardMethod(){}
    public virtual void addMissions(){}
}
